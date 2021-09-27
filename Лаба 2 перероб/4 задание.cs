using System;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("The current date and time is" + System.DateTime.Now);
            Console.WriteLine("Input x + \r");
            double x1 = Convert.ToDouble(Console.ReadLine());
            double I = 4 * Math.Sin(15d * Math.Exp(x1 / 2d) + 10.2) - 9d * Math.Exp(-x1) + Math.Abs(x1 + 5d / 3d);
            Console.WriteLine("x1 = {0} \t I = {1}", x1, I);
            Console.ReadKey();
        }
    }
}
