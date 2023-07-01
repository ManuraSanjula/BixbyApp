using Bixby_web_server.Models;
using BixbyShop_LK.Services;
using MongoDB.Bson;
using MongoDB.Driver;

namespace BixbyShop_LK.Models.Order.Services
{
    public class CartAndOrderService
    {
        private readonly IMongoCollection<CartAndOrder> cartAndOrderCollection;

        public CartAndOrderService()
        {
            var settings = MongoClientSettings.FromUrl(new MongoUrl("mongodb+srv://geethaliyanage23:1dJz8r5mX6nfkoG6@cluster0.xdb3qmc.mongodb.net/?retryWrites=true&w=majority"));
            var client = new MongoClient(settings);

            IMongoDatabase database = client.GetDatabase("BixByApp");
            this.cartAndOrderCollection = database.GetCollection<CartAndOrder>("CartAndOrder");
        }
        public List<CartAndOrder> GetAllCartAndOrders()
        {
            return cartAndOrderCollection.Find(_ => true).ToList();
        }

        public CartAndOrder GetCartAndOrderById(ObjectId cartAndOrderId)
        {
            return cartAndOrderCollection.Find(cartAndOrder => cartAndOrder.Id == cartAndOrderId).FirstOrDefault();
        }

        public void CreateCartAndOrder(CartAndOrder cartAndOrder)
        {
            cartAndOrderCollection.InsertOne(cartAndOrder);
        }

        public void UpdateCartAndOrder(ObjectId cartAndOrderId, CartAndOrder updatedCartAndOrder)
        {
            cartAndOrderCollection.ReplaceOne(cartAndOrder => cartAndOrder.Id == cartAndOrderId, updatedCartAndOrder);
        }

        public void DeleteCartAndOrder(ObjectId cartAndOrderId)
        {
            cartAndOrderCollection.DeleteOne(cartAndOrder => cartAndOrder.Id == cartAndOrderId);
        }
    }
}