namespace PrimitiveDataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine('x');
            Console.WriteLine('\u0078');
            Console.WriteLine('\u2121');
            Console.WriteLine('\x78');

            string greeting = "Hello, World!";
            Console.WriteLine(greeting[0]);
            Console.WriteLine(greeting[greeting.Length - 1]);
        }

        static void TestFloats()
        {
            Console.WriteLine($"0.1 * 0.1: {0.1 * 0.1}");
            Console.WriteLine($"0.1f * 0.1f: {0.1f * 0.1f}");
            Console.WriteLine($"1_000_000_000: {1_000_000_000}");
            Console.WriteLine($"1_000_000_001: {1_000_000_001}");
            Console.WriteLine($"1_000_000_000f: {1_000_000_000f}");
            Console.WriteLine($"1_000_000_001f: {1_000_000_001f}");
            Console.WriteLine($"1_000_000_000 == 1_000_000_001f: {1_000_000_000f == 1_000_000_001f}");
            Console.WriteLine($"1_000_000_000 == 1_000_000_032f: {1_000_000_000f == 1_000_000_032f}");
        }

        static void TestIntegers()
        {
            int number = 10;

            Console.WriteLine($"number++: {number++}");
            Console.WriteLine($"number:   {number}");
            Console.WriteLine($"++number: {++number}");
            Console.WriteLine($"number:   {number}");

            //uint a = 3000000000;
            //uint b = 2000000000;
            //uint c = 0;
            //checked
            //{
            //    c = a + b;
            //}


            //Console.WriteLine($"a: {a}, b: {b}, c: {c}");

            byte c = 129;
            byte d = 128;
            int i = c + d;

            byte e = (byte)i;

            Console.WriteLine($"c: {c}, d: {d}, e: {e}");
        }
    }
}
