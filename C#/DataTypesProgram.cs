using System;

namespace DataTypesApp
{
    class DataTypesProgram
    {
        public static void Main(string[] args)
        {
            int piecesOfApple;
            double totalPrice;

            Console.Write("Enter the pieces of apple: ");
            piecesOfApple = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter total price of {0} apple(s): ", piecesOfApple);
            totalPrice = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("The total price of {0} apple(s) is {1}", piecesOfApple, totalPrice);
            Console.WriteLine("The value of original price is {0}", totalPrice);
            Console.WriteLine("The value of converted price is {0}", (int)totalPrice);
            Console.WriteLine();
            Console.Write("Press any key to exit . . . ");
            Console.ReadKey(true);
        }
    }
}