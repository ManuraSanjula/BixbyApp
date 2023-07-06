using System.Text.RegularExpressions;
using Azure;
using Azure.Communication.Email;
using Bixby_web_server;
using Bixby_web_server.Controllers;
using Bixby_web_server.Models;
using Microsoft.IdentityModel.Tokens;
using MongoDB.Bson;
using Newtonsoft.Json;

namespace BixbyShop_LK.Services;

public static class EmailService
{
    private static readonly UserService userService = new();

    private static readonly string _apiKey =
        "wN7MBHWLUx+HjnrERSAvVXkZZiUIP2S3T7baXEbONqUHpt3E0TpmtO4KB13HtwtagJ/JjI3Njf9Cd3KbObWYtkTeufvRzNdxZPqB9rDuJs7rUWXBjFw3LDtvb5LCSXXQ";

    private static readonly string fromEmail = "t2rtBrY8JzecZNhvbApQW/q8+ANhkWK+eOTwhDdma2n6N43+8rKtCEV3eHtphgpj";

    private static readonly EmailClient emailClient =
        new(
            "endpoint=https://email-app.communication.azure.com/;accesskey=X1NP+YmFK423TOrU/2EL0uGUQMLM03IO91bidY1u66NQbUOLPvPGMkW34TgJmlNI5M3bGW13cO4i6lQCGY5lLg==");

    private static string FormatHtml(string input, Func<string, string?> valueProvider)
    {
        var formattedHtml = Regex.Replace(input, @"\{([^{}]+)\}", match =>
        {
            var placeholder = match.Groups[1].Value;
            return valueProvider(placeholder);
        }, RegexOptions.IgnoreCase);

        return formattedHtml;
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

        // MapService.AddOrUpdateMapValue(email, verificationCode);
        return verificationCode;
    }

    private static async void userUpdate(string? email, string? token)
    {
        User? user;
        var userCache = RedisCache.Get(email);
        if (userCache.IsNullOrEmpty())
        {
            user = await userService.GetUserByEmailAsync(email);
            RedisCache.Set(user.Email, user.ToJson());
        }
        else
        {
            try
            {
                user = JsonConvert.DeserializeObject<User>(userCache);
            }
            catch (Exception)
            {
                user = await userService.GetUserByEmailAsync(email);
            }

            var user_db = await userService.GetUserByEmailAsync(email);
            if (!user.Equals(user_db))
            {
                user = user_db;
                RedisCache.Set(user.Email, user.ToJson());
            }

            RedisCache.Set(user.Email, user.ToJson());
        }

        if (user != null)
        {
            user.AddToken(token, DateTime.Now.ToString());
            await userService.UpdateUserAsync(user.Id, user);
            RedisCache.Set(user.Email, user.ToJson());
        }
    }

    private static string emailVerificationCode(string code, string path, string? email)
    {
        var text = RedisCache.Get("emailVerificationCode");
        if (text == null)
        {
            text = Startup.GetFileContent(Startup.ConfirmYourEmail);
            RedisCache.Set("emailVerificationCode", text);
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

    private static async Task<string> forgotPasswordEmailVerification(string code, string path, string? email,
        User user)
    {
        var text = RedisCache.Get("forgotPasswordEmailVerification");
        if (text == null)
        {
            text = Startup.GetFileContent(Startup.ResetPasswordReqEmail);
            RedisCache.Set("forgotPasswordEmailVerification", text);
        }

        return FormatHtml(text, placeholder =>
        {
            if (placeholder == "VerificationLink")
            {
                var tken = path + $"/reset-password/{user.Email}/{code}";
                var link = path +
                           $"/ui/reset-password/?token={Bixby_web_server.Helpers.EncryptionHelper.Encrypt(tken, 3)}";
                return link;
            }

            return string.Empty;
        });
    }

    private static string successfullyResetThePassword(string? email)
    {
        var text =
            "<!-- \r\nOnline HTML, CSS and JavaScript editor to run code online.\r\n-->\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n<head>\r\n  <meta charset=\"UTF-8\" />\r\n  <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\" />\r\n  <link rel=\"stylesheet\" href=\"style.css\" />\r\n  <title>Browser</title>\r\n</head>\r\n\r\n<body>\r\n  <h1>\r\n     \tYour password has been successfully reset..\r\n  </h1>\r\n</body>\r\n\r\n</html>";

        return text;
    }

    public static async Task SendEmail(string path, string? toEmail, string subject, int i, User user)
    {
        var code = GenerateVerificationCode(20, toEmail);
        var htmlContent = "";
        var sender = "donotreply@022abdd1-f446-43c9-ad7e-1331fdb3a116.azurecomm.net";
        if (i == 0)
            htmlContent = emailVerificationCode(code, path, toEmail);
        else if (i == 1)
            htmlContent = await forgotPasswordEmailVerification(code, path, toEmail, user);
        else
            htmlContent = successfullyResetThePassword(toEmail);

        if (htmlContent.IsNullOrEmpty())
            return;

        try
        {
            Console.WriteLine("Sending email...");
            var emailSendOperation = await emailClient.SendAsync(
                WaitUntil.Completed,
                sender,
                toEmail,
                subject,
                htmlContent);
            var statusMonitor = emailSendOperation.Value;

            Console.WriteLine($"Email Sent. Status = {emailSendOperation.Value.Status}");

            /// Get the OperationId so that it can be used for tracking the message for troubleshooting
            var operationId = emailSendOperation.Id;
            Console.WriteLine($"Email operation id = {operationId}");
            userUpdate(toEmail, code);
        }
        catch (RequestFailedException ex)
        {
            /// OperationID is contained in the exception message and can be used for troubleshooting purposes
            Console.WriteLine($"Email send operation failed with error code: {ex.ErrorCode}, message: {ex.Message}");
        }
    }
}