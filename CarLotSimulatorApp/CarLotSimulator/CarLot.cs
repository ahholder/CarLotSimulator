﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    public class CarLot
    {
        public List<Car> Stock { get; set; } = new List<Car>();
        public static int NumberOfCars { get; set; }
    }
}
