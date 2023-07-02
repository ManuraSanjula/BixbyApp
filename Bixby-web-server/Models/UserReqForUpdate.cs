using Newtonsoft.Json;

namespace Bixby_web_server.Models
{

    public class UserReqForSignUp
    {
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

        [JsonProperty("confirmNewPassword")] public string confirmNewPassword { get; set; }
    }
    public class UserReqForUpdate
    {
        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }
    }
}
