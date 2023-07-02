using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace Bixby_web_server.Models;

public class UserShop
{
    [BsonId]
    public ObjectId Id { get; set; }
    public ObjectId User { get; set; }
    public ObjectId Item { get; set; }
    public long Sells { get; set; } = 0;
    public long SellsPerDay { get; set; } = 0;
    public long SellsPerMoth { get; set; } = 0;
    public long TotalOrders { get; set; } = 0;
    public long TotalRefunds { get; set; } = 0;
    public long TotalViews { get; set; } = 0;   
}