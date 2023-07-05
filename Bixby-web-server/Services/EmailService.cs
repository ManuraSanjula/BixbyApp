using SendGrid.Helpers.Mail;
using SendGrid;
using System;
using System.Text.RegularExpressions;
using Bixby_web_server.Models;
using Bixby_web_server.Controllers;
using Azure.Communication.Email;
using Azure;
using Org.BouncyCastle.Cms;
using SendGrid.Helpers.Mail.Model;
using Microsoft.IdentityModel.Tokens;

namespace BixbyShop_LK.Services
{
    public static class EmailService
    {
        private static readonly UserService userService = new UserService();
        private static readonly string _apiKey = "wN7MBHWLUx+HjnrERSAvVXkZZiUIP2S3T7baXEbONqUHpt3E0TpmtO4KB13HtwtagJ/JjI3Njf9Cd3KbObWYtkTeufvRzNdxZPqB9rDuJs7rUWXBjFw3LDtvb5LCSXXQ";
        private static readonly string fromEmail = "t2rtBrY8JzecZNhvbApQW/q8+ANhkWK+eOTwhDdma2n6N43+8rKtCEV3eHtphgpj";

        private static readonly EmailClient emailClient = new EmailClient("endpoint=https://email-app.communication.azure.com/;accesskey=X1NP+YmFK423TOrU/2EL0uGUQMLM03IO91bidY1u66NQbUOLPvPGMkW34TgJmlNI5M3bGW13cO4i6lQCGY5lLg==");
        private static string FormatHtml(string input, Func<string, string?> valueProvider)
        {
            string formattedHtml = Regex.Replace(input, @"\{([^{}]+)\}", match =>
            {
                string placeholder = match.Groups[1].Value;
                return valueProvider(placeholder);
            }, RegexOptions.IgnoreCase);

            return formattedHtml;
        }

        private static string? GenerateVerificationCode(int length, string? email)
        {
            length = length != null ? length : 6;

            var random = new Random();
            var verificationCode = string.Empty;

            for (int i = 0; i < length; i++)
            {
                int digit = random.Next(0, 10);
                verificationCode += digit.ToString();
            }
            // MapService.AddOrUpdateMapValue(email, verificationCode);
            return verificationCode;
        }

        private async static void userUpdate(string? email, string? token)
        {
            User? user = await userService.GetUserByEmailAsync(email);
            if (user != null)
            {
                user.AddToken(token, DateTime.Now.ToString());
                await userService.UpdateUserAsync(user.Id, user);
            }
        }

        private static string emailVerificationCode(string code,string path,string? email)
        {
            string text = Startup.GetFileContent(Startup.ConfirmYourEmail);
            return FormatHtml(text, placeholder =>
            {
                if (placeholder == "VerificationLink")
                {
                    String link = path + $"/ui/email-verify/?token={path + $"/email-verify/{email}/{code}"}";
                    return link;
                }
                else
                {
                    return string.Empty;
                }
            });
        }

        private async static Task<string> forgotPasswordEmailVerification(string code, string path,string? email, User user)
        {

            string text = Startup.GetFileContent(Startup.ResetPasswordReqEmail);

            return FormatHtml(text, placeholder =>
            {
                if (placeholder == "VerificationLink")
                {
                    string tken = path + $"/reset-password/{user.Email}/{code}";
                    String link = path + $"/ui/reset-password/?token={Bixby_web_server.Helpers.EncryptionHelper.Encrypt(tken, 3)}";
                    return link;
                }
                else
                {
                    return string.Empty;
                }
            });
        }

        private static string successfullyResetThePassword(string? email)
        {
            string text = "<!-- \r\nOnline HTML, CSS and JavaScript editor to run code online.\r\n-->\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n<head>\r\n  <meta charset=\"UTF-8\" />\r\n  <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\" />\r\n  <link rel=\"stylesheet\" href=\"style.css\" />\r\n  <title>Browser</title>\r\n</head>\r\n\r\n<body>\r\n  <h1>\r\n     \tYour password has been successfully reset..\r\n  </h1>\r\n</body>\r\n\r\n</html>";

            return text;
        }

        public static async Task SendEmail(string path,string? toEmail, string subject, int i, User user)
        {

            string? code = GenerateVerificationCode(20, toEmail);
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
                EmailSendOperation emailSendOperation = await emailClient.SendAsync(
                    Azure.WaitUntil.Completed,
                    sender,
                    toEmail,
                    subject,
                    htmlContent);
                EmailSendResult statusMonitor = emailSendOperation.Value;

                Console.WriteLine($"Email Sent. Status = {emailSendOperation.Value.Status}");

                /// Get the OperationId so that it can be used for tracking the message for troubleshooting
                string operationId = emailSendOperation.Id;
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
}
