using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace Bixby_web_server.Models
{
    public class CartAndOrder
    {
        [BsonId]
        public ObjectId Id { get; set; }
        public ObjectId Item { get; set; }
        public string? User { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
    }
}
