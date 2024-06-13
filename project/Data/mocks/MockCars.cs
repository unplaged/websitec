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
                        name = "Нейросеть Andrenaline", 
                        shortDesc = "Новая мощная нейронка Andrenaline, useadrenaline.com которая помогает проверить код на ошибки и даёт подробные рекомендации по исправлению.\r\n\r\nСервис работает прямо в браузере, скоро обещают сделать отдельное расширение для VSCode.\r\n", 
                        longDesc = "", 
                        img = "/img/125.mp4",
                        isFavourite = true, 
                        available = true, 
                        Category = _categoryCars.AllCategories.First()
                    },
                     new Car {
                        name = "Stable Doodle",
                        shortDesc = "Stable Doodle — это новый раздел Stability AI, который из обычного черно-белого эскиза может сделать самостоятельное изображение. \r\n\r\nНа выбор предлагается несколько стилей: фэнтези-арт, оригами, изометрия, комиксы, digital-искусство и много чего другого.\r\n\r\nКартинки составляются по текстовому запросу, а процесс занимает не более 5 секунд.",
                        longDesc = "",
                        img = "/img/124.mp4",
                        isFavourite = false,
                        available = true,
                        Category = _categoryCars.AllCategories.Last()
                    },
                     new Car {
                        name = "AI Prompt",
                        shortDesc = "AI Prompt, spline.design/ai — это нейросеть от Spline, где можно за несколько секунд создать 3D-фигуры, фактуру и анимированные сцены. \r\n\r\nРаботает стандартно — вводим текстовый запрос и получаем результат",
                        longDesc = "",
                        img = "/img/126.mp4",
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
