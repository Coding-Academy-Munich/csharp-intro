using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompoundTypes
{
    public class PersonClass
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public PersonClass(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void Print()
        {
            Console.WriteLine($"PersonClass - Name: {Name}, Age: {Age}");
        }
    }
}
