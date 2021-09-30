using System;

namespace лаба3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 993,285f;
            float i = 112000;
            double c = 2,3 * 10( 4 );
            bool l = false;
            string name = "Aleksandrovich";
            Console.WriteLine("input отчество");
            name = Console.ReadLine();
            Console.WriteLine("input a");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("input i");
            i = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("input c");
            c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("input l");
            l = Convert.ToBoolean(Console.ReadLine());
            System.Console.WriteLine("Результаты форматирования");
        }
    }
}
