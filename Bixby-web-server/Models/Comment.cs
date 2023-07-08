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

    public string Id { get; set; }
    public string UserComment { get; set; }
    public string User { get; set; }
    public string ShopItem { get; set; }
}

public class Comment
{
    [BsonId] public ObjectId Id { get; set; }

    public string? UserComment { get; set; }
    public ObjectId User { get; set; }
    public ObjectId ShopItem { get; set; }
}