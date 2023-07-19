using NdiayeShop.Models;

namespace NdiayeShop.ViewModels
{
    public class PieListViewModel
    {
        public IEnumerable<Pie> Pies { get; }
        public string? CurrentCategory { get; }


        public PieListViewModel(IEnumerable<Pie> pie,string? currentCategory)
        {
            Pies = pie;
            CurrentCategory = currentCategory;
        }
    }

}
