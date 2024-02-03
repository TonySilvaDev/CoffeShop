using CoffeShop.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CoffeShop.Controllers
{
    public class HomeController : Controller
    {
        private IProductRepository productRepository;
        public HomeController(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public IActionResult Index()
        {            
            return View(productRepository.GetTrendingProducts());
        }
    }
}
