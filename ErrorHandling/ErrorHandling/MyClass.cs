using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorHandling
{
    internal class MyClass
    {
        public void WriteInfo()
        {
            Console.WriteLine("WriteInfo method called.");
            Console.WriteLine($"The computed value is : {ComputeAValue(10, 20)}");
            Console.WriteLine("Done.");
        }

        public int ComputeAValue(int x, int y)
        {
            int z = x + y + 2;
            int w = z / 2;
            int result = w / (z - x - y);
            return result;
        }
    }
}
