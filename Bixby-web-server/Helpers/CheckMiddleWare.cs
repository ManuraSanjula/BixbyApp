using System.Net;
using Bixby_web_server.Models;
using Bixby_web_server.Services;
using BixbyShop_LK.Services;
using MongoDB.Bson;
using Newtonsoft.Json;

namespace Bixby_web_server.Helpers;

public class CheckMiddleWare
{
    private UserService UserService { get; } = new();

    private Dictionary<string, object> Values { get; set; } = new();

    private static async Task<User?> GetTheUserFromToken(HttpListenerRequest request)
    {
        var authorizationHeader = request.Headers["Authorization"];
        if (string.IsNullOrEmpty(authorizationHeader) || !authorizationHeader.StartsWith("Bearer ")) return null;

        var jwtToken = authorizationHeader.Substring("Bearer ".Length);
        User? jwtUser = await TokenService.ValidateJwtToken(jwtToken);
        return jwtUser;
    }


    public async Task<Dictionary<string, object>> CheckUserReq<T>(string jsonString, string?[]? dynamic)
    {
        if (string.IsNullOrEmpty(jsonString)) return Values;

        var settings = new JsonSerializerSettings
        {
            NullValueHandling = NullValueHandling.Ignore
        };

        if (typeof(T) == typeof(UserReqForUpdate))
        {
            var userReq = JsonConvert.DeserializeObject<UserReqForUpdate>(jsonString, settings);
            if (userReq == null && NullEmptyChecker.HasNullEmptyValues(userReq)) return Values;
            if (dynamic is not { Length: > 0 } || string.IsNullOrEmpty(dynamic[0])) return Values;
            User? user = null;
            try
            {
                user = JsonConvert.DeserializeObject<User>(RedisCache.Get(dynamic[0]) ?? string.Empty);
            }
            catch (Exception)
            {
                // ignored
            }

            if (user != null)
            {
                var userDb = await UserService.GetUserByEmailAsync(dynamic[0]);
                if (userDb == null) return Values;
                if (!user.Equals(userDb))
                {
                    user = userDb;
                    try
                    {
                        RedisCache.Set(user.Email, user.ToJson());
                    }
                    catch (Exception)
                    {
                        // ignored
                    }
                }
            }
            else
            {
                user = await UserService.GetUserByEmailAsync(dynamic[0]);
                try
                {
                    if (user != null) RedisCache.Set(user.Email, user.ToJson());
                }
                catch (Exception)
                {
                    // ignored
                }
            }

            if (user == null && NullEmptyChecker.HasNullEmptyValues(user) && user!.EmailVerify) return Values;

            if (userReq != null) Values.Add("UserReqForUpdate", userReq);
            if (user != null) Values.Add("User", user);

            Console.WriteLine(user.ToJson());
            Console.WriteLine(userReq.ToJson());

            return Values;
        }

        if (typeof(T) == typeof(UserLoginReq)) return CheckUserLoginReq(jsonString, settings);
        if (typeof(T) == typeof(UserReqForSignUp)) return CheckUserReqForSignUp(jsonString, settings);

        if (typeof(T) != typeof(ShopItemeq)) return Values;
        {
            var shopItemReq = JsonConvert.DeserializeObject<ShopItemeq>(jsonString, settings);
            if (shopItemReq == null || NullEmptyChecker.HasNullEmptyValues(shopItemReq)) return Values;

            if (dynamic is not { Length: > 0 }) return Values;
            User? user = null;
            try
            {
                user = JsonConvert.DeserializeObject<User>(RedisCache.Get(dynamic[0]) ?? string.Empty);
            }
            catch (Exception)
            {
                // ignored
            }

            if (user != null)
            {
                var userDb = await UserService.GetUserByEmailAsync(dynamic[0]);
                if (userDb == null) return Values;
                if (!user.Equals(userDb))
                {
                    user = userDb;
                    try
                    {
                        RedisCache.Set(user.Email, user.ToJson());
                    }
                    catch (Exception)
                    {
                        // ignored
                    }
                }
            }
            else
            {
                user = await UserService.GetUserByEmailAsync(dynamic[0]);
                try
                {
                    RedisCache.Set(user?.Email, user.ToJson());
                }
                catch (Exception)
                {
                    // ignored
                }
            }

            if (user == null || NullEmptyChecker.HasNullEmptyValues(user) || !user.EmailVerify) return Values;
            var userInShopItem = new UserInShopItem
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                Pic = user.Pic
            };

            var shopItem = new ShopItem
            {
                Name = shopItemReq.Name,
                Price = shopItemReq.Price,
                publish = userInShopItem,
                Description = shopItemReq.Description
            };

            Values.Add("data", shopItem);
            return Values;
        }
    }

    private Dictionary<string, object> CheckUserReqForSignUp(string jsonString, JsonSerializerSettings settings)
    {
        var userReq = JsonConvert.DeserializeObject<UserReqForSignUp>(jsonString, settings);
        if (userReq == null || NullEmptyChecker.HasNullEmptyValues(userReq)) return Values;
        Values.Add("User", userReq);
        return Values;
    }

    private Dictionary<string, object> CheckUserLoginReq(string jsonString, JsonSerializerSettings? settings)
    {
        var user = JsonConvert.DeserializeObject<UserLoginReq>(jsonString, settings);
        if (user == null) return Values;
        Values.Add("User", user);
        return Values;
    }

    public async Task<Dictionary<string, object>> CheckMiddleWareJwt(HttpContext context, string? dynamicName)
    {
        var request = context.Request;
        var jwtUser = await GetTheUserFromToken(request);
        if (jwtUser == null || !jwtUser.EmailVerify || !string.Equals(jwtUser.Email, dynamicName)) return Values;
        Values.Add("jwt", jwtUser);
        return Values;
    }

    public async Task<Dictionary<string, object>> CheckMiddleWareJwt(HttpContext context)
    {
        var request = context.Request;
        var jwtUser = await GetTheUserFromToken(request);
        if (jwtUser == null || !jwtUser.EmailVerify) return Values;
        Values.Add("jwt", jwtUser);
        return Values;
    }
}