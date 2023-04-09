using ConsoleApp1.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Entities
{
    public class CarWash : ICarWash
    {
        public void WashCar(Car car)
        {
            Console.WriteLine($"Washing car..");
        }


        public void WashTrailer(Truck truck)
        {
            Console.WriteLine("Washing truck..");
           
        }
    }

    
}
