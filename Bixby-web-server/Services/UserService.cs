using BCryptNet = BCrypt.Net.BCrypt;
using MongoDB.Bson;
using MongoDB.Driver;
using SendGrid;
using MimeKit;
using System.Text.RegularExpressions;
using MailKit.Security;

namespace BixbyShop_LK.Services
{
    public class EmailServiceHelper : IEmailService
    {
        public static bool ValidateEmailUsing_Zerobounce(string email)
        {
            string apiKey = "Y54EU1YFR+lhBHiNSVJITj05oG5LiSvCNpTOd10NiSbiSBEMNc7MzPds/mh216IAdz2jPEBbALGBV2QY4isjwA==";
            apiKey = EncryptionHelper.Decrypt(apiKey);
            string apiUrl = $"https://api.zerobounce.net/v2/validate?api_key={apiKey}&email={email}";

            using (var httpClient = new HttpClient())
            {
                var response = httpClient.GetAsync(apiUrl).GetAwaiter().GetResult();
                if (response.IsSuccessStatusCode)
                {
                    var jsonResponse = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();

                    // Parse the JSON response to check the email validity status
                    // You may need to adjust this code based on the ZeroBounce API response structure
                    bool isValid = jsonResponse.Contains("\"status\":\"valid\"");
                    return isValid;
                }
            }

            return false; // Error occurred or API request failed
        }
        public static bool ValidateEmailPattern(string email)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            Regex regex = new Regex(pattern);
            Match match = regex.Match(email);
            return match.Success;
        }
        public static bool ValidateEmail(string email)
        {
            try
            {
                var message = new MimeMessage();
                message.From.Add(new MailboxAddress("Sender", EncryptionHelper.Decrypt("t2rtBrY8JzecZNhvbApQW/q8+ANhkWK+eOTwhDdma2n6N43+8rKtCEV3eHtphgpj")));
                message.To.Add(new MailboxAddress("Recipient", email));
                message.Subject = "Email Address Verification";
                message.Body = new TextPart("plain")
                {
                    Text = "This is a just verification email."
                };

                using (var client = new MailKit.Net.Smtp.SmtpClient())
                {
                    client.Connect("smtp.sendgrid.net", 587, SecureSocketOptions.StartTls);

                    // Note: Provide your SendGrid API key as the first parameter and an empty string as the second parameter.
                    client.Authenticate("your-sendgrid-api-key", "");

                    client.Send(message);
                    client.Disconnect(true); ;
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
            if (response.StatusCode == System.Net.HttpStatusCode.Accepted)
            {
            }
            else
            {
                
            }
        }
    }
    public class UserService
    {
        private readonly IMongoCollection<User?> userCollection;

        public UserService()
        {
            var settings = MongoClientSettings.FromUrl(new MongoUrl("mongodb+srv://geethaliyanage23:1dJz8r5mX6nfkoG6@cluster0.xdb3qmc.mongodb.net/?retryWrites=true&w=majority"));
            var client = new MongoClient(settings);
        
            IMongoDatabase database = client.GetDatabase("BixByApp");
            this.userCollection = database.GetCollection<User>("Users");
        }

        public List<User?> GetAllUsers()
        {
            return userCollection.Find(_ => true).ToList();
        }

        public delegate void UserDelegate(string token);

        public static dynamic? GetUserBasedOnToken(string token, bool allowBoolean, UserDelegate userDelegate)
        {
            if (!string.IsNullOrEmpty(token))
                return TokenService.ValidateJwtToken(token, allowBoolean, new TokenService.UserDelegate(userDelegate));
            else
                return null;
        }

        private String UserNewAccountDelegate(string token, User? user)
        {
            if (!string.IsNullOrEmpty(token))
            {
                if(user != null)
                {
                    if (user.UserAuthTokens == null || user.UserAuthTokens.Count == 0)
                    {
                        user.UserAuthTokens = new List<String>();
                        user.UserAuthTokens.Add(token);
                        if(UpdateUser(user.Id, user))
                        {
                            IEmailService emailService = new EmailServiceHelper();
                            EmailService._emailServiceHelper = emailService;
                            EmailService.SendEmail(user.Email, "Email Verification Code for Your Account 🙂🙂", 0);
                            return token;
                        }
                    }
                    else
                    {
                        user.UserAuthTokens.Add(token);
                        if (UpdateUser(user.Id, user))
                        {
                            IEmailService emailService = new EmailServiceHelper();
                            EmailService._emailServiceHelper = emailService;
                            EmailService.SendEmail(user.Email, "Email Verification Code for Your Account 🙂🙂", 0);
                            return token;
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
            return null;
        }
        
        public string? CreateNewAccount(User? newUser)
        {           
            if(newUser != null)
            {
                if(GetUserByEmail(newUser.Email) == null)
                {
                    newUser.Password = BCryptNet.HashPassword(newUser.Password);
                    newUser.Tokens = new Dictionary<string, VerficationCode>();
                    newUser.UserAuthTokens = new List<String>();
                    CreateUser(newUser);

                    User? createdUser = GetUserByEmail(newUser.Email);
                    if (createdUser == null)
                    {
                        return null;
                    }
                    return TokenService.tokenCreator(createdUser.Email == null ? newUser.Email : createdUser.Email, createdUser.Password == null ? newUser.Password : createdUser.Password, UserNewAccountDelegate, createdUser); ;
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
         }
        
        public string? CreateNewAccount(string username, string password, string FirstName, string LastName, String Address)
        {
           if(GetUserByEmail(username) == null)
            {
                if (!EmailServiceHelper.ValidateEmailUsing_Zerobounce(username))
                {
                    return null;
                }
                User? newUser = new User();
                newUser.FirstName = FirstName;
                newUser.LastName = LastName;
                newUser.Address = Address;
                newUser.Email = username;
                newUser.Password = BCryptNet.HashPassword(password);
                newUser.Tokens = new Dictionary<string, VerficationCode>();
                newUser.UserAuthTokens = new List<String>();
                CreateUser(newUser);

                User? createdUser = GetUserByEmail(username);
                if (createdUser == null)
                {
                    return null;
                }
                return TokenService.tokenCreator(createdUser.Email == null ? username : createdUser.Email, createdUser.Password == null ? newUser.Password : createdUser.Password, UserNewAccountDelegate, createdUser); ;
            }
            else
            {
                return null;
            }
        }

        public string? Login(string username, string password)
        {
            User? user = GetUserByEmail(username);
            if (user != null && BCryptNet.Verify(password, user.Password))
            {
                return TokenService.tokenCreator(user.Email == null ? username : user.Email, user.Password, UserNewAccountDelegate, user);
            }

            return null;
        }

        public User? GetUserByEmail(string email)
        {
            FilterDefinition<User?> filter = Builders<User>.Filter.Eq("Email", email);
            return userCollection.Find(filter).FirstOrDefault();
        }

        public User GetUserByAuthToken(string authToken)
        {
            FilterDefinition<User?> filter = Builders<User>.Filter.Eq("UserAuthTokens", authToken);
            var user = userCollection.Find(filter).FirstOrDefault();
            return user;
        }

        public User GetUserById(ObjectId userId)
        {
            return userCollection.Find(user => user.Id == userId).FirstOrDefault();
        }

        public void CreateUser(User? user)
        {
            userCollection.InsertOne(user);
        }

        public bool UpdateUser(ObjectId userId, User? updatedUser)
        {
            return userCollection.ReplaceOne(user => user.Id == userId, updatedUser).IsAcknowledged;
        }

        public void DeleteUser(ObjectId userId)
        {
            userCollection.DeleteOne(user => user.Id == userId);
        }
    }
}
