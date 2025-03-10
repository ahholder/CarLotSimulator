﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    public class Car
    {
        //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
        //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
        //The methods should take one string parameter: the respective noise property
        public Car()
        {
            CarLot.NumberOfCars += 1;
            Console.WriteLine($"{CarLot.NumberOfCars} cars now currently in the lot!");
        }
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDriveable { get; set; }
        public void MakeEngineNoise(string EngineNoise)
        {
            Console.WriteLine(EngineNoise+"!");
        }
        public void MakeHonkNoise(string HonkNoise)
        {
            Console.WriteLine(HonkNoise + "!");
        }
    }
}
