using CoffeShop.Models.Interfaces;

namespace CoffeShop.Models.Services
{
    public class ProductRepository : IProductRepository
    {
        private List<Product> ProductList = new List<Product>()
        {
            new Product{Id = 1, Name = "Americano", Price = 25, Detail = "The Americano cofee is a classic expresso-based drink", ImageUrl = "https://chilpa.mx/wp-content/uploads/2021/10/cafe_americano.jpg"},
            new Product{Id = 2, Name = "Mocha", Price = 25, Detail = "The Americano cofee is a classic expresso-based drink", ImageUrl = "https://chilpa.mx/wp-content/uploads/2021/10/cafe_americano.jpg"},
            new Product{Id = 3, Name = "Cafe au lait", Price = 25, Detail = "The Americano cofee is a classic expresso-based drink", ImageUrl = "https://chilpa.mx/wp-content/uploads/2021/10/cafe_americano.jpg"}
        };

        public IEnumerable<Product> GetAllProducts()
        {
            return ProductList;
        }

        public Product GetProductDetail(int id)
        {
            return ProductList.FirstOrDefault(p => p.Id == id);
        }

        public IEnumerable<Product> GetTrendingProducts()
        {
            return ProductList.Where(p => p.IsTrendingProduct);
        }
    }
}
