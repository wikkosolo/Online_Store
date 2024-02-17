using Online_Store.Models;

namespace Online_Store.Data.Repositories.Interfaces;

public interface IUserInterface
{
    List<Users> GetAllUsers();
    Users GetUserById(int id);
    void AddUser(Users user);
    void UpdateUser(Users user);
    void DeleteUser(int id);
    bool UserExists(int id);
}
