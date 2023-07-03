using Newtonsoft.Json;

namespace Bixby_web_server.Models
{
    public class UserLoginReq
    {
        [JsonProperty("email")]
        public string? email { get; set; }
        [JsonProperty("password")]
        public string secret { get; set; }
    }
}
