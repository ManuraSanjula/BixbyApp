using System.Dynamic;
using System.Net;
using Bixby_web_server.Models;
using BixbyShop_LK.Services;
using Newtonsoft.Json;

namespace Bixby_web_server.Helpers
{
    public class CheckMiddleWare
    {
        private UserService UserService { get; } = new UserService();
        public bool IsOkay { get; set; }
        public User? User { get; set; }

        public Dictionary<string, object> values { get; set; } = new Dictionary<string, object>();
        private static async Task<User?> GetTheUserFromToken(HttpListenerRequest request)
        {
            var authorizationHeader = request.Headers["Authorization"];
            if (string.IsNullOrEmpty(authorizationHeader) || !authorizationHeader.StartsWith("Bearer "))
            {
                return null;
            }

            var jwtToken = authorizationHeader.Substring("Bearer ".Length);
            User? jwtUser = await TokenService.ValidateJwtToken(jwtToken);
            return jwtUser;
        }


        public async Task<Dictionary<string, object>> CheckUserReq<T>(string jsonString, string[]? dynamic)
        {
            if (string.IsNullOrEmpty(jsonString))
            {
                return values;
            }

            JsonSerializerSettings? settings = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore
            };

            if (typeof(T) == typeof(UserReqForUpdate))
            {
                UserReqForUpdate? userReq = JsonConvert.DeserializeObject<UserReqForUpdate>(jsonString, settings);
                if (userReq == null && NullEmptyChecker.HasNullEmptyValues(userReq))
                {
                    return values;
                }
                if (dynamic.Length > 0 && !string.IsNullOrEmpty(dynamic[0]))
                {
                    User? user = await UserService.GetUserByEmailAsync(dynamic[0]);
                    Console.WriteLine(User == null);
                    if (user == null && NullEmptyChecker.HasNullEmptyValues(User))
                    {
                        return values;
                    }
                    values.Add("UserReqForUpdate", userReq);
                    values.Add("User", user);
                    return values;
                }
                else
                {
                    return values;
                }
            }
            else if (typeof(T) == typeof(UserLoginReq))
            {
                return CheckUserLoginReq(jsonString, settings);

            }else if (typeof(T) == typeof(UserReqForSignUp))
            {
                return CheckUserReqForSignUp(jsonString, settings);
            }
            else if (typeof(T) == typeof(ShopItemeq))
            {
                ShopItemeq? shopItemeq = JsonConvert.DeserializeObject<ShopItemeq>(jsonString, settings);
                if (shopItemeq == null || NullEmptyChecker.HasNullEmptyValues(shopItemeq))
                {
                    return values;
                }

                if (dynamic.Length > 0)
                {
                    User u = await UserService.GetUserByEmailAsync(dynamic[0]);
                    if (u != null && u.Email.Equals(dynamic[0]))
                    {
                        UserInShopItem userInShopItem = new UserInShopItem
                        {
                            FirstName = User.FirstName,
                            LastName = User.LastName,
                            Email = User.Email,
                            Pic = User.Pic
                        };

                        ShopItem shopItem = new ShopItem
                        {
                            Name = shopItemeq.Name,
                            Price = shopItemeq.Price,
                            publish = userInShopItem,
                            Description = shopItemeq.Description
                        };
                        values.Add(shopItem.publish.Email, shopItem);
                        return values;
                    }
                }

                return values;
            }
            else
            {
                return values;
            }
        }

        private Dictionary<string, object> CheckUserReqForSignUp(string jsonString, JsonSerializerSettings settings)
        {
            UserReqForSignUp? userReq = JsonConvert.DeserializeObject<UserReqForSignUp>(jsonString, settings);
            if (userReq == null || NullEmptyChecker.HasNullEmptyValues(userReq))
            {
                return values;
            }
            values.Add("User", userReq);
            return values;
        }
        private Dictionary<string, object> CheckUserLoginReq(string jsonString, JsonSerializerSettings? settings)
        {
            UserLoginReq? user = JsonConvert.DeserializeObject<UserLoginReq>(jsonString, settings);
            if (user == null)
            {
                return values;
            }
            values.Add("User", user);
            return values;
        }

        public async Task<Dictionary<string, object>> CheckMiddleWareJWT(HttpContext context, string dynamicName)
        {
            var request = context.Request;
            User? jwtUser = await GetTheUserFromToken(request);
            if (jwtUser != null && jwtUser.EmailVerify && string.Equals(jwtUser.Email, dynamicName))
            {
                values.Add("jwt", jwtUser);
                return values;
            }
            else
            {
                return values;
            }
        }
    }
}
