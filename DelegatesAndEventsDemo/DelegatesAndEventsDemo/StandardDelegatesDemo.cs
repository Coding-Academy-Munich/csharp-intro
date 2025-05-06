using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEventsDemo
{
    internal class StandardDelegatesDemo
    {
        public static void Run()
        {
            Func<int, int, int> addFunc = (x, y) => x + y;
            Action<string> printAction = s => Console.WriteLine(s);
            Predicate<int> isPositive = n => n > 0;

            printAction($"The value of addFunc(10, 5) is {addFunc(10, 5)}");
        }
    }
}
