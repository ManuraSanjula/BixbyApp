using BCryptNet = BCrypt.Net.BCrypt;
using MongoDB.Bson;
using MongoDB.Driver;

namespace BixbyShop_LK.Services
{
    public class UserService
    {
        private readonly IMongoCollection<User> userCollection;

        public UserService()
        {
            var settings = MongoClientSettings.FromUrl(new MongoUrl("mongodb+srv://geethaliyanage23:1dJz8r5mX6nfkoG6@cluster0.xdb3qmc.mongodb.net/?retryWrites=true&w=majority"));
            var client = new MongoClient(settings);
        
            IMongoDatabase database = client.GetDatabase("BixByApp");
            this.userCollection = database.GetCollection<User>("Users");
        }

        public List<User> GetAllUsers()
        {
            return userCollection.Find(_ => true).ToList();
        }

        public delegate void UserDelegate(string token);

        public static dynamic GetUserBasedOnToken(string token, bool allowBoolean, UserDelegate userDelegate)
        {
            if (!string.IsNullOrEmpty(token))
                return TokenService.ValidateJwtToken(token, allowBoolean, new TokenService.UserDelegate(userDelegate));
            else
                return null;
        }

        private String UserNewAccountDelegate(string token, User user)
        {
            if (!string.IsNullOrEmpty(token))
            {
                if(user != null)
                {
                    List<String> UserAuthTokens = user.UserAuthTokens;
                    if (UserAuthTokens == null || UserAuthTokens.Count == 0)
                    {
                        UserAuthTokens = new List<String>();
                        UserAuthTokens.Add(token);
                        user.UserAuthTokens = UserAuthTokens;
                        if(UpdateUser(user.Id, user))
                        {
                            return token;
                        }
                    }
                    else
                    {
                        if (UpdateUser(user.Id, user))
                        {
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
        
        public string CreateNewAccount(User newUser)
        {           
            if(newUser != null)
            {
                if(GetUserByEmail(newUser.Email) == null)
                {
                    newUser.Password = BCryptNet.HashPassword(newUser.Password);
                    newUser.Tokens = new Dictionary<string, VerficationCode>();
                    newUser.UserAuthTokens = new List<String>();
                    CreateUser(newUser);

                    User createdUser = GetUserByEmail(newUser.Email);
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
        
        public string CreateNewAccount(string username, string password, string FirstName, string LastName, String Address)
        {
           if(GetUserByEmail(username) == null)
            {
                User newUser = new User();
                newUser.Email = username;
                newUser.Password = BCryptNet.HashPassword(password);
                newUser.Tokens = new Dictionary<string, VerficationCode>();
                newUser.UserAuthTokens = new List<String>();
                CreateUser(newUser);

                User createdUser = GetUserByEmail(username);
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

        public string Login(string username, string password)
        {
            User user = GetUserByEmail(username);
            if (user != null && BCryptNet.Verify(password, user.Password))
            {
                return TokenService.tokenCreator(user.Email == null ? username : user.Email, user.Password, UserNewAccountDelegate, user);
            }

            return null;
        }

        public User GetUserByEmail(string email)
        {
            var filter = Builders<User>.Filter.Eq("Email", email);
            return userCollection.Find(filter).FirstOrDefault();
        }

        public User GetUserByAuthToken(string authToken)
        {
            var filter = Builders<User>.Filter.Eq("UserAuthTokens", authToken);
            var user = userCollection.Find(filter).FirstOrDefault();
            return user;
        }

        public User GetUserById(ObjectId userId)
        {
            return userCollection.Find(user => user.Id == userId).FirstOrDefault();
        }

        public void CreateUser(User user)
        {
            userCollection.InsertOne(user);
        }

        public bool UpdateUser(ObjectId userId, User updatedUser)
        {
            return userCollection.ReplaceOne(user => user.Id == userId, updatedUser).IsAcknowledged;
        }

        public void DeleteUser(ObjectId userId)
        {
            userCollection.DeleteOne(user => user.Id == userId);
        }
    }
}
