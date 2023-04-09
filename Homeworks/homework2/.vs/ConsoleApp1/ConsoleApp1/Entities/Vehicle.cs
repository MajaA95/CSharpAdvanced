using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Entities
{
    public abstract class Vehicle
    {
        public string Model { get; set; }
        public int Year { get; set; }

        public Vehicle(string model, int year)
        {
            Model = model;
            Year = year;
        }

        public abstract void Drive();
    }
}
