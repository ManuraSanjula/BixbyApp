using Bixby_web_server.Models;
using MongoDB.Bson;
using MongoDB.Driver;

namespace Bixby_web_server.Services
{
    public class CartAndOrderService
    {
        private readonly IMongoCollection<CartAndOrder> _cartAndOrderCollection;

        public CartAndOrderService()
        {
            var settings = MongoClientSettings.FromUrl(new MongoUrl("mongodb+srv://geethaliyanage23:1dJz8r5mX6nfkoG6@cluster0.xdb3qmc.mongodb.net/?retryWrites=true&w=majority"));
            var client = new MongoClient(settings);

            IMongoDatabase database = client.GetDatabase("BixByApp");
            this._cartAndOrderCollection = database.GetCollection<CartAndOrder>("CartAndOrder");
        }
        public async Task<List<CartAndOrder>> GetAllCartAndOrders()
        {
            return await _cartAndOrderCollection.Find(_ => true).ToListAsync();
        }
        public async Task<IAsyncCursor<CartAndOrder>> GetAllCartAndOrders(string? email)
        {
            return await _cartAndOrderCollection.FindAsync(cartAndOrder => cartAndOrder.User == email);
        }   
        
        public async Task<CartAndOrder> GetCartAndOrderById(ObjectId cartAndOrderId)
        {
            return await _cartAndOrderCollection.Find(cartAndOrder => cartAndOrder.Id == cartAndOrderId).FirstOrDefaultAsync();
        }

        public async Task CreateCartAndOrder(CartAndOrder cartAndOrder)
        {
           await _cartAndOrderCollection.InsertOneAsync(cartAndOrder);
        }

        public async void UpdateCartAndOrder(ObjectId cartAndOrderId, CartAndOrder updatedCartAndOrder)
        {
            await _cartAndOrderCollection.ReplaceOneAsync(cartAndOrder => cartAndOrder.Id == cartAndOrderId, updatedCartAndOrder);
        }

        public async void DeleteCartAndOrder(ObjectId cartAndOrderId)
        {
            await _cartAndOrderCollection.DeleteOneAsync(cartAndOrder => cartAndOrder.Id == cartAndOrderId);
        }
    }
}