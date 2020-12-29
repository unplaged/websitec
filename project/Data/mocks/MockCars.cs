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
                        name = "Минимализм", 
                        shortDesc = "Максимум простора и минимум ненужных вещей", 
                        longDesc = "", 
                        img = "/img/minimalizm.jpg",
                        isFavourite = true, 
                        available = true, 
                        Category = _categoryCars.AllCategories.First()
                    },
                     new Car {
                        name = "Стиль Кантри",
                        shortDesc = "Использование преимущественно натуральных материалов без ярких контрастов.",
                        longDesc = "",
                        img = "/img/kantri.jpg",
                        isFavourite = false,
                        available = true,
                        Category = _categoryCars.AllCategories.Last()
                    },
                     new Car {
                        name = "Конструктивизм",
                        shortDesc = "Простота, рациональность и практически полное отсутствие вычурного декора",
                        longDesc = "",
                        img = "/img/konstruct.jpg",
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
