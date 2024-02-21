namespace OnlineShop.Data.Entities
{
    public class OrderItmes : BaseEntitiy
    {
        public int ProductId {  get; set; }
        public int Amout { get; set; }
        public int TotalPrice { get; set; }
        public int OrderId {  get; set; }
        public Products Product {  get; set; } = new();
        public Orders Order { get; set; }
    }
}
