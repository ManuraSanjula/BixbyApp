using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;

namespace Bixby_web_server.Models
{
    public class ShopItemeq
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("price")]
        public int Price { get; set;}
    }

    public class UserInShopItem
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Pic { get; set; }
    }

    public class ShopAllShopItem
    {
        [BsonId] public ObjectId Id { get; set; }
        public string Name { get; set; }
        public String PicLowRes { get; set; }
    }

    public class ShopItem
    {
        [BsonId] public ObjectId Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public String[] PicsLowRes { get; set; } = { };
        public String[] PicsHighRes { get; set; } = { };
        public String PicHighRes { get; set; }
        public String PicLowRes { get; set; }
        public UserInShopItem publish { get; set; }
        public int likes { get; set; } = 0;
        public int dislikes { get; set; } = 0;
    }
}