using Interfaces.InterfacesF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Classes
{
    public class Cat : AnimalAbstract, ICat
    {
        public Cat(string name, int age) : base(name, age)
        {
        }

        public void Eat(string food)
        {
            Console.WriteLine($"My cat {Name} wants to eat {food}"); 
        }

        public override void PrintAnimal()
        {
            Console.WriteLine($"This is my cat {Name}, and it is {Age} years old");
        }
    }
}
