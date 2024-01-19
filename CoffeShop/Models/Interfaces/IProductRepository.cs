namespace CoffeShop.Models.Interfaces
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAllProductos();
        IEnumerable<Product> GetTrendingProducts();
        Product GetProductDetail(int id);
    }
}
