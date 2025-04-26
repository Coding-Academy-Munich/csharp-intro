namespace StructVsClass
{
    internal class Program
    {
        static void Main(string[] args)
        {

            PersonClass pc1 = new PersonClass("Sepp Maier", 85);
            PersonClass pc2 = pc1;

            pc1.Age++;
            pc2.Name = "Hans Maier";

            Console.WriteLine("=== Classes ===");
            pc1.Print();
            pc2.Print();

            PersonStruct ps1 = new PersonStruct("Sepp Maier", 85);
            PersonStruct ps2 = ps1;

            ps1.Age++;
            ps2.Name = "Hans Maier";

            Console.WriteLine("=== Structs ===");
            ps1.Print();
            ps2.Print();
        }
    }
}
