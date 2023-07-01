using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Bixby_web_server.Models
{
    public class ShopItem
    {
        [BsonId] public ObjectId Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public Comment[] Comments { get; set; }
        public User publish { get; set; }
        public int likes { get; set; }
        public int dislikes { get; set; }
    }
}