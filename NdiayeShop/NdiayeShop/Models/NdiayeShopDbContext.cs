using BethanysPieShop.Models;
using Microsoft.EntityFrameworkCore;

namespace NdiayeShop.Models
{
    public class NdiayeShopDbContext:DbContext
    {
        public NdiayeShopDbContext(DbContextOptions<NdiayeShopDbContext> options)
            :base(options)
        {
            
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Pie> Pies { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
    }
}
