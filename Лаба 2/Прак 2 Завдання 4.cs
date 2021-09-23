using System;

namespace Прак_2___
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("The current date and time is" + System.DateTime.Now);
            Console.WriteLine("Input x + \r");
            double x1 = Convert.ToDouble(Console.ReadLine());
            double I = 4 * Math.Sin(15 * Math.Exp(x1 / 2) + 10.2) - 9 * Math.Exp(-x1) + Math.Abs(x1 + 5 / 3);
            Console.WriteLine("x1 = {0} \t I = {1}", x1, I);
            Console.ReadKey();

        }
    }
}
