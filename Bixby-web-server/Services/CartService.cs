using Bixby_web_server.Models;
using MongoDB.Bson;
using MongoDB.Driver;

namespace Bixby_web_server.Services;

public class CartService
{
    private readonly IMongoCollection<Cart> _cartAndOrderCollection;

    public CartService()
    {
        var settings = MongoClientSettings.FromUrl(new MongoUrl(
            "mongodb+srv://geethaliyanage23:1dJz8r5mX6nfkoG6@cluster0.xdb3qmc.mongodb.net/?retryWrites=true&w=majority"));
        var client = new MongoClient(settings);

        var database = client.GetDatabase("BixByApp");
        _cartAndOrderCollection = database.GetCollection<Cart>("CartAndOrder");
    }

    public async Task<List<Cart>> GetAllCartAndOrders()
    {
        return await _cartAndOrderCollection.Find(_ => true).ToListAsync();
    }

    public async Task<IAsyncCursor<Cart>> GetAllCartAndOrders(string? email)
    {
        return await _cartAndOrderCollection.FindAsync(cartAndOrder => cartAndOrder.User == email);
    }

    public async Task<Cart> GetCartAndOrderById(ObjectId cartAndOrderId)
    {
        return await _cartAndOrderCollection.Find(cartAndOrder => cartAndOrder.Id == cartAndOrderId)
            .FirstOrDefaultAsync();
    }

    public async Task<Cart> GetCartAndOrderByItem(ObjectId ItemId)
    {
        return await _cartAndOrderCollection.Find(cartAndOrder => cartAndOrder.Item == ItemId)
            .FirstOrDefaultAsync();
    }

    public async Task CreateCartAndOrder(Cart cart)
    {
        await _cartAndOrderCollection.InsertOneAsync(cart);
    }

    public async void UpdateCartAndOrder(ObjectId cartAndOrderId, Cart updatedCart)
    {
        await _cartAndOrderCollection.ReplaceOneAsync(cartAndOrder => cartAndOrder.Id == cartAndOrderId,
            updatedCart);
    }

    public async void DeleteCartAndOrder(ObjectId cartAndOrderId)
    {
        await _cartAndOrderCollection.DeleteOneAsync(cartAndOrder => cartAndOrder.Id == cartAndOrderId);
    }
}