using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Entities.Interfaces
{
    public interface IRepairService
    {
        void CheckVehicle(Vehicle vehicle);
        void FixVehicle(Vehicle vehicle);
    }
}
