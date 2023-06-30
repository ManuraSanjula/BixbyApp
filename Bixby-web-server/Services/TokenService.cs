using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
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

        private static string GenerateJwtToken(string secretKey, string issuer, string audience, int expiryMinutes, string email, string password, UserNewAccountDelegate userNewAccountDelegate, User user)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey));
            var signingCredentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var claims = new[]
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
            String UserToken= new JwtSecurityTokenHandler().WriteToken(token);

            return userNewAccountDelegate(UserToken, user);
        }

        private static dynamic ExtractCustomClaim(string jwtToken, bool allowBoolean, UserDelegate userDelegate)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.ReadJwtToken(jwtToken);
            var claims = token.Claims;

            var email = claims.FirstOrDefault(c => c.Type == "email");
            var password = claims.FirstOrDefault(c => c.Type == "password");

            User user = userService.GetUserByEmail(email.ToString());
            if (user == null)
            {
                userDelegate(jwtToken + " You Fucking Pussy 2");
                return null;
            }
            else
            {
                if (user.Password == password.ToString())
                {
                    if (allowBoolean)
                    {
                        userDelegate(jwtToken + " Fuck you 1");
                        return true;
                    }
                    else
                    {
                        userDelegate(jwtToken + " Fuck you 2");
                        return user;
                    }
                }
                return null;

            }
        }

        public delegate String UserNewAccountDelegate(string token, User user);

        public static string tokenCreator(string email, string password, UserNewAccountDelegate userNewAccountDelegate, User user)
        {
            if (string.IsNullOrEmpty(email) && string.IsNullOrEmpty(password))
            {
                return userNewAccountDelegate(null, null);
            }
            int expiryMinutes = 10000;
            return GenerateJwtToken(secretKey, issuer, audience, expiryMinutes, email, password, userNewAccountDelegate, user);
        }
        public static dynamic ValidateJwtToken(string token, bool allowBoolean, UserDelegate userDelegate)
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
                return ExtractCustomClaim(token, allowBoolean, userDelegate);
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
