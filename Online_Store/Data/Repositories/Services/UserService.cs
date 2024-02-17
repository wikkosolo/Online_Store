using Online_Store.Data.Repositories.Interfaces;
using Online_Store.Models;

namespace Online_Store.Data.Repositories.Services;

public class UserService(UserDbContext context)
    : IUserInterface
{
    private readonly UserDbContext _context = context;

    public void AddUser(Users user)
    {
        _context.Users.Add(user);
        _context.SaveChanges();
    }

    public void DeleteUser(int id)
    {
        var user = _context.Users.Find(id);
        _context.Users.Remove(user);
        _context.SaveChanges();
    }

    public List<Users> GetAllUsers()
    {
        return _context.Users.ToList();
    }

    public Users GetUserById(int id)
    {
        return _context.Users.FirstOrDefault(p => p.Id == id);
    }

    public void UpdateUser(Users user)
    {
        _context.Users.Update(user);
        _context.SaveChanges();
    }

    public bool UserExists(int id)
    {
        return _context.Users.Any(e => e.Id == id);
    }
}
