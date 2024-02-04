using CoffeShop.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CoffeShop.Controllers
{
    public class ShoppingCartController : Controller
    {
        private IShoppingCartRepository shoppingCartRepository;
        private IProductRepository productRepository;
        public ShoppingCartController(IShoppingCartRepository shoppingCartRepository, IProductRepository productRepository)
        {
            this.shoppingCartRepository = shoppingCartRepository;
            this.productRepository = productRepository;
        }

        public IActionResult Index()
        {
            var items = shoppingCartRepository.GetShoppingCartItems();
            shoppingCartRepository.ShoppingCartItems = items;
            ViewBag.CartTotal = shoppingCartRepository.GetShoppingCartTotal();
            return View(items);
        }

        public RedirectToActionResult AddToShoppingCart(int id)
        {
            var product = productRepository.GetAllProducts().FirstOrDefault(p => p.Id == id);
            if(product != null)
            {
                shoppingCartRepository.AddToCart(product);
                var cartCount = shoppingCartRepository.GetShoppingCartItems().Count();
                HttpContext.Session.SetInt32("CartCount", cartCount);
            }

            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromShoppingCart(int id)
        {
            var product = productRepository.GetAllProducts().FirstOrDefault(p => p.Id == id);
            if (product != null)
            {
                shoppingCartRepository.RemoveFromCart(product);
                var cartCount = shoppingCartRepository.GetShoppingCartItems().Count();
                HttpContext.Session.SetInt32("CartCount", cartCount);
            }

            return RedirectToAction("Index");
        }
    }
}
