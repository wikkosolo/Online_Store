using System.Data;

namespace OnlineShop.Data.Entities;
public class Orders : BaseEntitiy
{
    public int UserId { get; set; }
    public DateTime Date { get; set; }
    public int TotalPrice {  get; set; }
    public Users User {  get; set; }
    public ICollection<OrderItmes> OrderItmes {  get; set; }
}