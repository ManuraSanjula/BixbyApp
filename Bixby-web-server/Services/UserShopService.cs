using Bixby_web_server.Models;
using MongoDB.Bson;
using MongoDB.Driver;

namespace Bixby_web_server.Services
{
    public class UserShopService
    {
        private readonly IMongoCollection<UserShop> UserShopCollection;

        public UserShopService()
        {
            var settings = MongoClientSettings.FromUrl(new MongoUrl("mongodb+srv://geethaliyanage23:1dJz8r5mX6nfkoG6@cluster0.xdb3qmc.mongodb.net/?retryWrites=true&w=majority"));
            var client = new MongoClient(settings);

            IMongoDatabase database = client.GetDatabase("BixByApp");
            this.UserShopCollection = database.GetCollection<UserShop>("UserShop");
        }

        public async Task AddProduct(ObjectId user, ObjectId shopItem)
        {
            UserShop userShop = new UserShop();
            userShop.Id = user;
            userShop.Item = shopItem;

            await this.UserShopCollection.InsertOneAsync(userShop);
        }

        public async Task<UserShop> GetProduct(ObjectId id)
        {
            return await this.UserShopCollection.Find(u => u.Id == id).FirstOrDefaultAsync();
        }

        public async Task<List<UserShop>> GetAllProducts()
        {
            return await this.UserShopCollection.Find(_ => true).ToListAsync();
        }

        public async Task<long> GetTotalOrders(ObjectId id)
        {
            var userShop = await GetProduct(id);
            if (userShop != null)
            {
                return userShop.TotalOrders;
            }
            return 0;
        }

        public async Task<long> GetTotalViews(ObjectId id)
        {
            var userShop = await GetProduct(id);
            if (userShop != null)
            {
                return userShop.TotalViews;
            }
            return 0;
        }

        // Add more methods as needed

    }
}
