using ConsoleApp1.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Entities
{
    public class RepairService : IRepairService
    {
        public void CheckVehicle(Vehicle vehicle)
        {
            Console.WriteLine("Checkingg..");
        }

        public void FixVehicle(Vehicle vehicle)
        {
            Console.WriteLine("Fixing..");
        }
    }
}
