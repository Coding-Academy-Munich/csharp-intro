using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticketing.Individual
{
    public class Customer
    {
        public string Name { get; set; } = "Joe";
        private static int _minorAge = 18;
        private static int _seniorAge = 65;
        private static double _minorDiscount = 10.0;
        private static double _seniorDiscount = 5.0;

        public void WriteGreeting()
        {
            Console.WriteLine("I'm " + Name + ", I'd like to buy a ticket!");
        }

        public static double ComputeDiscountedPrice(double price, double discountInPercent)
        {
            double discount = price * (discountInPercent / 100);
            return price - discount;
        }

        public static bool IsMinor(int age)
        {
            return age < _minorAge;
        }

        public static bool IsSenior(int age)
        {
            return age >= _seniorAge;
        }

        public static bool GetsDiscount(int age)
        {
            return IsMinor(age) || IsSenior(age);
        }

        public static double ComputePriceV1(double price, int age)
        {
            double result = price;
            if (GetsDiscount(age))
            {
                result = ComputeDiscountedPrice(price, 10);
            }
            return result;
        }

        public static double ComputePriceV2(double price, int age)
        {
            if (GetsDiscount(age))
            {
                return ComputeDiscountedPrice(price, 10);
            }
            else
            {
                return price;
            }
        }

        public static double ComputePrice(double price, int age)
        {
            if (IsMinor(age))
            {
                return ComputeDiscountedPrice(price, _minorDiscount);
            }
            else if (IsSenior(age))
            {
                return ComputeDiscountedPrice(price, _seniorDiscount);
            }
            else
            {
                return price;
            }
        }
    }
}
