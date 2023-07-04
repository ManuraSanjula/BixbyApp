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

        public string? Email { get; set; }

        public string Pic { get; set; }
    }

    public class ShopAllShopItem
    {
        public ObjectId Id { get; set; }

        public string Name { get; set; }
        public String PicLowRes { get; set; }
    }

    public class ShopItem
    {
        [BsonId] public ObjectId Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public long Rating { get; set; }
        public long TotalComments { get; set; }
        public int Price { get; set; }
        public String[] PicsLowRes { get; set; } = { "default-low-res-pic.png" };
        public String[] PicsHighRes { get; set; } = { "default-high-res-pic.png" };
        public String PicHighRes { get; set; } = "default-high-res-pic.png";
        public String PicLowRes { get; set; } = "default-low-res-pic.png";
        public UserInShopItem publish { get; set; }
        public int loveThisProduct { get; set; } = 0;
    }
}