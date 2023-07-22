using Microsoft.EntityFrameworkCore;

namespace NdiayeShop.Models
{
    public class PieRepository:IPieRepository
    {
        private readonly NdiayeShopDbContext _ndiayeShopDbContext;

        public PieRepository(NdiayeShopDbContext ndiayeShopDbContext)
        {
            _ndiayeShopDbContext = ndiayeShopDbContext;
        }

        public IEnumerable<Pie> AllPies
        {
            get
            {
                return _ndiayeShopDbContext.Pies.Include(p => p.Category);
            }
        }

        public IEnumerable<Pie> PiesOfTheWeek
        {
            get
            {
                return _ndiayeShopDbContext.Pies.Include(p => p.Category).Where(p => p.IsPieOfTheWeek);
            }
        }

        public Pie? GetPieById(int pieId)
        {
                return _ndiayeShopDbContext.Pies.FirstOrDefault(p => p.PieId == pieId);   
        }


        public IEnumerable<Pie> SearchPies(string searchQuery)
        {
            return _ndiayeShopDbContext.Pies.Where(p => p.Name.Contains(searchQuery));
        }
    }
}
