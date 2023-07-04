using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Bixby_web_server.Models
{
    public class Order
    {
        [BsonId]
        public ObjectId Id { get; set; }
        public ObjectId[] Items { get; set; }
        public string? User { get; set; }
        public int Price { get; set; }
        
        public bool Confirm { get; set; }
    }
}
