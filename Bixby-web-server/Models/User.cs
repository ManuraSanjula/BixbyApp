using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using Newtonsoft.Json;

namespace Bixby_web_server.Models
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
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("pic")]
        public string Pic { get; set; } = "default";

        public bool EmailVerify { get; set; }
        public Dictionary<string, VerficationCode> Tokens { get; set; }

        public List<string> UserAuthTokens { get; set; }
        public User()
        {
            UserAuthTokens = new List<string>();
            Tokens = new Dictionary<string, VerficationCode>();
        }

        public void AddToken(string token, string dateTimeKey)
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
