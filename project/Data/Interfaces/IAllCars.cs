﻿using project.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace project.Data.Interfaces
{
    interface IAllCars
    {

        IEnumerable<Car> Cars { get; }
        Car getObjectCar(int carId);

    }
}