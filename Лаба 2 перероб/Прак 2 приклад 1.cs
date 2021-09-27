using System;

namespace Прак_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // вивести версію о. с.
            OperatingSystem os = System.Environment.OSVersion;
            Console.WriteLine("Platform: {0}", os.Platform);
            System.Console.WriteLine("The current date and time is" + System.DateTime.Now); // Дата і час
            System.Console.ReadLine();
        }
    }
}
