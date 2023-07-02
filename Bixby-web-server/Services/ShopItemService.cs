using Bixby_web_server.Models;
using BixbyShop_LK.Services;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BixbyShop_LK.Models.Item.Services
{
    public class ShopItemService
    {
        private readonly IMongoCollection<ShopItem> shopItemCollection;

        public ShopItemService()
        {
            var settings = MongoClientSettings.FromUrl(new MongoUrl("mongodb+srv://geethaliyanage23:1dJz8r5mX6nfkoG6@cluster0.xdb3qmc.mongodb.net/?retryWrites=true&w=majority"));
            var client = new MongoClient(settings);

            IMongoDatabase database = client.GetDatabase("BixByApp");
            this.shopItemCollection = database.GetCollection<ShopItem>("ShopItem");
        }

        public async Task<List<ShopItem>> GetAllShopItemsAsync()
        {
            return await shopItemCollection.Find(_ => true).ToListAsync();
        }

        public async Task<ShopItem> GetShopItemByIdAsync(ObjectId shopItemId)
        {
            return await shopItemCollection.Find(shopItem => shopItem.Id == shopItemId).FirstOrDefaultAsync();
        }

        public async Task<ShopItem> GetShopItemByIdAsync(string shopItemId)
        {
            return await shopItemCollection.Find(shopItem => shopItem.Id == new ObjectId(shopItemId)).FirstOrDefaultAsync();
        } 
        public async Task<ShopItem> GetShopItemByNameAsync(string name)
        {
            return await shopItemCollection.Find(shopItem => shopItem.Name == name).FirstOrDefaultAsync();
        }

        public async Task CreateShopItemAsync(ShopItem shopItem)
        {
            await shopItemCollection.InsertOneAsync(shopItem);
        }

        public async Task<bool> UpdateShopItemAsync(string shopItemId, ShopItem updatedShopItem)
        {
            var objectId = new ObjectId(shopItemId);
            var result = await shopItemCollection.ReplaceOneAsync(shopItem => shopItem.Id == objectId, updatedShopItem);
            return result.IsAcknowledged;
        }

        public async Task<bool> UpdateShopItemAsync(ObjectId shopItemId, ShopItem updatedShopItem)
        {
            var result = await shopItemCollection.ReplaceOneAsync(shopItem => shopItem.Id == shopItemId, updatedShopItem);
            return result.IsAcknowledged;
        }

        public async Task DeleteShopItemAsync(ObjectId shopItemId)
        {
            await shopItemCollection.DeleteOneAsync(shopItem => shopItem.Id == shopItemId);
        }
    }
}
