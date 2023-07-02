using System.Dynamic;
using System.Net;
using Bixby_web_server.Models;
using BixbyShop_LK.Services;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace Bixby_web_server.Helpers
{
    public class CheckMiddleWare
    {
        private UserService UserService { get; } = new UserService();
        public bool IsOkay { get; set; }
        public User? User { get; set; }
        public UserReqForUpdate? UserReqAndRes { get; set; }
        public UserLoginReq? UserLoginReq { get; set; }

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


        public dynamic? CheckUserReq<T>(string jsonString, string[]? dynamic)
        {
            if (string.IsNullOrEmpty(jsonString))
            {
                return CreateErrorResponse();
            }

            JsonSerializerSettings? settings = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore
            };

            if (typeof(T) == typeof(UserReqForUpdate))
            {
                Console.WriteLine("0 ----");
                return CheckUserReqAndRes(jsonString, dynamic, settings);
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
                return CheckShopItemReq(jsonString, dynamic, settings);
            }
            else
            {
                return CreateErrorResponse();
            }
        }

        private dynamic CheckUserReqForSignUp(string jsonString, JsonSerializerSettings settings)
        {
            UserReqForSignUp? userReq = JsonConvert.DeserializeObject<UserReqForSignUp>(jsonString, settings);
            if (userReq == null || NullEmptyChecker.HasNullEmptyValues(userReq))
            {
                return CreateErrorResponse();
            }
            dynamic result = new ExpandoObject();
            result.IsOkay = true;
            result.User = userReq;
            return result;
        }

        private dynamic CreateErrorResponse()
        {
            dynamic result = new ExpandoObject();
            result.IsOkay = false;
            return result;
        }
        private async Task<dynamic> CheckUserReqAndRes(string jsonString, string[]? dynamic, JsonSerializerSettings? settings)
        {
            UserReqForUpdate? userReq = JsonConvert.DeserializeObject<UserReqForUpdate>(jsonString, settings);
            Console.WriteLine("1 Fuck you C#----");
            if (userReq == null && NullEmptyChecker.HasNullEmptyValues(userReq))
            {
                Console.WriteLine("1 Fuck you and you such a pussy C#----");
                return CreateErrorResponse();
            }
            Console.WriteLine("2 Fuck you C#----");

            if (dynamic.Length > 0 && !string.IsNullOrEmpty(dynamic[0]))
            {
                Console.WriteLine("1 ----");
                User? user = await UserService.GetUserByEmailAsync(dynamic[0]);
                if (user == null || User == null || NullEmptyChecker.HasNullEmptyValues(User) || NullEmptyChecker.HasNullEmptyValues(user))
                {
                    Console.WriteLine("2 ----");
                    return CreateErrorResponse();
                }

                if (!user.Tokens.Equals(User.Tokens) && !user.Password.Equals(User.Password))
                {
                    Console.WriteLine("3 ----");
                    return CreateErrorResponse();
                }
                Console.WriteLine("4 ----");
                return CreateSuccessResponse(user, userReq);
            }
            else
            {
                Console.WriteLine("5 ----");
                return CreateErrorResponse();
            }
        }

        private dynamic CreateSuccessResponse(User user, UserReqForUpdate userReq)
        {
            dynamic result = new ExpandoObject();
            result.IsOkay = true;
            result.User = user;
            result.UserReqAndRes = userReq;
            result.UserLoginReq = new UserLoginReq
            {
                email = userReq.Email,
                secret = "Nothing"
            };
            return result;
        }

        private dynamic CheckUserLoginReq(string jsonString, JsonSerializerSettings? settings)
        {
            UserLoginReq? user = JsonConvert.DeserializeObject<UserLoginReq>(jsonString, settings);
            if (user == null)
            {
                return CreateErrorResponse();
            }

            dynamic result = new ExpandoObject();
            result.IsOkay = true;
            result.UserLoginReq = user;
            return result;
        }

        private async Task<dynamic> CheckShopItemReq(string jsonString, string[]? dynamic, JsonSerializerSettings? settings)
        {
            ShopItemeq? shopItemeq = JsonConvert.DeserializeObject<ShopItemeq>(jsonString, settings);
            if (shopItemeq == null || NullEmptyChecker.HasNullEmptyValues(shopItemeq))
            {
                return CreateErrorResponse();
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

                    dynamic result = new ExpandoObject();
                    result.IsOkay = true;
                    result.shopItemeq = shopItem;
                    return result;
                }
            }

            return CreateErrorResponse();
        }

        public async Task<dynamic> CheckMiddleWareJWT(HttpContext context, string dynamicName)
        {
            var request = context.Request;
            User? jwtUser = await GetTheUserFromToken(request);
            if (jwtUser != null && jwtUser.EmailVerify && string.Equals(jwtUser.Email, dynamicName))
            {
                User = jwtUser;
                dynamic result = new ExpandoObject();
                result.IsOkay = true;
                result.User = jwtUser;
                return result;
            }
            else
            {
                return CreateErrorResponse();
            }
        }
    }
}
