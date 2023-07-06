using Newtonsoft.Json;

namespace Bixby_web_server.Models;

public class UserPasswordResetReq
{
    [JsonProperty("password")] public string password { get; set; }

    [JsonProperty("confirmPassword")] public string confirmPassword { get; set; }
}