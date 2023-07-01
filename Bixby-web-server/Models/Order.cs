using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Bixby_web_server.Models
{
    public class Order
    {
        [BsonId]
        public ObjectId Id { get; set; }
        public CartAndOrder[] Items { get; set; }
        public User User { get; set; }
        public int Price { get; set; }
    }
}
