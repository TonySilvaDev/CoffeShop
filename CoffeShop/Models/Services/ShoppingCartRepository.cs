using CoffeShop.Data;
using CoffeShop.Models.Interfaces;

namespace CoffeShop.Models.Services
{
    public class ShoppingCartRepository : IShoppingCartRepository
    {
        private CoffeShopDbContext dbContext;
        public ShoppingCartRepository(CoffeShopDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public List<ShoppingCartItem>? ShoppingCartItems { get; set; }

        public void AddToCart(Product product)
        {
            throw new NotImplementedException();
        }

        public void ClearCart()
        {
            throw new NotImplementedException();
        }

        public List<ShoppingCartItem> GetShoppingCartItems()
        {
            throw new NotImplementedException();
        }

        public decimal GetShoppingCartTotal()
        {
            throw new NotImplementedException();
        }

        public int RemoveFromCart(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
