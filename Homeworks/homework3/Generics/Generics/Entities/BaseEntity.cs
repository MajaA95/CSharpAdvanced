using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.Entities
{
    public abstract class BaseEntity
    {
        public string Id { get; set; } = string.Empty;
        public string Brand { get; set; } = string.Empty;
        public string MaxSpeed { get; set; } = string.Empty;
        public string HorsePower { get; set; } = string.Empty;
        public string FuelType { get; set; } = string.Empty;

        public abstract void Drive(string destinationName);
    }

}
