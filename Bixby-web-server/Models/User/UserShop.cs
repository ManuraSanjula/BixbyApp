using BixbyShop_LK.Models.Item;

namespace BixbyShop_LK;

public class UserShop
{
    public ShopItem Item { get; set; }
    public long Sells { get; set; }
    public long SellsPerDay { get; set; }
    public long SellsPerMoth { get; set; }
}