namespace Bixby_web_server.Models;

public class UserShop
{
    public ShopItem Item { get; set; }
    public long Sells { get; set; }
    public long SellsPerDay { get; set; }
    public long SellsPerMoth { get; set; }
}