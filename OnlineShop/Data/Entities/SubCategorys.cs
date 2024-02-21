namespace OnlineShop.Data.Entities
{
    public class SubCategorys :BaseEntitiy
    {
        public string Name { get; set; } = null!;
        public int CategoryId { get; set; }
        public Category Categorys { get; set; }
    }
}
