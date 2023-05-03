using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.Entities
{
    public class AmericanCar : BaseEntity
    {

        public override void Drive(string destinationName)
        {
            Console.WriteLine($"American car {Brand} is driving to {destinationName}");
        }
    }
}
