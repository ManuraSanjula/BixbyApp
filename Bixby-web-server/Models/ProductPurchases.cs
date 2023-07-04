using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace Bixby_web_server.Models
{
    public class ProductPurchases
    {
        [BsonId] public ObjectId Id { get; set; }
        public ObjectId orderId { get; set; }
        public ObjectId cutomerId { get; set; }
        public String ownerId { get; set; }
        public bool isDeliverd { get; set; } = false;
        public bool isRefund { get; set; } = false;
    }
}
