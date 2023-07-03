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
    public class User : IEquatable<User>
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("email")]
        public string? Email { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

        public bool Equals(User? other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return Id.Equals(other.Id) && FirstName == other.FirstName && LastName == other.LastName && Email == other.Email && Address == other.Address && Password == other.Password && Pic == other.Pic && EmailVerify == other.EmailVerify && Tokens.Equals(other.Tokens) && UserAuthTokens.Equals(other.UserAuthTokens);
        }

        public override bool Equals(object? obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((User)obj);
        }

        public override int GetHashCode()
        {
            var hashCode = new HashCode();
            hashCode.Add(Id);
            hashCode.Add(FirstName);
            hashCode.Add(LastName);
            hashCode.Add(Email);
            hashCode.Add(Address);
            hashCode.Add(Password);
            hashCode.Add(Pic);
            hashCode.Add(EmailVerify);
            hashCode.Add(Tokens);
            hashCode.Add(UserAuthTokens);
            return hashCode.ToHashCode();
        }

        public static bool operator ==(User? left, User? right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(User? left, User? right)
        {
            return !Equals(left, right);
        }

        private sealed class UserEqualityComparer : IEqualityComparer<User>
        {
            public bool Equals(User x, User y)
            {
                if (ReferenceEquals(x, y)) return true;
                if (ReferenceEquals(x, null)) return false;
                if (ReferenceEquals(y, null)) return false;
                if (x.GetType() != y.GetType()) return false;
                return x.Id.Equals(y.Id) && x.FirstName == y.FirstName && x.LastName == y.LastName && x.Email == y.Email && x.Address == y.Address && x.Password == y.Password && x.Pic == y.Pic && x.EmailVerify == y.EmailVerify && x.Tokens.Equals(y.Tokens) && x.UserAuthTokens.Equals(y.UserAuthTokens);
            }

            public int GetHashCode(User obj)
            {
                var hashCode = new HashCode();
                hashCode.Add(obj.Id);
                hashCode.Add(obj.FirstName);
                hashCode.Add(obj.LastName);
                hashCode.Add(obj.Email);
                hashCode.Add(obj.Address);
                hashCode.Add(obj.Password);
                hashCode.Add(obj.Pic);
                hashCode.Add(obj.EmailVerify);
                hashCode.Add(obj.Tokens);
                hashCode.Add(obj.UserAuthTokens);
                return hashCode.ToHashCode();
            }
        }

        public static IEqualityComparer<User> UserComparer { get; } = new UserEqualityComparer();

        [JsonProperty("pic")]
        public string Pic { get; set; } = "default";

        public bool EmailVerify { get; set; }
        public Dictionary<string?, VerficationCode> Tokens { get; set; }

        public List<string> UserAuthTokens { get; set; }
        public User()
        {
            UserAuthTokens = new List<string>();
            Tokens = new Dictionary<string?, VerficationCode>();
        }

        public void AddToken(string? token, string dateTimeKey)
        {
            VerficationCode verficationCode = new VerficationCode();
            verficationCode.dateTimeKey = dateTimeKey;
            verficationCode.valid = true;

            Tokens[token] = verficationCode;
        }

        public bool IsTokenExpired(string? token)
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
