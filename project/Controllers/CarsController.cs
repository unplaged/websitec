﻿using Microsoft.AspNetCore.Mvc;
using project.Data.Interfaces;
using project.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
            obj.currCategory = "Дизайны";
            return View(obj);
        }

    }
}
