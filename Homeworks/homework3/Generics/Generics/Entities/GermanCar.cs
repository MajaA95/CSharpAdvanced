﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.Entities
{
    public class GermanCar : BaseEntity
    {

        public override void Drive(string destinationName)
        {
            Console.WriteLine($"German car {Brand} is driving to {destinationName}");
        }
    }
}
