using Bixby_web_server.Models;
using MongoDB.Bson;
using MongoDB.Driver;

namespace BixbyShop_LK.Services;

public class OrderService
{
    private readonly IMongoCollection<Order> _orderCollection;

    public OrderService()
    {
        var settings = MongoClientSettings.FromUrl(new MongoUrl(
            "mongodb+srv://geethaliyanage23:1dJz8r5mX6nfkoG6@cluster0.xdb3qmc.mongodb.net/?retryWrites=true&w=majority"));
        var client = new MongoClient(settings);

        var database = client.GetDatabase("BixByApp");
        _orderCollection = database.GetCollection<Order>("Order");
    }

    public List<Order> GetAllOrders()
    {
        return _orderCollection.Find(_ => true).ToList();
    }

    public List<Order> GetAllOrders(string? email)
    {
        return _orderCollection.Find(_ => _.User == email).ToList();
    }

    public Order GetOrderById(ObjectId orderId)
    {
        return _orderCollection.Find(order => order.Id == orderId).FirstOrDefault();
    }

    public async Task CreateOrder(Order order)
    {
        await _orderCollection.InsertOneAsync(order);
    }

    public async Task CreateOrder(List<Order> orders)
    {
        await _orderCollection.InsertManyAsync(orders);
    }

    public void UpdateOrder(ObjectId orderId, Order updatedOrder)
    {
        _orderCollection.ReplaceOne(order => order.Id == orderId, updatedOrder);
    }

    public void DeleteOrder(ObjectId orderId)
    {
        _orderCollection.DeleteOne(order => order.Id == orderId);
    }
}