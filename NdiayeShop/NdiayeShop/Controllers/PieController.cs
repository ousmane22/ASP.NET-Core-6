using NdiayeShop.Models;
using Microsoft.AspNetCore.Mvc;
using NdiayeShop.ViewModels;

namespace NdiayeShop.Controllers
{
    public class PieController:Controller
    {
        private readonly IPieRepository _pieRepository;
        private readonly ICategoryRepository _categoryRepository;

        public PieController(IPieRepository pieRepository , ICategoryRepository categoryRepository)
        {
            _pieRepository = pieRepository;
           _categoryRepository = categoryRepository;
        }


        public IActionResult List()
        {
            //ViewBag.currentCategory = "Cheese";
            //return View(_pieRepository.AllPies);

            PieListViewModel pieListViewModel = new PieListViewModel
                (_pieRepository.AllPies, "Cake Chess");
            return View(pieListViewModel);
        }

        public IActionResult Details(int id)
        {
          var selectedPie =   _pieRepository.GetPieById(id);
            if (selectedPie == null)
                return NotFound();
            return View(selectedPie);
        }
    }
}
