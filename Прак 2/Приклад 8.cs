using System;

namespace _8
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1_003;
            Console.WriteLine($"a / 10={a / 10}"); // NOT 100,3
            Console.WriteLine($"a % 10={a % 10}");

            Console.ReadKey();
        }
    }
}
