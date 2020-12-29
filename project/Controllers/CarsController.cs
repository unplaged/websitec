using Microsoft.AspNetCore.Mvc;
using project.Data.Interfaces;
using project.ViewModels;

namespace project.Controllers
{
    public class CarsController : Controller 
    {

        private readonly IAllCars _allCars;
        private readonly ICarsCategory _allCategories;

        public CarsController(IAllCars iAllCars, ICarsCategory iCarsCat)
        {
            _allCars = iAllCars;
            _allCategories = iCarsCat;
        }

        public ViewResult List()
        {
            ViewBag.Title = "AllDesigns";
            CarsListViewModel obj = new CarsListViewModel();
            obj.allCars = _allCars.Cars;
            obj.currCategory = "Description";
            return View(obj);
        }

    }
}
