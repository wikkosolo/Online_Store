namespace OnlineShop.Data.Entities;
public class Products : BaseEntitiy
{
    public string Name { get; set; } = null!;
    public string Description { get; set; } = null!;
    public double Price { get; set; }
    public int SubcategoryId { get; set; }
    public SubCategorys Subcategories { get; set; }
}
