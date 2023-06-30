using BixbyShop_LK.Models.Comments;
using BixbyShop_LK.Models.Order;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using Newtonsoft.Json;

namespace BixbyShop_LK
{
    public class VerficationCode
    {
        public string dateTimeKey { get; set; }
        public bool valid { get; set; } 
    }

    [Serializable]
    public class User
    {
        [BsonId]
        public ObjectId Id { get; set; }
        
        [JsonProperty("firstName")]
        public String FirstName { get; set; }
        
        [JsonProperty("lastName")]
        public String LastName { get; set; }
        
        [JsonProperty("email")]
        public String Email { get; set; }
        
        [JsonProperty("address")]
        public String Address { get; set; }
        
        [JsonProperty("password")]
        public String Password { get; set; }
        
        [JsonProperty("pic")]
        public String Pic { get; set; }
        
        public bool EmailVerify { get; set; }
        public Order[] Orders { get; set; }
        public CartAndOrder[] Cart { get; set; }
        public Comment[] Comments { get; set; }
        public Dictionary<string, VerficationCode> Tokens { get; set; }

        public List<String> UserAuthTokens { get; set; }
        public User()
        {
            UserAuthTokens = new List<String>();
            Tokens = new Dictionary<string, VerficationCode>();
        }

        public void AddToken(string token,string dateTimeKey)
        {
            VerficationCode verficationCode = new VerficationCode();
            verficationCode.dateTimeKey = dateTimeKey;
            verficationCode.valid = true;

            Tokens[token] = verficationCode;
        }

        public bool IsTokenExpired(string token)
        {
            if (Tokens.ContainsKey(token))
            {
                bool isExpired = false;
                VerficationCode verficationCode = Tokens[token];
                if (verficationCode != null)
                {
                    if (verficationCode.valid)
                    {
                        DateTime storedDateTime = DateTime.Parse(verficationCode.dateTimeKey);
                        DateTime currentDateTime = DateTime.Now;
                        TimeSpan elapsed = currentDateTime - storedDateTime;
                        isExpired = elapsed.TotalMinutes >= 15;
                        return isExpired;
                    }
                    else
                        return true;
                }
                return true;
            }
            return true; // Default value if key does not exist
        }
    }
}
