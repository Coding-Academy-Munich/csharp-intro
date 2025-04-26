using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructVsClass
{
    public struct PersonStruct
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public PersonStruct(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void Print()
        {
            Console.WriteLine($"PersonStuct: Name = {Name}, Age = {Age}");
        }
    }
}
