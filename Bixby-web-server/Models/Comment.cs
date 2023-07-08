using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Bixby_web_server.Models;

public class CommentReq
{
    public string? UserComment { get; set; }
}

public class CommentRes
{
    public CommentRes(string id, string userComment, string user, string shopItem)
    {
        Id = id;
        UserComment = userComment;
        User = user;
        ShopItem = shopItem;
    }

    public String Id { get; set; }
    public String UserComment { get; set; }
    public String User { get; set; }
    public String ShopItem { get; set; }
}

public class Comment
{
    [BsonId] public ObjectId Id { get; set; }

    public string? UserComment { get; set; }
    public ObjectId User { get; set; }
    public ObjectId ShopItem { get; set; }
}