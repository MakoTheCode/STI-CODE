using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter pieces of apple: ");
            int pieces = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please total price of the apple(s): ");
            decimal price = Convert.ToDecimal(Console.ReadLine());

            decimal totalPrice = pieces * price;
            Console.WriteLine("Total price: {0}", totalPrice);
            decimal convertedTotalPrice = Math.Truncate(totalPrice);

            Console.WriteLine("Original price: {0}, converted price: {1}", totalPrice, convertedTotalPrice);

            Console.ReadKey();
        }
    }
}