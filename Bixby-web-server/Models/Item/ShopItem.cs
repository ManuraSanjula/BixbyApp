using BixbyShop_LK.Models.Comments;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace BixbyShop_LK.Models.Item
{
    public class ShopItem
    {
        [BsonId] public ObjectId Id { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public int Price { get; set; }
        public Comment[] Comments { get; set; }
    }
}