using Newtonsoft.Json;

namespace Bixbu_UI.HTTP;

public class HttpDataFetcher_v2
{
    public static Task<Dictionary<string, object>>? fetchUserTask;
    public static Task<HashSet<Item>>? fetchItemsTask;
    public static Task<Cart>? fetchCartItemsTask;
    public static Task<OrderRes>? fetchOrdersTask;
    private readonly HttpClient _httpClient;

    public HttpDataFetcher_v2()
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

        await Task.WhenAll(fetchUserTask, fetchItemsTask);

        await FetchRemainingDataAsync(email, token);
    }

    private async Task FetchRemainingDataAsync(string email, string token)
    {
        var userDict = await fetchUserTask;
        var itemsSet = await fetchItemsTask;

        var fetchCartTask = FetchCartItemsAsync(email, token, userDict);
        var fetchOrdersTask = FetchOrdersAsync(email, token, itemsSet);

        await Task.WhenAll(fetchCartTask, fetchOrdersTask);
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
            MessageBox.Show(ex.Message + " FetchUserAsync");
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
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message + " FetchItemsAsync");
            throw;
        }
    }

    private async Task<Cart> FetchCartItemsAsync(string email, string token, Dictionary<string, object> userDict)
    {
        try
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Get, $"http://localhost:8080/cart/{email}/view");
            request.Headers.Add("Authorization", $"Bearer {token}");
            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            var cart = JsonConvert.DeserializeObject<Cart>(json);

            // Modify cart data using userDict if needed

            return cart;
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message + " FetchCartItemsAsync");
            throw;
        }
    }

    private async Task<OrderRes> FetchOrdersAsync(string email, string token, HashSet<Item> itemsSet)
    {
        try
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Get, $"http://localhost:8080/order/{email}/view");
            request.Headers.Add("Authorization", $"Bearer {token}");
            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            var orderRes = JsonConvert.DeserializeObject<OrderRes>(json);

            // Modify orderRes data using itemsSet if needed

            return orderRes;
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message + " FetchOrdersAsync");
            throw;
        }
    }
}