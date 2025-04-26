using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsInterface
{
    internal class Cat : IAnimal
    {
        public string Name { get; private set;}

        public Cat(string name)
        {
            Name = name;
        }

        public void Meow()
        {
            Console.WriteLine($"{Name} meows.");
        }

        public void Pet()
        {
            Console.WriteLine($"You pet {Name}.");
            Meow();
        }
    }
}
