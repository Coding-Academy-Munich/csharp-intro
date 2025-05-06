using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEventsDemo
{
    public delegate int SimpleOperation(int a, int b);
    public delegate void StringFormatter(string s);

    public class DelegatesDemo
    {
        public static int Add(int x, int y) => x + y;
        public static void PrintUpper(string s) => Console.WriteLine(s.ToUpper());

        public static void ProcessNumbers(int x, int y, SimpleOperation op)
        {
            Console.WriteLine($"Callback result: {op?.Invoke(x, y)}");
        }

        public static void Run()
        {
            Console.WriteLine("Instantiating delegates:");
            SimpleOperation addOp = Add;
            SimpleOperation subtractOp = (a, b) => a - b;

            StringFormatter upperFormatter = PrintUpper;
            StringFormatter lowerFormatter = s => Console.WriteLine(s.ToLower());

            Console.WriteLine("Invoking delegates:");
            int sum = addOp(10, 5);
            Console.WriteLine($"Sum = {sum}");
            Console.WriteLine($"Difference = {subtractOp.Invoke(10, 5)}");

            SimpleOperation? nullOp = null;
            // nullOp(1, 2);
            if (nullOp != null)
            {
                nullOp(1, 2);
            }
            Console.WriteLine("Attempting safe invocation of nullOp");
            nullOp?.Invoke(1, 2);
            Console.WriteLine("After safe invocation of nullOp");

            upperFormatter("Test string");
            lowerFormatter("Test string");

            StringFormatter? nullFormatter = null;
            nullFormatter?.Invoke("Test string");

            Console.WriteLine("======= Null Formatter ========");
            nullFormatter = Console.WriteLine;
            // nullFormatter?.Invoke("Test string");
            nullFormatter += PrintUpper;
            nullFormatter?.Invoke("Test string 1");

            nullFormatter += s => Console.WriteLine($"Third formatter: {s}");
            nullFormatter?.Invoke("Test string 2");

            nullFormatter -= PrintUpper;
            nullFormatter -= Console.WriteLine;
            nullFormatter -= s => Console.WriteLine($"Third formatter: {s}");  // Wrong!
            nullFormatter?.Invoke("Test string 3");

            ProcessNumbers(10, 5, addOp);
            ProcessNumbers(10, 5, (x, y) => 2 * x + 3 * y);
        }
    }
}
