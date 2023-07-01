using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace Bixby_web_server.Models
{
    public class Comment
    {
        [BsonId]
        public ObjectId Id { get; set; }
        public string UserComment { get; set; }
        public User User { get; set; }
        public ShopItem ShopItem { get; set; }
    }
}
