using Microsoft.EntityFrameworkCore;
using Online_Store.Models;

namespace Online_Store.Data;

public class UserDbContext : DbContext
{

    public UserDbContext(DbContextOptions<UserDbContext> options) : base(options)
    {
        Database.EnsureCreated();
    }

    public DbSet<Users> Users { get; set; }
}

