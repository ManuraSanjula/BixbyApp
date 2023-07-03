using SendGrid.Helpers.Mail;
using SendGrid;
using System;
using System.Text.RegularExpressions;
using Bixby_web_server.Models;

namespace BixbyShop_LK.Services
{
    // Interface
    public interface IEmailService
    {
        void SendEmail(Response response);
    }

    public static class EmailService
    {
        private static readonly UserService userService = new UserService();
        private static readonly string _apiKey = "wN7MBHWLUx+HjnrERSAvVXkZZiUIP2S3T7baXEbONqUHpt3E0TpmtO4KB13HtwtagJ/JjI3Njf9Cd3KbObWYtkTeufvRzNdxZPqB9rDuJs7rUWXBjFw3LDtvb5LCSXXQ";
        private static readonly string fromEmail = "t2rtBrY8JzecZNhvbApQW/q8+ANhkWK+eOTwhDdma2n6N43+8rKtCEV3eHtphgpj";
        public static IEmailService _emailServiceHelper { get; set; }

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

        private static string emailVerificationCode(string? email)
        {
            string text = "<!-- \r\nOnline HTML, CSS and JavaScript editor to run code online.\r\n-->\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n<head>\r\n  <meta charset=\"UTF-8\" />\r\n  <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\" />\r\n  <link rel=\"stylesheet\" href=\"style.css\" />\r\n  <title>Browser</title>\r\n</head>\r\n\r\n<body>\r\n  <p style=\"text-align:center\"><span style=\"color:#ffffff\"><span style=\"font-family:Comic Sans MS,cursive\"><span style=\"font-size:72px\"><u><strong><span style=\"background-color:#2ecc71\">Welcome to BixbyShop</span></strong></u></span></span></span></p>\r\n\r\n<blockquote>\r\n<p style=\"text-align:center\"><span style=\"font-size:48px\"><span style=\"font-family:Comic Sans MS,cursive\">Your Code is : {VerificationCode}</span></span></p>\r\n\r\n<p style=\"text-align:center\"><span style=\"font-size:48px\"><span style=\"font-family:Comic Sans MS,cursive\">Please Enter our Application</span></span></p>\r\n</blockquote>\r\n\r\n</body>\r\n\r\n</html>";

            return FormatHtml(text, placeholder =>
            {
                if (placeholder == "VerificationCode")
                {
                    string? code = GenerateVerificationCode(20, email);
                    userUpdate(email, code);
                    return code;
                }
                else
                {
                    return string.Empty;
                }
            });
        }

        private static string forgotPasswordEmailVerification(string? email)
        {
            string text = "<!-- \r\nOnline HTML, CSS and JavaScript editor to run code online.\r\n-->\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n<head>\r\n  <meta charset=\"UTF-8\" />\r\n  <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\" />\r\n  <link rel=\"stylesheet\" href=\"style.css\" />\r\n  <title>Browser</title>\r\n</head>\r\n\r\n<body>\r\n  <p style=\"text-align:center\"><strong><u><span style=\"color:#c0392b\"><span style=\"font-family:Lucida Sans Unicode,Lucida Grande,sans-serif\"><span style=\"font-size:72px\"><span style=\"background-color:#bdc3c7\">We got you Sir/Madam 😊😊</span></span></span></span></u></strong></p>\r\n\r\n<blockquote>\r\n<p style=\"text-align:center\"><span style=\"font-size:48px\"><span style=\"color:#c0392b\"><span style=\"font-family:Lucida Sans Unicode,Lucida Grande,sans-serif\">If you forgot your password that&#39;s okay here is the code {VerificationCode} to reset your password.</span></span></span></p>\r\n\r\n<p style=\"text-align:center\"><span style=\"font-size:48px\"><span style=\"color:#c0392b\"><span style=\"font-family:Lucida Sans Unicode,Lucida Grande,sans-serif\">Please enter the code in our app&nbsp;</span></span></span></p>\r\n</blockquote>\r\n</body>\r\n\r\n</html>";

            return FormatHtml(text, placeholder =>
            {
                if (placeholder == "VerificationCode")
                {
                    string? code = GenerateVerificationCode(20, email);
                    userUpdate(email, code);
                    return code;
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

        public static async Task SendEmail(string? toEmail, string subject, int i)
        {
            var client = new SendGridClient(EncryptionHelper.Decrypt(_apiKey));
            var from = new EmailAddress(EncryptionHelper.Decrypt(fromEmail));
            var to = new EmailAddress(toEmail);
            SendGridMessage message = null;
            if (i == 0)
            {
                message = MailHelper.CreateSingleEmail(from, to, subject, emailVerificationCode(toEmail), emailVerificationCode(toEmail));
            }
            if (i == 1)
            {
                message = MailHelper.CreateSingleEmail(from, to, subject, forgotPasswordEmailVerification(toEmail), forgotPasswordEmailVerification(toEmail));
            }
            if (i == 2)
            {
                message = MailHelper.CreateSingleEmail(from, to, subject, successfullyResetThePassword(toEmail), successfullyResetThePassword(toEmail));
            }
            var response = await client.SendEmailAsync(message);

            if (response.StatusCode == System.Net.HttpStatusCode.Accepted)
            {
                _emailServiceHelper.SendEmail(response);
            }
            else
            {
                // Handle the error case here
            }
        }
    }
}
