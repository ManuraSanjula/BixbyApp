using Bixby_web_server.Models;
using BixbyShop_LK.Services;
using MongoDB.Bson;
using MongoDB.Driver;

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
        public List<ShopItem> GetAllShopItems()
        {
            return shopItemCollection.Find(_ => true).ToList();
        }

        public ShopItem GetShopItemById(ObjectId shopItemId)
        {
            return shopItemCollection.Find(shopItem => shopItem.Id == shopItemId).FirstOrDefault();
        }

        public void CreateShopItem(ShopItem shopItem)
        {
            shopItemCollection.InsertOne(shopItem);
        }

        public void UpdateShopItem(string shopItemId, ShopItem updatedShopItem)
        {
            var objectId = new ObjectId(shopItemId);
            shopItemCollection.ReplaceOne(shopItem => shopItem.Id == objectId, updatedShopItem);
        }

        public void DeleteShopItem(ObjectId shopItemId)
        {
            shopItemCollection.DeleteOne(shopItem => shopItem.Id == shopItemId);
        }
    }
}