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

        public async Task AddProduct(string? user, ObjectId shopItem)
        {
            UserShop userShop = new UserShop();
            userShop.User = user;
            userShop.Item = shopItem;

            await this.UserShopCollection.InsertOneAsync(userShop);
        }

        public async Task ProductUpdateByItemId(ObjectId id, UserShop userShop)
        {
            await this.UserShopCollection.ReplaceOneAsync(us=> us.Id == id, userShop);
        }

        public async Task<UserShop> GetProductByItemId(ObjectId id)
        {
            return await this.UserShopCollection.Find(u => u.Item == id).FirstOrDefaultAsync();
        }

        public async Task<UserShop> GetProductByUserAndShopItem(ObjectId shopItem, string email)
        {
            return await this.UserShopCollection.Find(u => u.Item == shopItem && u.User == email).FirstOrDefaultAsync();
        }
        public async Task<List<UserShop>> GetProductByUserEmail(string? email)
        {
            return await this.UserShopCollection.Find(u => u.User == email).ToListAsync();
        }
        public async Task<UserShop> GetProduct(ObjectId id)
        {
            return await this.UserShopCollection.Find(u => u.Id == id).FirstOrDefaultAsync();
        }
        
        public async Task DeleteProductByEmailAndShopId(String email,ObjectId id)
        {
             await this.UserShopCollection.DeleteOneAsync(u => u.User == email && u.Item == id);
        }

        public async Task<List<UserShop>> GetAllProducts()
        {
            return await this.UserShopCollection.Find(_ => true).ToListAsync();
        }

        public async Task<long> GetTotalOrders(ObjectId id)
        {
            var userShop = await GetProduct(id);
            // ReSharper disable once ConditionIsAlwaysTrueOrFalseAccordingToNullableAPIContract
            if (userShop != null)
            {
                return userShop.TotalSuccessfulOrders;
            }
            return 0;
        }

        public async Task<long> GetTotalViews(ObjectId id)
        {
            var userShop = await GetProduct(id);
            // ReSharper disable once ConditionIsAlwaysTrueOrFalseAccordingToNullableAPIContract
            if (userShop != null)
            {
                return userShop.TotalViews;
            }
            return 0;
        }

        // Add more methods as needed

    }
}
