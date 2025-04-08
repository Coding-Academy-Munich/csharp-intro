namespace Rectanges
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle(4, 8, "purple");
            r1.WriteInfo();

            int area = r1.Width * r1.Height;
            Console.WriteLine("Area: " + area);

            Rectangle r2 = new Rectangle(15, 12, "green");
            r2.WriteInfo();

            r2.ChangeSize(20, 10);
            r2.WriteInfo();

            r1.ChangeColor("red");
            r2.ChangeColor("blue");

            r1.WriteInfo();
            r2.WriteInfo();
        }
    }
}
