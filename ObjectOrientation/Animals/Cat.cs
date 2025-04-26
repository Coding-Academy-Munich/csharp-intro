using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    internal class Cat : Animal
    {
        public Cat(string name) : base(name)
        {
        }

        public Cat() : base("Garfield")
        {
        }

        public void Meow()
        {
            Console.WriteLine($"{Name} meows.");
        }
    }
}
