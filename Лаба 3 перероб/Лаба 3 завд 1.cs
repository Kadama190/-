using System;

namespace laba_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double A; // = 993,285;
            int I; // = 112000;
            double C; // = 0,00023;
            bool l; // = false;
            string name; // "Aleksandrovich";
            Console.WriteLine("Введіть A");
            A = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введіть I");
            I = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введіть C");
            C = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введіть l");
            l = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Введіть ім'я");
            name = Console.ReadLine();
            Console.WriteLine("Результати форматування \nName = {0,1} \tl = {1,5}", name, l);
            System.Console.WriteLine("\nA = {0,1:f3} \tI = {1,7} \tC = {2,9:f5}", A, I, C);
            System.Console.WriteLine("\nЩоб вийти натисніть Enter");
            Console.ReadLine();
            System.Console.ReadLine();


           

        }
    }
}
