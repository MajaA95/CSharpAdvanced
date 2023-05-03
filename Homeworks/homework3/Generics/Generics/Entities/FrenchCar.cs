using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.Entities
{
    public class FrenchCar : BaseEntity
    {
        public override void Drive(string destinationName)
        {
            Console.WriteLine($"French car {Brand} is driving to {destinationName}");
        }
    }
}
