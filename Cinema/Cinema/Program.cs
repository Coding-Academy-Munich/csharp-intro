using Cinema.Management;
using Ticketing.Individual;

namespace Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager();
            manager.WriteGreeting();

            Customer customer = new Customer();
            customer.WriteGreeting();

            double ticketPrice = 10.0;
            double discount = 5.0; // 5% discount
            double discountedPrice = Customer.ComputeDiscountedPrice(ticketPrice, discount);
            Console.WriteLine("The discounted ticket price is: " + discountedPrice + " Euro.");

            Console.WriteLine("Discounted price for a 17-year-old: " + Customer.ComputePrice(ticketPrice, 17) + " Euro.");
            Console.WriteLine("Discounted price for a 65-year-old: " + Customer.ComputePrice(ticketPrice, 65) + " Euro.");
            Console.WriteLine("Price for a 30-year-old: " + Customer.ComputePrice(ticketPrice, 30) + " Euro.");
        }
    }
}
