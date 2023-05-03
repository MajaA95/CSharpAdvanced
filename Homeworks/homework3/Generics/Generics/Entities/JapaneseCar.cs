﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.Entities
{
    public class JapaneseCar : BaseEntity
    {
        public override void Drive(string destinationName)
        {
            Console.WriteLine($"Japanese car {Brand} is driving to {destinationName}");
        }
    }
}
