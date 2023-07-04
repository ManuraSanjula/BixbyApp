using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;

namespace Bixby_web_server.Models
{
    public class UserShop
    {
        [BsonId]
        public ObjectId Id { get; set; }
        public string? User { get; set; }
        public ObjectId Item { get; set; }
        public long Sells { get; set; } = 0;
        public long SellsPerDay { get; set; } = 0;
        public long SellsPerMonth { get; set; } = 0;
        public long temp_SellsPerDay { get; set; } = 0;
        public long temp_SellsPerMonth { get; set; } = 0;
        public long TotalSuccessfulOrders { get; set; } = 0;
        public long TotalRefunds { get; set; } = 0;
        public long TotalViews { get; set; } = 0;
        public DateTime LastUpdated { get; set; } = DateTime.Now;
    }
}
