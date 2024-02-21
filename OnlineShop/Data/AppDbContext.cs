using Microsoft.EntityFrameworkCore;
using OnlineShop.Data.Entities;

namespace OnlineShop.Data;
public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    DbSet<Category> Categories { get; set; }
    DbSet<Images> Images {  get; set; }
    DbSet<OrderItmes> OrderItmes { get; set; }
    DbSet<Orders> Orders { get; set; }
    DbSet<Products> Products { get; set; }
    DbSet<SubCategorys> SubCategories { get; set; }
    DbSet<Users> Users { get; set; }
}

