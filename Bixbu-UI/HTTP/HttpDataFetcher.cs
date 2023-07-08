using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Bixbu_UI.HTTP
{
    [JsonObject]
    public class CartItem
    {
        public string _id { get; set; }
        public string Item { get; set; }
        public string User { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
    }

    public class OrderRes
    {
        public string status { get; set; }
        public List<Order> data { get; set; }
    }

    public class Order
    {
        public string _id { get; set; }
        public string Item { get; set; }
        public string User { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
    }

    public partial class HttpDataFetcher
    {
        public static Task<Dictionary<string, object>>? fetchUserTask;
        public static Task<HashSet<Item>>? fetchItemsTask;
        private readonly HttpClient _httpClient;
        public static Task<List<CartItem>>? fetchCartItemsTask;
        public static Task<List<Order>>? fetchOrdersTask;

        public HttpDataFetcher()
        {
            _httpClient = new HttpClient();
        }

        public async Task RefreshDataAsync(string email, string token)
        {
            await FetchDataAsync(email, token);
        }

        public async Task FetchDataAsync(string email, string token)
        {
            Console.WriteLine("Loading screen displayed...");

            fetchUserTask = FetchUserAsync(email, token);
            fetchItemsTask = FetchItemsAsync(email, token);

            fetchCartItemsTask = FetchCartItemsAsync(email, token);
            fetchOrdersTask = FetchOrdersAsync(email, token);

            await Task.WhenAll(fetchUserTask, fetchItemsTask, fetchCartItemsTask, fetchOrdersTask);

            Dictionary<string, object> user = fetchUserTask.Result;
            HashSet<Item> items = fetchItemsTask.Result;

            List<CartItem> cartItems = fetchCartItemsTask.Result;
            List<Order> orders = fetchOrdersTask.Result;

            // Continue with processing the fetched data
            Console.WriteLine("User data: " + user);
            Console.WriteLine("Item data: " + string.Join(", ", items));
            Console.WriteLine("Cart details: " + string.Join(", ", cartItems));
            Console.WriteLine("Order details: " + string.Join(", ", orders));

            Console.WriteLine("Loading screen removed...");
        }

        private async Task<Dictionary<string, object>> FetchUserAsync(string email, string token)
        {
            try
            {
                var client = new HttpClient();
                var request = new HttpRequestMessage(HttpMethod.Get, $"http://localhost:8080/user/{email}");
                request.Headers.Add("Authorization", $"Bearer {token}");
                var response = await client.SendAsync(request);
                var httpResponseMessage = response.EnsureSuccessStatusCode();

                if (httpResponseMessage.IsSuccessStatusCode)
                {
                    var responseBody = await response.Content.ReadAsStringAsync();
                    dynamic json = JsonConvert.DeserializeObject(responseBody);
                    string bodyKey = json["body"].ToString();
                    var userDict = JsonConvert.DeserializeObject<Dictionary<string, object>>(bodyKey);
                    return userDict;
                }
                return null;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private async Task<HashSet<Item>> FetchItemsAsync(string email, string token)
        {
            try
            {
                var path = "home";
                var client = new HttpClient();
                var request = new HttpRequestMessage(HttpMethod.Get, $"http://localhost:8080/{path}");

                var response = await client.SendAsync(request);
                response.EnsureSuccessStatusCode();

                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    var responseObject = JsonConvert.DeserializeObject<Response>(json);
                    return responseObject.body;
                }
                return null;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private async Task<List<CartItem>> FetchCartItemsAsync(string email, string token)
        {
            try
            {
                var client = new HttpClient();
                var request = new HttpRequestMessage(HttpMethod.Get, $"http://localhost:8080/cart/{email}/view");
                request.Headers.Add("Authorization", $"Bearer {token}");
                var response = await client.SendAsync(request);
                response.EnsureSuccessStatusCode();
                var json = await response.Content.ReadAsStringAsync();

                // Check if the JSON response is an object or an array
                if (json.StartsWith("{"))
                {
                    // Single object received, deserialize into a single CartItem object
                    var cartItem = JsonConvert.DeserializeObject<CartItem>(json);
                    return new List<CartItem> { cartItem };
                }
                else if (json.StartsWith("["))
                {
                    // JSON array received, deserialize into a list of CartItem objects
                    var cartItems = JsonConvert.DeserializeObject<List<CartItem>>(json);
                    return cartItems;
                }
                else
                {
                    // Invalid JSON format
                    throw new JsonSerializationException("Invalid JSON format");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }


        private async Task<List<Order>> FetchOrdersAsync(string email, string token)
        {
            try
            {
                var client = new HttpClient();
                var request = new HttpRequestMessage(HttpMethod.Get, $"http://localhost:8080/order/{email}/view");
                request.Headers.Add("Authorization", $"Bearer {token}");
                var response = await client.SendAsync(request);
                response.EnsureSuccessStatusCode();
                var json = await response.Content.ReadAsStringAsync();

                // Check if the JSON response is an object
                if (json.StartsWith("{"))
                {
                    // Single object received, create a list with a single item
                    var order = JsonConvert.DeserializeObject<Order>(json);
                    return new List<Order> { order };
                }
                else if (json.StartsWith("["))
                {
                    // JSON array received, deserialize into a list of Order objects
                    var orders = JsonConvert.DeserializeObject<List<Order>>(json);
                    return orders;
                }
                else
                {
                    // Invalid JSON format
                    throw new JsonSerializationException("Invalid JSON format");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
