using CoffeShop.Models;
using Microsoft.EntityFrameworkCore;

namespace CoffeShop.Data
{
    public class CoffeShopDbContext : DbContext
    {
        public CoffeShopDbContext(DbContextOptions<CoffeShopDbContext> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }

    }
}
