using Bixby_web_server.Models;
using BixbyShop_LK.Models.Comments;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;

namespace BixbyShop_LK.Services
{
    public class OrderService
    {
        private readonly IMongoCollection<Order> orderCollection;

        public OrderService(IMongoCollection<Order> orderCollection)
        {
            var settings = MongoClientSettings.FromUrl(new MongoUrl("mongodb+srv://geethaliyanage23:1dJz8r5mX6nfkoG6@cluster0.xdb3qmc.mongodb.net/?retryWrites=true&w=majority"));
            var client = new MongoClient(settings);

            IMongoDatabase database = client.GetDatabase("BixByApp");
            this.orderCollection = database.GetCollection<Order>("Order");
        }
        public List<Order> GetAllOrders()
        {
            return orderCollection.Find(_ => true).ToList();
        }

        public Order GetOrderById(ObjectId orderId)
        {
            return orderCollection.Find(order => order.Id == orderId).FirstOrDefault();
        }

        public void CreateOrder(Order order)
        {
            orderCollection.InsertOne(order);
        }

        public void UpdateOrder(ObjectId orderId, Order updatedOrder)
        {
            orderCollection.ReplaceOne(order => order.Id == orderId, updatedOrder);
        }

        public void DeleteOrder(ObjectId orderId)
        {
            orderCollection.DeleteOne(order => order.Id == orderId);
        }
    }
}