using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    internal class Dog : Animal
    {
        public Dog(string name) : base(name)
        { }

        public void Bark()
        {
            Console.WriteLine($"{Name} barks.");
        }

        public override void MakeNoise()
        {
            Bark();
        }

        public override void Pet()
        {
            base.Pet();
            Bark();
        }
    }
}
