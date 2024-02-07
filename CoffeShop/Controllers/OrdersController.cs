using CoffeShop.Models;
using CoffeShop.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CoffeShop.Controllers
{
    public class OrdersController : Controller
    {
        private IOrderRepository orderRepository;
        private IShoppingCartRepository shoppingCartRepository;
        public OrdersController(IOrderRepository orderRepository, IShoppingCartRepository shoppingCartRepository)
        {
            this.orderRepository = orderRepository;
            this.shoppingCartRepository = shoppingCartRepository;
        }

        public IActionResult Checkout()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Checkout(Order order)
        {
            orderRepository.PlaceOrder(order);
            shoppingCartRepository.ClearCart();
            return RedirectToAction("CheckoutComplete");
        }

        public IActionResult CheckoutComplete()
        {
            return View();
        }
    }
}
