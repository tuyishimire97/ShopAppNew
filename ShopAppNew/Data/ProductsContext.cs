using Microsoft.EntityFrameworkCore;

namespace ShopAppNew.Data
{
    public class ProductsContext : DbContext
    {
        public ProductsContext(DbContextOptions<ProductsContext> options): base(options) {}
        public DbSet<Models.Product> Movies { get; set; }
    }
}