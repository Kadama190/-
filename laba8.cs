using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] vec1 = new double[] { 0.052, 0.9, 0.15, 0.84, 0.67 };
            double[] vec2 = new double[] { 0.948, 0.1, 0.33, 0.16, 0.85 };

            Array.Sort<double>(vec1);
            Array.Sort<double>(vec2);
            Array.Reverse(vec2);

            var sum1 = vec1.Sum();
            var sum2 = vec2.Sum();

            foreach (var c in vec1)
                Console.Write($"{c}, ");
            Console.WriteLine($"Сумма первого вектора = {sum1}");

            foreach (var c in vec2)
                Console.Write($"{c}, ");

            Console.WriteLine($"Сумма второго вектора = {sum2}");
            Console.ReadKey();
        }
    }
}
