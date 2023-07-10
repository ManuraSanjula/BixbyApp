using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Bixby_web_server.Models;

public class Cart
{
    [BsonId] public ObjectId Id { get; set; }

    public ObjectId Item { get; set; }
    public string? User { get; set; }
    public int Quantity { get; set; }
    public int Price { get; set; }
   
}