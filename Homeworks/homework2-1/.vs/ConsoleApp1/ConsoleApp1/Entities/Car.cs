﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ConsoleApp1.Entities
{
    public class Car : Vehicle
    {
        public Car(string model, int year) : base(model, year)
        {
        }

        public override void Drive()
        {
            Console.WriteLine("Driving car..");
        }
    }
}
