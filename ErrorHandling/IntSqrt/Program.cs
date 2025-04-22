namespace IntSqrt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                WriteIntSqrt(0);
                WriteIntSqrt(1);
                WriteIntSqrt(2);
                WriteIntSqrt(4);
                WriteIntSqrt(9);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
        }

        static int IntSqrt(int value)
        {
            for (int i = 0; i <= value; i++)
            {
                if (i * i == value)
                {
                    return i;
                }
            }
            throw new ArgumentOutOfRangeException("value", value, "Must be a square number");
        }

        static void WriteIntSqrt(int value)
        {
            try
            {
                int result = IntSqrt(value);
                Console.WriteLine($"The integer square root of {value} is {result}.");
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine($"The integer square root of {value} is not a perfect square.");
            }
            finally
            {
                Console.WriteLine("Done.");
            }
        }

        static int IntSqrtOld(int value)
        {
            for (int i = 0; i <= value; i++)
            {
                if (i * i == value)
                {
                    return i;
                }
            }
            return -1;
        }

        static void WriteIntSqrtOld(int value)
        {
            int result = IntSqrtOld(value);
            if (result == -1)
            {
                Console.WriteLine($"The integer square root of {value} is not a perfect square.");
                return;
            }
            else
            {
                Console.WriteLine($"The integer square root of {value} is {result}.");
            }
        }
    }
}
