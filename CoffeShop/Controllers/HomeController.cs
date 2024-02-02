using Microsoft.AspNetCore.Mvc;

namespace CoffeShop.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
