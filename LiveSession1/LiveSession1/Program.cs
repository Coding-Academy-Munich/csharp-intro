using LiveSession1.UI;
using LiveSession1.Internal;

namespace LiveSession1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Internal.MyClass myClass = new Internal.MyClass();
            myClass.Print();

            TestClass test = new TestClass();
            test.Test();

            Methods methods = new Methods();
            int seven = methods.ReturnSeven();
            Console.WriteLine($"The return value is {seven}.");

            Console.WriteLine($"The sum of 2 and 3 is {methods.Add(2, 3)}.");
            
        }

    }
}
