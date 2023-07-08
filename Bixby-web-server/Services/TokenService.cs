using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Bixby_web_server.Models;
using Microsoft.IdentityModel.Tokens;
using MongoDB.Bson;
using Newtonsoft.Json;

namespace Bixby_web_server.Services;

public static class TokenService
{
    private const string SecretKey = "hdsacsfhfjfvjdjsjvdsjvsjdvjsdjvdsvkjsbjbfjbgjsb";
    private const string Issuer = "Manura Sanjula";
    private const string Audience = "Manura Sanjula";
    private static readonly UserService UserService = new();

    private static async Task<string?> GenerateJwtToken(bool loginPath, string path, string secretKey, string issuer,
        string audience, int expiryMinutes, string? email, string password, User user)
    {
        var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey));
        var signingCredentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

        if (email != null)
        {
            var claims = new List<Claim>
            {
                new(JwtRegisteredClaimNames.Sub, "subject"),
                new(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new(JwtRegisteredClaimNames.Iat, DateTimeOffset.UtcNow.ToUnixTimeSeconds().ToString(),
                    ClaimValueTypes.Integer64),
                new("email", email),
                new("password", password)
            };

            var token = new JwtSecurityToken(
                issuer,
                audience,
                claims,
                expires: DateTime.UtcNow.AddMinutes(expiryMinutes),
                signingCredentials: signingCredentials
            );
            var userToken = new JwtSecurityTokenHandler().WriteToken(token);

            if (user.UserAuthTokens.Count == 0)
            {
                user.UserAuthTokens = new List<string> { userToken };

                if (!await UserService.UpdateUserAsync(user.Id, user)) return userToken;
                _ = EmailService.SendEmail(path, user.Email, "Email Verification Code for Your Account 🙂🙂", 0,
                    user);
                return userToken;
            }

            user.UserAuthTokens.Add(userToken);
            if (!await UserService.UpdateUserAsync(user.Id, user)) return null;
            
            if (!loginPath) return userToken;

            _ = EmailService.SendEmail(path, user.Email, "Email Verification Code for Your Account 🙂🙂", 0,
                user);
            return userToken;
        }

        return null;
    }

    private static async Task<dynamic?> ExtractCustomClaim(string jwtToken, bool allowBoolean)
    {
        var tokenHandler = new JwtSecurityTokenHandler();
        var token = tokenHandler.ReadJwtToken(jwtToken);
        var claims = token.Claims;

        var enumerable = claims as Claim[] ?? claims.ToArray();
        var email = enumerable.FirstOrDefault(c => c.Type == "email")?.Value;
        var password = enumerable.FirstOrDefault(c => c.Type == "password")?.Value;

        User? user = await UserService.GetUserByEmailAsync(email);
        if (user == null) return null;
        if (user.Password == password && !user.UserAuthTokens.Contains(jwtToken)) return null;
        if (user.Password != password) return null;

        if (user.Password == password && !user.UserAuthTokens.Contains(jwtToken)) return null;

        if (user.Password != password) return false;
        if (allowBoolean)
            return true;
        return user;
    }

    public static async Task<string?> TokenCreator(bool loginPath, string path, string? email, string password,
        User user)
    {
        if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password)) return null;
        const int expiryMinutes = 10000;
        return await GenerateJwtToken(loginPath, path, SecretKey, Issuer, Audience, expiryMinutes, email, password,
            user);
    }

    public static async Task<dynamic?> ValidateJwtToken(string token, bool allowBoolean = false)
    {
        var tokenHandler = new JwtSecurityTokenHandler();
        var validationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(SecretKey)),
            ValidIssuer = Issuer,
            ValidAudience = Audience
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