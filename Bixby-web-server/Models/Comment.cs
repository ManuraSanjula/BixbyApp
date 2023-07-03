using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace Bixby_web_server.Models
{
    public class CommentReq
    {
        public string? UserComment { get; set; }
        public int rate { get; set; }

    }
    public class Comment
    {
        [BsonId]
        public ObjectId Id { get; set; }
        public string? UserComment { get; set; }
        public ObjectId User { get; set; }
        public ObjectId ShopItem { get; set; }
        public int rate { get; set; }   
    }
}
