using BixbyShop_LK.Models.Item;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace BixbyShop_LK.Models.Order
{
    public class CartAndOrder
    {

        [BsonId]
        public ObjectId Id { get; set; }
        public ShopItem Item { get; set; }
        public User User { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
    }
}
