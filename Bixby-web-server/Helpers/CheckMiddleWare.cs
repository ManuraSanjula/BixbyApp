using System.Dynamic;
using System.Net;
using Bixby_web_server.Models;
using BixbyShop_LK.Services;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;

namespace Bixby_web_server.Helpers
{
    public class CheckMiddleWare
    {
        private static User? GetTheUserFromToken(HttpListenerRequest request)
        {
            var authorizationHeader = request.Headers["Authorization"];
            if (!string.IsNullOrEmpty(authorizationHeader))
            {
                if (authorizationHeader.StartsWith("Bearer "))
                {
                    var jwtToken = authorizationHeader.Substring("Bearer ".Length);
                    User? jwtUser = TokenService.ValidateJwtToken(jwtToken, false, (token) => { });
                    return jwtUser;
                }
                return null;
            }
            return null;
        }
        private UserService UserService { get; set; } = new UserService();
        public bool IsOkay { get; set; }
        public User? User { get; set; }
        public UserReqAndRes? UserReqAndRes { get; set; }
        public UserLoginReq? UserLoginReq { get; set; }

        public dynamic? CheckUserReq<T>(string token, string[]? dynamic)
        {
            if (token.IsNullOrEmpty())
            {
                return new CheckMiddleWare
                {
                    IsOkay = false,
                    User = null,
                    UserReqAndRes = null,
                    UserLoginReq = null
                };
            }
            else
            {
                JsonSerializerSettings? settings = new JsonSerializerSettings
                {
                    NullValueHandling = NullValueHandling.Ignore
                };
                if (typeof(T) == typeof(UserReqAndRes))
                {
                    UserReqAndRes? userReq = JsonConvert.DeserializeObject<UserReqAndRes>(token, settings);
                    if (userReq == null && NullEmptyChecker.HasNullEmptyValues(userReq))
                    {
                        return new CheckMiddleWare
                        {
                            IsOkay = false,
                            User = null,
                            UserReqAndRes = userReq,
                            UserLoginReq = null
                        };
                    }
                    else
                    {
                        if (dynamic.Length > 0)
                        {
                            if (string.IsNullOrEmpty(dynamic[0]))
                            {
                                return new CheckMiddleWare
                                {
                                    IsOkay = false,
                                    User = null,
                                    UserReqAndRes = userReq,
                                    UserLoginReq = null
                                };
                            }
                            User? user = UserService.GetUserByEmail(dynamic[0].ToString());
                            if (user == null && User == null &&
                                NullEmptyChecker.HasNullEmptyValues(User) &&
                                NullEmptyChecker.HasNullEmptyValues(user))
                            {
                                return new CheckMiddleWare
                                {
                                    IsOkay = false,
                                    User = null,
                                    UserReqAndRes = userReq,
                                    UserLoginReq = null
                                };
                            }
                            else
                            {
                                if (!user.Tokens.Equals(User.Tokens) && !user.Password.Equals(User.Password))
                                {
                                    return new CheckMiddleWare
                                    {
                                        IsOkay = false,
                                        User = null,
                                        UserReqAndRes = userReq,
                                        UserLoginReq = null

                                    };
                                }
                                else
                                {
                                    return new CheckMiddleWare
                                    {
                                        IsOkay = true,
                                        User = user,
                                        UserReqAndRes = userReq,
                                        UserLoginReq = new UserLoginReq
                                        {
                                            email = userReq.Email,
                                            secret = "Nothing"
                                        }
                                    };
                                }
                            }

                        }
                        else
                        {
                            return new CheckMiddleWare
                            {
                                IsOkay = false,
                                User = null,
                                UserReqAndRes = userReq,
                                UserLoginReq = null
                            };
                        }
                    }
                }
                else if (typeof(T) == typeof(UserLoginReq))
                {
                    UserLoginReq user = JsonConvert.DeserializeObject<UserLoginReq>(token, settings);
                    if (user == null)
                    {
                        dynamic result = new ExpandoObject();
                        result.IsOkay = false;
                        result.UserLoginReq = null;
                        return result;
                    }
                    else
                    {
                        dynamic result = new ExpandoObject();
                        result.IsOkay = true;
                        result.UserLoginReq = user;
                        return result;
                    }
                }
                else
                {
                    dynamic result = new ExpandoObject();
                    result.IsOkay = false;
                    result.UserLoginReq = null;
                    return result;
                }

            }
        }

        public dynamic CheckMiddleWareJWT(HttpContext context, string dynamicName)
        {
            var request = context.Request;

            User? jwtUser = GetTheUserFromToken(request);
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
                dynamic result = new ExpandoObject();
                result.IsOkay = false;
                result.User = null;
                return result;
            }
        }
    }
}
