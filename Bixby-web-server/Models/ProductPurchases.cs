using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Bixby_web_server.Models;

public class ProductPurchases
{
    [BsonId] public ObjectId Id { get; set; }
    public ObjectId orderId { get; set; }
    public ObjectId cutomerId { get; set; }
    public string ownerId { get; set; }
    public bool isDeliverd { get; set; } = false;
    public bool isRefund { get; set; } = false;
}