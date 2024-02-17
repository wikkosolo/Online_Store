using Microsoft.AspNetCore.Mvc;
using Online_Store.Data.Repositories.Interfaces;

namespace Online_Store.Controllers;

public class HomeController(IUserInterface userService)
    : Controller
{
    private readonly IUserInterface _userService = userService;
    public IActionResult Index()
    {
        return View();
    }
}
