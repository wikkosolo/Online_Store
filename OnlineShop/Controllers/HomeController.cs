using Microsoft.AspNetCore.Mvc;

namespace OnlineShop.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
