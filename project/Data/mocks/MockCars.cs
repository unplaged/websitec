using project.Data.Interfaces;
using project.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace project.Data.mocks
{
    public class MockCars : IAllCars
    {

        private readonly ICarsCategory _categoryCars = new MockCategory();

        public IEnumerable<Car> Cars
        {
            get
            {
                return new List<Car>
                {
                    new Car { 
                        name = "MDesign", 
                        shortDesc = "s1", 
                        longDesc = "", 
                        img = "", 
                        price = 30000, 
                        isFavourite = true, 
                        available = true, 
                        Category = _categoryCars.AllCategories.First()
                    },
                     new Car {
                        name = "XDesign",
                        shortDesc = "s2",
                        longDesc = "",
                        img = "",
                        price = 40000,
                        isFavourite = false,
                        available = true,
                        Category = _categoryCars.AllCategories.Last()
                    },
                     new Car {
                        name = "VDesign",
                        shortDesc = "s2",
                        longDesc = "",
                        img = "",
                        price = 50000,
                        isFavourite = true,
                        available = true,
                        Category = _categoryCars.AllCategories.Last()
                    },
                };
            }
        }
        public IEnumerable<Car> getFavCars { get; set; }
        public Car getObjectCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
