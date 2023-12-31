﻿using System.Net;
using System.Text.RegularExpressions;
using Bixby_web_server.Models;
using BixbyShop_LK.Services;
using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using MongoDB.Bson;
using MongoDB.Driver;
using SendGrid;
using BCryptNet = BCrypt.Net.BCrypt;

namespace Bixby_web_server.Services;

public class EmailServiceHelper
{
    public static async Task<bool> ValidateEmailUsing_Zerobounce(string email)
    {
        var apiKey = "Y54EU1YFR+lhBHiNSVJITj05oG5LiSvCNpTOd10NiSbiSBEMNc7MzPds/mh216IAdz2jPEBbALGBV2QY4isjwA==";
        apiKey = EncryptionHelper.Decrypt(apiKey);
        var apiUrl = $"https://api.zerobounce.net/v2/validate?api_key={apiKey}&email={email}";

        using (var httpClient = new HttpClient())
        {
            var response = await httpClient.GetAsync(apiUrl);
            if (response.IsSuccessStatusCode)
            {
                var jsonResponse = await response.Content.ReadAsStringAsync();

                // Parse the JSON response to check the email validity status
                // You may need to adjust this code based on the ZeroBounce API response structure
                var isValid = jsonResponse.Contains("\"status\":\"valid\"");
                return isValid;
            }
        }

        return false; // Error occurred or API request failed
    }

    public static bool ValidateEmailPattern(string email)
    {
        var pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
        var regex = new Regex(pattern);
        var match = regex.Match(email);
        return match.Success;
    }

    public static async Task<bool> ValidateEmail(string email)
    {
        try
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("Sender",
                EncryptionHelper.Decrypt("t2rtBrY8JzecZNhvbApQW/q8+ANhkWK+eOTwhDdma2n6N43+8rKtCEV3eHtphgpj")));
            message.To.Add(new MailboxAddress("Recipient", email));
            message.Subject = "Email Address Verification";
            message.Body = new TextPart("plain")
            {
                Text = "This is just a verification email."
            };

            using (var client = new SmtpClient())
            {
                client.Connect("smtp.sendgrid.net", 587, SecureSocketOptions.StartTls);

                // Note: Provide your SendGrid API key as the first parameter and an empty string as the second parameter.
                client.Authenticate("your-sendgrid-api-key", "");

                await client.SendAsync(message);
                await client.DisconnectAsync(true);
            }

            return true;
        }
        catch (Exception ex)
        {
            return false;
        }
    }

    public void SendEmail(Response response)
    {
        if (response.StatusCode == HttpStatusCode.Accepted)
        {
        }
    }
}

public class UserService
{
    private readonly IMongoCollection<User?> userCollection;

    public UserService()
    {
        var settings = MongoClientSettings.FromUrl(new MongoUrl(
            "mongodb+srv://geethaliyanage23:1dJz8r5mX6nfkoG6@cluster0.xdb3qmc.mongodb.net/?retryWrites=true&w=majority"));
        var client = new MongoClient(settings);

        var database = client.GetDatabase("BixByApp");
        userCollection = database.GetCollection<User>("Users");
    }

    public async Task<List<User?>> GetAllUsersAsync()
    {
        return await userCollection.Find(_ => true).ToListAsync();
    }

    public static dynamic GetUserBasedOnToken(string token, bool allowBoolean)
    {
        if (!string.IsNullOrEmpty(token))
            return TokenService.ValidateJwtToken(token, allowBoolean);
        return null;
    }

    public async Task<string?> CreateNewAccountAsync(User? newUser, string path)
    {
        if (newUser != null)
        {
            if (GetUserByEmailAsync(newUser.Email) == null)
            {
                newUser.Password = BCryptNet.HashPassword(newUser.Password);
                newUser.Tokens = new Dictionary<string?, VerficationCode>();
                newUser.UserAuthTokens = new List<string>();
                await CreateUserAsync(newUser);

                var createdUser = await GetUserByEmailAsync(newUser.Email);
                if (createdUser == null) return null;
                return await TokenService.TokenCreator(true, path,
                    createdUser.Email == null ? newUser.Email : createdUser.Email,
                    createdUser.Password == null ? newUser.Password : createdUser.Password, createdUser);
                ;
            }

            return null;
        }

        return null;
    }

    public async Task<string?> CreateNewAccountAsync(string? username, string password, string FirstName,
        string LastName, string Address, string path)
    {
        if (await GetUserByEmailAsync(username) == null)
        {
            /* if (!EmailServiceHelper.ValidateEmailUsing_Zerobounce(username))
            {
                return null;
            }*/
            var newUser = new User();
            newUser.FirstName = FirstName;
            newUser.LastName = LastName;
            newUser.Address = Address;
            newUser.Email = username;
            newUser.Password = BCryptNet.HashPassword(password);
            newUser.Tokens = new Dictionary<string?, VerficationCode>();
            newUser.UserAuthTokens = new List<string>();
            await CreateUserAsync(newUser);

            var createdUser = await GetUserByEmailAsync(username);
            if (createdUser == null) return null;
            return await TokenService.TokenCreator(true, path, createdUser.Email == null ? username : createdUser.Email,
                createdUser.Password == null ? newUser.Password : createdUser.Password, createdUser);
            ;
        }

        return null;
    }

    public async Task<string?> LoginAsync(string? username, string password, string path)
    {
        var user = await GetUserByEmailAsync(username);
        if (user != null && BCryptNet.Verify(password, user.Password) && user.EmailVerify)
            return await TokenService.TokenCreator(false, path, user.Email == null ? username : user.Email,
                user.Password, user);

        return null;
    }

    public async Task<User?> GetUserByEmailAsync(string? email)
    {
        FilterDefinition<User?> filter = Builders<User>.Filter.Eq("Email", email);
        return await userCollection.Find(filter).FirstOrDefaultAsync();
    }

    public async Task<User> GetUserByAuthTokenAsync(string authToken)
    {
        FilterDefinition<User?> filter = Builders<User>.Filter.Eq("UserAuthTokens", authToken);
        var user = await userCollection.Find(filter).FirstOrDefaultAsync();
        return user;
    }

    public async Task<User> GetUserByIdAsync(ObjectId userId)
    {
        return await userCollection.Find(user => user.Id == userId).FirstOrDefaultAsync();
    }

    public async Task CreateUserAsync(User? user)
    {
        await userCollection.InsertOneAsync(user);
    }

    public async Task<bool> UpdateUserAsync(ObjectId userId, User? updatedUser)
    {
        var result = await userCollection.ReplaceOneAsync(user => user.Id == userId, updatedUser);
        return result.IsAcknowledged;
    }

    public async Task DeleteUserAsync(ObjectId userId)
    {
        await userCollection.DeleteOneAsync(user => user.Id == userId);
    }
}