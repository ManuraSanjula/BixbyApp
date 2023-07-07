using System.Globalization;
using System.Text.RegularExpressions;
using Azure;
using Azure.Communication.Email;
using Bixby_web_server.Controllers;
using Bixby_web_server.Models;
using BixbyShop_LK.Services;
using Microsoft.IdentityModel.Tokens;
using MongoDB.Bson;
using Newtonsoft.Json;

namespace Bixby_web_server.Services;

public static class EmailService
{
    private static readonly UserService UserService = new();

    public static string ApiKey { get; } =
        "wN7MBHWLUx+HjnrERSAvVXkZZiUIP2S3T7baXEbONqUHpt3E0TpmtO4KB13HtwtagJ/JjI3Njf9Cd3KbObWYtkTeufvRzNdxZPqB9rDuJs7rUWXBjFw3LDtvb5LCSXXQ";

    public static string FromEmail { get; } = "t2rtBrY8JzecZNhvbApQW/q8+ANhkWK+eOTwhDdma2n6N43+8rKtCEV3eHtphgpj";

    private static EmailClient Client { get; } = new(
        "endpoint=https://email-app.communication.azure.com/;accesskey=X1NP+YmFK423TOrU/2EL0uGUQMLM03IO91bidY1u66NQbUOLPvPGMkW34TgJmlNI5M3bGW13cO4i6lQCGY5lLg==");

    private static string? FormatHtml(string? input, Func<string, string?> valueProvider)
    {
        if (input != null)
        {
            var formattedHtml = Regex.Replace(input, @"\{([^{}]+)\}", match =>
            {
                var placeholder = match.Groups[1].Value;
                return valueProvider(placeholder) ?? string.Empty;
            }, RegexOptions.IgnoreCase);

            return formattedHtml;
        }

        return null;
    }

    private static string? GenerateVerificationCode(int length, string? email)
    {
        length = length != null ? length : 6;

        var random = new Random();
        var verificationCode = string.Empty;

        for (var i = 0; i < length; i++)
        {
            var digit = random.Next(0, 10);
            verificationCode += digit.ToString();
        }
        return verificationCode;
    }

    private static async void UserUpdate(string? email, string? token)
    {
        User? user = null;
        string? userCache = null;
        try
        {
            if (email != null) userCache = RedisCache.Get(email);
        }
        catch (Exception)
        {
            // ignored
        }

        if (userCache.IsNullOrEmpty())
        {
            user = await UserService.GetUserByEmailAsync(email);
            try
            {
                if (user != null)
                    if (user.Email != null)
                        RedisCache.Set(user.Email, user.ToJson());
            }
            catch (Exception)
            {
                // ignored
            }
        }
        else
        {
            try
            {
                if (userCache != null) user = JsonConvert.DeserializeObject<User>(userCache);
            }
            catch (Exception)
            {
                user = await UserService.GetUserByEmailAsync(email);
            }

            var userDb = await UserService.GetUserByEmailAsync(email);
            if (userDb == null) return ;
            if (user != null && !user.Equals(userDb))
            {
                user = userDb;
                try
                {
                    if (user.Email != null) RedisCache.Set(user.Email, user.ToJson());
                }
                catch (Exception)
                {
                    // ignored
                }
            }

            try
            {
                if (user?.Email != null) RedisCache.Set(user.Email, user.ToJson());
            }
            catch (Exception)
            {
                // ignored
            }
        }

        if (user != null)
        {
            user.AddToken(token, DateTime.Now.ToString(CultureInfo.InvariantCulture));
            await UserService.UpdateUserAsync(user.Id, user);
            try
            {
                if (user.Email != null) RedisCache.Set(user.Email, user.ToJson());
            }
            catch (Exception)
            {
                // ignored
            }
        }
    }

    private static string? EmailVerificationCode(string code, string path, string? email)
    {
        string? text = null;
        try
        {
             text = RedisCache.Get("emailVerificationCode");
        }
        catch (Exception)
        {
            // ignored
        }

        if (text != null)
            return FormatHtml(text, placeholder =>
            {
                if (placeholder != "VerificationLink") return string.Empty;
                var link = path + $"/ui/email-verify/?token={path + $"/email-verify/{email}/{code}"}";
                return link;

            });
        text = Startup.GetFileContent(Startup.ConfirmYourEmail);
        try
        {
            RedisCache.Set("emailVerificationCode", text);
        }
        catch (Exception)
        {
            // ignored
        }

        return FormatHtml(text, placeholder =>
        {
            if (placeholder == "VerificationLink")
            {
                var link = path + $"/ui/email-verify/?token={path + $"/email-verify/{email}/{code}"}";
                return link;
            }
            
            return string.Empty;
        });
    }

    private static Task<string?> ForgotPasswordEmailVerification(string code, string path,
        User user)
    {
        string? text = null;
        try
        {
            text = RedisCache.Get("forgotPasswordEmailVerification");
        }
        catch (Exception)
        {
            // ignored
        }

        if (text == null)
        {
            text = Startup.GetFileContent(Startup.ResetPasswordReqEmail);
            try
            {
                RedisCache.Set("forgotPasswordEmailVerification", text);
            }
            catch (Exception)
            {
                // ignored
            }
        }

        return Task.FromResult(FormatHtml(text, placeholder =>
        {
            if (placeholder != "VerificationLink") return string.Empty;
            var token = path + $"/reset-password/{user.Email}/{code}";
            var link = path +
                       $"/ui/reset-password/?token={Helpers.EncryptionHelper.Encrypt(token, 3)}";
            return link;

        }));
    }

    private static string? SuccessfullyResetThePassword()
    {
        const string? text = "<!-- \r\nOnline HTML, CSS and JavaScript editor to run code online.\r\n-->\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n<head>\r\n  <meta charset=\"UTF-8\" />\r\n  <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\" />\r\n  <link rel=\"stylesheet\" href=\"style.css\" />\r\n  <title>Browser</title>\r\n</head>\r\n\r\n<body>\r\n  <h1>\r\n     \tYour password has been successfully reset..\r\n  </h1>\r\n</body>\r\n\r\n</html>";

        return text;
    }

    public static async Task SendEmail(string path, string? toEmail, string subject, int i, User user)
    {
        var code = GenerateVerificationCode(20, toEmail);
        var htmlContent = "";
        var sender = "donotreply@022abdd1-f446-43c9-ad7e-1331fdb3a116.azurecomm.net";
        if (i == 0)
        {
            if (code != null) htmlContent = EmailVerificationCode(code, path, toEmail);
        }
        else if (i == 1)
        {
            if (code != null) htmlContent = await ForgotPasswordEmailVerification(code, path, user);
        }
        else
            htmlContent = SuccessfullyResetThePassword();

        if (htmlContent.IsNullOrEmpty())
            return;

        try
        {
            Console.WriteLine("Sending email...");
            var emailSendOperation = await Client.SendAsync(
                WaitUntil.Completed,
                sender,
                toEmail,
                subject,
                htmlContent);
            Console.WriteLine($"Email Sent. Status = {emailSendOperation.Value.Status}");

            var operationId = emailSendOperation.Id;
            Console.WriteLine($"Email operation id = {operationId}");
            UserUpdate(toEmail, code);
        }
        catch (RequestFailedException ex)
        {
            Console.WriteLine($"Email send operation failed with error code: {ex.ErrorCode}, message: {ex.Message}");
        }
    }
}