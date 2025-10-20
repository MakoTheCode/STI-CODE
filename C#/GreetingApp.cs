using System;

namespace GreetingApp
{
    public class GreetingProgram
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter a name: ");
            string name = Console.ReadLine();

            Console.Write("Enter the number of your enrolled courses: ");
            int courses = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the price of your favorite book: ");
            double price = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nName: " + name);
            Console.WriteLine("Total enrolled courses: " + courses);
            Console.WriteLine("Price of my favorite book: " + price.ToString("C"));

            Console.Write("\nPress any key to Exit...");
            Console.ReadKey();
        }
    }
}
