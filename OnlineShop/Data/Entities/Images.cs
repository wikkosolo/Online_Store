namespace OnlineShop.Data.Entities;
public class Images : BaseEntitiy
{
    public string Url { get; set; } = null!;
    public int ProductId { get; set; }
    public Products Product { get; set; } = null!;
}