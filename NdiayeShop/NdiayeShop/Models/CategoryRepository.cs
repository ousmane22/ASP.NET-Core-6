namespace NdiayeShop.Models
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly NdiayeShopDbContext _ndiayeShopDbContext;

        public CategoryRepository(NdiayeShopDbContext ndiayeShopDbContext)
        {
           _ndiayeShopDbContext = ndiayeShopDbContext;
        }
        public IEnumerable<Category> AllCategories => 
            _ndiayeShopDbContext.Categories.OrderBy(c => c.CategoryName);
    }
}
