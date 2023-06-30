using BixbyShop_LK.Models.Item;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System.ComponentModel.DataAnnotations;

namespace BixbyShop_LK.Models.Comments
{
    public class Comment
    {
        [BsonId]
        public ObjectId Id { get; set; }
        public String UserComment { get; set; }
        public User User { get; set; }
        public ShopItem ShopItem { get; set; }
    }
}
