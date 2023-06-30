using Newtonsoft.Json;

namespace BixbyShop_LK
{
    public class UserLoginReq
    {
        [JsonProperty("email")]
        public string email { get; set; }
        [JsonProperty("password")]
        public string secret { get; set; }
    }
}
