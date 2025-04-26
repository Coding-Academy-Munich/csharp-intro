using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    internal abstract class Animal
    {
        public string Name { get; private set; }

        public Animal(string name)
        {
            Name = name;
        }

        public virtual void Pet()
        {
            Console.WriteLine($"You are petting {Name}. They like it.");
        }

        public abstract void MakeNoise();
    }
}
