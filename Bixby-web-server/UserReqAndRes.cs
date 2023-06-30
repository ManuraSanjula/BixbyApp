using Newtonsoft.Json;

namespace BixbyShop_LK
{
    public class UserReqAndRes
    {
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

        [JsonProperty("newPassword")] public String newPassword { get; set; } = "";

        [JsonProperty("confirmNewPassword")] public String confirmNewPassword { get; set; } = "";

        public bool UpdateUserEmail { get; set; } = false;
        public bool UpdateUserPass { get; set; } = false;
    }
}
