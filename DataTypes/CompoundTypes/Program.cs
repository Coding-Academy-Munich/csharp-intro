namespace CompoundTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TestWeekdays();
        }

        static void TestWeekdays()
        {
            Weekday monday = Weekday.Monday;

            Console.WriteLine($"Today is {monday}.");

            if (monday == Weekday.Monday)
            {
                Console.WriteLine("I don't like Mondays!");
            }

            Console.WriteLine($"The index of Monday is {(int)Weekday.Monday}.");

            Weekday[] weekdays = Enum.GetValues<Weekday>();

            foreach (Weekday day in weekdays)
            {
                Console.WriteLine($"day is {day} with value {(int)day}.");
            }

            for (int i = 0; i < weekdays.Length; i++)
            {
                Console.WriteLine($"The day with index {i} is {(Weekday)i}.");
            }
        }

        static void ClassVsStruct()
        {
            PersonClass pc1 = new PersonClass("Sepp Maier", 85);
            PersonClass pc2 = pc1;

            pc1.Age++;
            pc2.Name = "Hans Meier";

            pc1.Print();
            pc2.Print();

            PersonStruct ps1 = new PersonStruct("Sepp Maier", 85);
            PersonStruct ps2 = ps1;

            ps1.Age++;
            ps2.Name = "Hans Meier";

            ps1.Print();
            ps2.Print();
        }
        
        static (string, string) NameComponents()
        {
            return ("Franz", "Müller");
        }

        static void Tuples()
        {
            (string Name, int Age) personTuple = ("Franz Müller", 34);
            Console.WriteLine($"personTuple = {personTuple}");
            Console.WriteLine($"Item1 = {personTuple.Item1}, Item2 = {personTuple.Item2}");
            Console.WriteLine($"Name = {personTuple.Name}, Age = {personTuple.Age}");

            (string name, int age) = ("Franz Möller", 36);
            Console.WriteLine($"name = {name}, age = {age}");

            (string givenName, string lastName) = NameComponents();
            Console.WriteLine($"Name = {givenName} {lastName}");
        }


        static void Arrays(string[] args)
        {
            int[] numbers = [8, 3, 2];

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"numbers[{i}] = {numbers[i]}");
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"{numbers[i]}, ");
            }
            Console.WriteLine();

            numbers[2] = 22;

            foreach (int n in numbers)
            {
                Console.Write($"{n}, ");
            }

            Console.WriteLine("\n====================");
            foreach (string arg in args)
            {
                Console.WriteLine(arg);
            }
            Console.WriteLine("====================");
        }
    }
}
