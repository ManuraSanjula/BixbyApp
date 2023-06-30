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
        protected bool Equals(User other)
        {
            return Id.Equals(other.Id) && FirstName == other.FirstName && LastName == other.LastName && Email == other.Email && Address == other.Address && Password == other.Password && Pic == other.Pic && EmailVerify == other.EmailVerify && Orders.Equals(other.Orders) && Cart.Equals(other.Cart) && Comments.Equals(other.Comments) && Tokens.Equals(other.Tokens) && UserAuthTokens.Equals(other.UserAuthTokens);
        }

        private sealed class UserEqualityComparer : IEqualityComparer<User>
        {
            public bool Equals(User x, User y)
            {
                if (ReferenceEquals(x, y)) return true;
                if (ReferenceEquals(x, null)) return false;
                if (ReferenceEquals(y, null)) return false;
                if (x.GetType() != y.GetType()) return false;
                return x.Id.Equals(y.Id) && x.FirstName == y.FirstName && x.LastName == y.LastName && x.Email == y.Email && x.Address == y.Address && x.Password == y.Password && x.Pic == y.Pic && x.EmailVerify == y.EmailVerify && x.Orders.Equals(y.Orders) && x.Cart.Equals(y.Cart) && x.Comments.Equals(y.Comments) && x.Tokens.Equals(y.Tokens) && x.UserAuthTokens.Equals(y.UserAuthTokens);
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
                hashCode.Add(obj.Orders);
                hashCode.Add(obj.Cart);
                hashCode.Add(obj.Comments);
                hashCode.Add(obj.Tokens);
                hashCode.Add(obj.UserAuthTokens);
                return hashCode.ToHashCode();
            }
        }

        public static IEqualityComparer<User> UserComparer { get; } = new UserEqualityComparer();

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
            hashCode.Add(Orders);
            hashCode.Add(Cart);
            hashCode.Add(Comments);
            hashCode.Add(Tokens);
            hashCode.Add(UserAuthTokens);
            return hashCode.ToHashCode();
        }

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
