using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFlow
{
    internal class Person
    {
        public int Age { get; private set; }
        public string Qualification { get; private set; }
        public bool IsOnProbation { get; set; }

        public Person(int age, string qualification)
        {
            Age = age;
            Qualification = qualification;
        }

        public bool CanBeEmployed()
        {
            return Age >= 18 && Age <= 67;
        }

        public bool CanRepairMachines()
        {
            return Qualification == "Mechanic" || Qualification == "Engineer";
        }

        public bool CanTakeVacation()
        {
            return !IsOnProbation;
        }
    }
}
