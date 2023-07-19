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
        public DbSet<Pie>  Pies { get; set; }
    }
}
