namespace ControlFlow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TestFact3();
        }

        static void TestFact3()
        {
            int result = 1;
            for (int n = 1; n <= 5; n++)
            {
                result = result * n;
            }
            Console.WriteLine($"result = {result}");
        }

        static void TestFact2()
        {
            int result = 1;

            Console.WriteLine("Please enter the upper bound:");
            string? upperBound = Console.ReadLine();

            if (upperBound == null)
            {
                return;
            }

            int factBound = int.Parse(upperBound);

            int n = 1;
            while (n <= factBound)
            {
                result = result * n;
                n++;
            }

            Console.WriteLine($"n = {n}, result = {result}");
        }

        static void TestFact1()
        {
            int n = 5;
            int result = 1;

            while (n > 0)
            {
                result = result * n;
                n--;
            }

            Console.WriteLine($"n = {n}, result = {result}");
        }

        static void TestReadLine()
        {
            Console.WriteLine("Please enter some text:");
            string? input = Console.ReadLine();
            if (input == null)
            {
                Console.WriteLine("The input was null.");
            }
            else
            {
                Console.WriteLine($"The input was: {input}.");
            }
        }

        static void TestNullableString()
        {
            string? myString = "my string";
            Console.WriteLine($"myString = '{myString}'");
        }

        static void TestSwitch()
        {
            int grade = 7;
            string text;

            switch (grade)
            {
                case 1:
                    text = "Very good";
                    break;
                case 2:
                    text = "Good";
                    break;
                case 3:
                    text = "Average";
                    break;
                case 4:
                    text = "Sufficient";
                    break;
                case 5:
                    text = "Bad";
                    break;
                case 6:
                    text = "Very Bad";
                    break;
                default:
                    text = "Unknown";
                    break;
            }

            Console.WriteLine(text);
        }

        static void TestPerson()
        {
            Person person = new Person(25, "Mechanic");
            Console.WriteLine($"Person can be employed: {person.CanBeEmployed()}");
            person.IsOnProbation = true;

            Person youngPerson = new Person(17, "Secretary");
            Console.WriteLine($"Young person can be employed: {youngPerson.CanBeEmployed()}");

            Person oldPerson = new Person(70, "Engineer");
            Console.WriteLine($"Old person can be employed: {oldPerson.CanBeEmployed()}");

            Console.WriteLine();
            Console.WriteLine($"Person can repair machines: {person.CanRepairMachines()}");
            Console.WriteLine($"Young person can repair machines: {youngPerson.CanRepairMachines()}");
            Console.WriteLine($"Old person can repair machines: {oldPerson.CanRepairMachines()}");

            Console.WriteLine();
            Console.WriteLine($"Person can take vacation: {person.CanTakeVacation()}");
            Console.WriteLine($"Young person can take vacation: {youngPerson.CanTakeVacation()}");
            Console.WriteLine($"Old person can take vacation: {oldPerson.CanTakeVacation()}");
        }

        static void GreetingSwitch()
        {
            string name = "Jack";

            switch (name)
            {
                case "John":
                    Console.WriteLine("Hello John, the boss wants to see you!");
                    break;
                case "Jane":
                    Console.WriteLine("Hello, Ms. Doe, how are you today?");
                    break;
                case "Bob":
                case "Ben":
                case "Bill":
                    Console.WriteLine($"Hello {name}, your access has been revoked!");
                    break;
                default:
                    Console.WriteLine($"Hello {name}, how are you today?");
                    break;
            }
        }

        static void GreetingIf()
        {
            string name = "Ben";

            if (name == "John")
            {
                Console.WriteLine("Hello John, the boss wants to see you!");
            }
            else if (name == "Jane")
            {
                Console.WriteLine("Hello, Ms. Doe, how are you today?");
            }
            else if (name == "Bob" || name == "Ben")
            {
                Console.WriteLine($"Hello {name}, your access has been revoked!");
            }
            else
            {
                Console.WriteLine($"Hello {name}, how are you today?");
            }
        }

        static void TestIfElse()
        {
            int x = 1;

            if (x == 1)
            {
                Console.WriteLine("x is 1");
            }
            else
            {
                if (x == 2)
                {
                    Console.WriteLine("x is 2");
                }
                else
                {
                    if (x == 3)
                    {
                        Console.WriteLine("x is 3");
                    }
                    else
                    {
                        Console.WriteLine("x is neither 1 nor 2");
                    }
                }
            }
        }

        static void TestIf()
        {
            int x = 1;
            int y = 2;

            if (x == 1)
            {
                if (y == 1)
                {
                    Console.WriteLine("x is 1 and y is 1");
                }
            }
            else
            {
                Console.WriteLine("x is not 1");
            }
        }

        static void TestBlock()
        {
            int x = 3;

            {
                x++;
                // int y = 5;
            }

            Console.WriteLine($"x = {x}"); // x = 4
            // y++;
        }
    }
}
