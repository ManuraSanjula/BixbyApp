using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace Bixby_web_server.Models
{
    public class UserShop
    {
        [BsonId]
        public ObjectId Id { get; set; }
        public string? User { get; set; }
        public ObjectId Item { get; set; }
        public long TotalSuccessfulOrders { get; set; } = 0;  // Updated field name
        public long TotalRefunds { get; set; } = 0;
        public long TotalViews { get; set; } = 0;
        public DateTime LastUpdated { get; set; } = DateTime.Now;

    }
}
