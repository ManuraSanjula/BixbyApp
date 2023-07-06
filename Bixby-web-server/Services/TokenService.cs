using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Bixby_web_server;
using Bixby_web_server.Models;
using Microsoft.IdentityModel.Tokens;
using MongoDB.Bson;
using Newtonsoft.Json;

namespace BixbyShop_LK.Services;

public static class TokenService
{
    public delegate void UserDelegate(string token);

    private static readonly string secretKey = "hdsacsfhfjfvjdjsjvdsjvsjdvjsdjvdsvkjsbjbfjbgjsb";
    private static readonly string issuer = "Manura Sanjula";
    private static readonly string audience = "Manura Sanjula";
    private static readonly UserService userService = new();

    private static async Task<string> GenerateJwtToken(bool loginPath, string path, string secretKey, string issuer,
        string audience, int expiryMinutes, string? email, string password, User user)
    {
        var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey));
        var signingCredentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

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

        if (user != null)
        {
            if (user.UserAuthTokens == null || user.UserAuthTokens.Count == 0)
            {
                user.UserAuthTokens = new List<string> { userToken };

                if (await userService.UpdateUserAsync(user.Id, user))
                {
                    if (!loginPath)
                    {
                        RedisCache.Set(user.Email, user.ToJson());
                        return userToken;
                    }

                    _ = EmailService.SendEmail(path, user.Email, "Email Verification Code for Your Account 🙂🙂", 0,
                        user);
                    return userToken;
                }
            }
            else
            {
                user.UserAuthTokens.Add(userToken);
                if (await userService.UpdateUserAsync(user.Id, user))
                {
                    RedisCache.Set(user.Email, user.ToJson());
                    if (!loginPath) return userToken;

                    _ = EmailService.SendEmail(path, user.Email, "Email Verification Code for Your Account 🙂🙂", 0,
                        user);
                    return userToken;
                }

                return null;
            }
        }

        return userToken;
    }

    private static async Task<dynamic> ExtractCustomClaim(string jwtToken, bool allowBoolean)
    {
        var tokenHandler = new JwtSecurityTokenHandler();
        var token = tokenHandler.ReadJwtToken(jwtToken);
        var claims = token.Claims;

        var email = claims.FirstOrDefault(c => c.Type == "email")?.Value;
        var password = claims.FirstOrDefault(c => c.Type == "password")?.Value;

        User user;
        var cache = RedisCache.Get(email);
        try
        {
            user = JsonConvert.DeserializeObject<User>(cache);
        }catch (Exception ex)
        {
            user = null;
        }

        if (user != null)
        {
            var fromDb = await userService.GetUserByEmailAsync(email);
            if (!user.Equals(fromDb))
            {
                user = fromDb;
                RedisCache.Set(user.Email, user.ToJson());
            }

            if (user == null) return null;

            if (user.Password == password && !user.UserAuthTokens.Contains(jwtToken)) return null;

            if (user.Password == password)
            {
                if (allowBoolean)
                    return true;
                return user;
            }
            return false;
        }


        user = await userService.GetUserByEmailAsync(email);
        if (user == null) return null;
        RedisCache.Set(user.Email, user.ToJson());
        if (user.Password == password && !user.UserAuthTokens.Contains(jwtToken)) return null;
        if (user.Password == password)
        {
            if (allowBoolean)
                return true;
            return user;
        }
        return null;
    }

    public static async Task<string> tokenCreator(bool loginPath, string path, string? email, string password,
        User user)
    {
        if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password)) return null;
        var expiryMinutes = 10000;
        return await GenerateJwtToken(loginPath, path, secretKey, issuer, audience, expiryMinutes, email, password,
            user);
    }

    public static async Task<dynamic> ValidateJwtToken(string token, bool allowBoolean = false)
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