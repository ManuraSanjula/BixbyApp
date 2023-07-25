using Newtonsoft.Json;

namespace Bixbu_UI.HTTP;

public class Cart
{
    public string status { get; set; }
    public List<Data> data { get; set; }
}

public class Data
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
    public List<string> Items { get; set; }
    public string User { get; set; }
    public int Price { get; set; }
    public bool Confirm { get; set; }
}


public class Product
{
    public string _id { get; set; }
    public string User { get; set; }
    public string Item { get; set; }
    public string TotalSuccessfulOrders { get; set; }
    public string TotalRefunds { get; set; }
    public string TotalViews { get; set; }
}

public class ProductRes
{
    public string status { get; set; }
    public List<Product> allTheProducts { get; set; }
}

public class HttpDataFetcher
{
    public static Task<Dictionary<string, object>>? fetchUserTask;
    public static Task<HashSet<Item>>? fetchItemsTask;
    public static Task<Cart>? fetchCartItemsTask;
    public static Task<OrderRes>? fetchOrdersTask;
    public static Task<ProductRes>? fetchProductTask;
    private readonly HttpClient _httpClient;

    public HttpDataFetcher()
    {
        _httpClient = new HttpClient();
    }

    public async Task RefreshDataAsync(string email, string token, bool notLogedIn)
    {
        if(notLogedIn)
            await FetchDataAsync(email, token, notLogedIn);

    }

    public async Task<ProductRes> FetchProductsAsync(string email)
    {
        try
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Get, $"http://localhost:8080/{email}/products");
            var response = await client.SendAsync(request);
            var httpResponseMessage = response.EnsureSuccessStatusCode();

            if (httpResponseMessage.IsSuccessStatusCode)
            {
                var responseBody = await response.Content.ReadAsStringAsync();
                ProductRes res = JsonConvert.DeserializeObject<ProductRes>(responseBody);
                return res;
            }

            return new ProductRes();
        }
        catch (Exception ex)
        {
            return new ProductRes();
        }
    }

    public async Task FetchDataAsync(string email, string token, bool login)
    {
        fetchItemsTask = FetchItemsAsync();
        if (login)
        {
            fetchUserTask = FetchUserAsync(email, token, login);
            fetchCartItemsTask = FetchCartItemsAsync(email, token, login);
            fetchOrdersTask = FetchOrdersAsync(email, token, login);

            fetchProductTask = FetchProductsAsync(email);

            await Task.WhenAll(fetchUserTask, fetchCartItemsTask, fetchOrdersTask);
        }
    }

    public async Task<Dictionary<string, object>> FetchUserAsync(string email, string token, bool notLogedIn)
    {
        if(notLogedIn)
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
              return null;
            }
        }
        else
        {
            return null;
        }
    }

    public async Task<HashSet<Item>> FetchItemsAsync()
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

            return new HashSet<Item>();
        }
        catch (Exception ex)
        {
            return new HashSet<Item>();

        }
    }

    private async Task<Cart?> FetchCartItemsAsync(string email, string token, bool notLogedIn)
    {
        if (notLogedIn)
        {
            try
            {
                var client = new HttpClient();
                var request = new HttpRequestMessage(HttpMethod.Get, $"http://localhost:8080/cart/{email}/view");
                request.Headers.Add("Authorization", $"Bearer {token}");
                var response = await client.SendAsync(request);
                response.EnsureSuccessStatusCode();
                var json = await response.Content.ReadAsStringAsync();
#pragma warning disable CS8603 // Possible null reference return.
                return JsonConvert.DeserializeObject<Cart>(json);
#pragma warning restore CS8603 // Possible null reference return.
            }
            catch (Exception ex)
            {
                return new Cart();
            }
        }
        else
        {
            return new Cart();
        }
    }


    private async Task<OrderRes> FetchOrdersAsync(string email, string token, bool notLogedIn)
    {
        if (notLogedIn)
        {
            try
            {
                var client = new HttpClient();
                var request = new HttpRequestMessage(HttpMethod.Get, $"http://localhost:8080/order/{email}/view");
                request.Headers.Add("Authorization", $"Bearer {token}");
                HttpResponseMessage response = null;
                try
                {
                    response = await client.SendAsync(request);
                }catch(Exception)
                {
                    return new OrderRes();
                }

                if (response == null) return null;

                HttpResponseMessage httpResponseMessage = response.EnsureSuccessStatusCode();

                if (httpResponseMessage.EnsureSuccessStatusCode().IsSuccessStatusCode)
                { 
                    var json = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<OrderRes>(json);
                }
                return new OrderRes();
            }
            catch (Exception ex)
            {
                return new OrderRes();
            }
        }
        else
        {
            return new OrderRes();
        }
    }
}