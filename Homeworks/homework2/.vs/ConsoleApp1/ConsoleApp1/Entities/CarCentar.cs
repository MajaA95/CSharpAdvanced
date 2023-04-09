using ConsoleApp1.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Entities
{
    public class CarCenter : ICarWash,IGasPump,IRepairService
    {
        public void CheckVehicle(Vehicle vehicle)
        {
            Console.WriteLine("Checking..");
        }

        public void FixVehicle(Vehicle vehicle)
        {
            Console.WriteLine("Fixing..");
        }

        public void PumpGas(Vehicle vehicle)
        {
            Console.WriteLine("Filling..");
        }

        public void WashCar(Car car)
        {
            Console.WriteLine("Washing car..");
        }

        public void WashTrailer(Truck truck)
        {
            Console.WriteLine("Washing trailer..");
        }
    }
}
