using System;

namespace MathApp
{
    class MathProgram
    {
        static void Main(string[] args)
        {
            double number1 = 10.5;
            double number2 = 5.7;

            double absoluteValue = Math.Abs(-10);
            double power = Math.Pow(number1, 2);
            double squareRoot = Math.Sqrt(25);
            double maximum = Math.Max(number1, number2);
            double minimum = Math.Min(number1, number2);

            Console.WriteLine($"Abs: {absoluteValue}");
            Console.WriteLine($"Pow: {power}");
            Console.WriteLine($"Sqrt: {squareRoot}");
            Console.WriteLine($"Max: {maximum}");
            Console.WriteLine($"Min: {minimum}");

            Console.ReadKey();
        }
    }
}
