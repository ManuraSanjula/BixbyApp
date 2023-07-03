﻿using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Bixby_web_server.Models;
using Microsoft.IdentityModel.Tokens;
using MongoDB.Driver;

namespace BixbyShop_LK.Services
{
    public static class TokenService
    {
        public delegate void UserDelegate(string token);

        private static string secretKey = "hdsacsfhfjfvjdjsjvdsjvsjdvjsdjvdsvkjsbjbfjbgjsb";
        private static string issuer = "Manura Sanjula";
        private static string audience = "Manura Sanjula";
        private static UserService userService = new UserService();

        private static async Task<string> GenerateJwtToken(string secretKey, string issuer, string audience, int expiryMinutes, string? email, string password, User user)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey));
            var signingCredentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var claims = new List<Claim>
            {
                new Claim(JwtRegisteredClaimNames.Sub, "subject"),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(JwtRegisteredClaimNames.Iat, DateTimeOffset.UtcNow.ToUnixTimeSeconds().ToString(), ClaimValueTypes.Integer64),
                new Claim("email", email),
                new Claim("password", password)
            };

            var token = new JwtSecurityToken(
                issuer,
                audience,
                claims,
                expires: DateTime.UtcNow.AddMinutes(expiryMinutes),
                signingCredentials: signingCredentials
            );
            var userToken = new JwtSecurityTokenHandler().WriteToken(token);

            if (user != null)
            {
                if (user.UserAuthTokens == null || user.UserAuthTokens.Count == 0)
                {
                    user.UserAuthTokens = new List<string> { userToken };

                    if (await userService.UpdateUserAsync(user.Id, user))
                    {
                        IEmailService emailService = new EmailServiceHelper();
                        EmailService._emailServiceHelper = emailService;
                        _ = EmailService.SendEmail(user.Email, "Email Verification Code for Your Account 🙂🙂", 0);
                        return userToken;
                    }
                }
                else
                {
                    user.UserAuthTokens.Add(userToken);
                    if (await userService.UpdateUserAsync(user.Id, user))
                    {
                        IEmailService emailService = new EmailServiceHelper();
                        EmailService._emailServiceHelper = emailService;
                        _ = EmailService.SendEmail(user.Email, "Email Verification Code for Your Account 🙂🙂", 0);
                        return userToken;
                    }
                    else
                    {
                        return null;
                    }
                }
            }

            return null;
        }

        private static async Task<dynamic> ExtractCustomClaim(string jwtToken, bool allowBoolean)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.ReadJwtToken(jwtToken);
            var claims = token.Claims;

            var email = claims.FirstOrDefault(c => c.Type == "email")?.Value;
            var password = claims.FirstOrDefault(c => c.Type == "password")?.Value;
            var user = await userService.GetUserByEmailAsync(email.ToString());

            if (user == null)
            {
                return null;
            }
            else
            {
                if (user.Password == password && !user.UserAuthTokens.Contains(jwtToken))
                {
                    return null;
                }
                else
                {
                    if (user.Password == password)
                    {
                        if (allowBoolean)
                        {
                            return true;
                        }
                        else
                        {
                            return user;
                        }
                    }
                }
                return null;
            }
        }

        public static async Task<string> tokenCreator(string? email, string password, User user)
        {
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                return null;
            }
            int expiryMinutes = 10000;
            return await GenerateJwtToken(secretKey, issuer, audience, expiryMinutes, email, password, user);
        }

        public async static Task<dynamic> ValidateJwtToken(string token, bool allowBoolean = false)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var validationParameters = new TokenValidationParameters
            {
                ValidateIssuer = true,
                ValidateAudience = true,
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey)),
                ValidIssuer = issuer,
                ValidAudience = audience
            };

            try
            {
                SecurityToken validatedToken;
                tokenHandler.ValidateToken(token, validationParameters, out validatedToken);
                return await ExtractCustomClaim(token, allowBoolean);
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
