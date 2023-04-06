using Interfaces.InterfacesF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Classes
{
    public class Dog : AnimalAbstract, IDog
    {
        public bool IsWithPedigree { get; set; }

        public Dog(string name, int age, bool isWithPedigree) : base(name, age)
        {
            IsWithPedigree = isWithPedigree;
        }

        public void Bark()
        {
            Console.WriteLine($"{Name} is barking AW AW AW");
        }

        public override void PrintAnimal()
        {
            Console.WriteLine($"This is {Name}, and it is {Age} years old");
        }
    }
}
