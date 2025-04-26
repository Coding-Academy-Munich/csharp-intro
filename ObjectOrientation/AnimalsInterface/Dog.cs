using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsInterface
{
    internal class Dog : IAnimal
    {
        public string Name { get; private set; }

        public Dog(string name)
        {
            Name = name;
        }

        public void Pet()
        {
            Console.WriteLine($"You pet the dog {Name}.");
        }
    }
}
