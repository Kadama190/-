using System;

namespace laba9._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Ts ts1 = new Ts("Траспорт", 0);
            Console.WriteLine("Класс Ts");
            ts1.Print();
            Console.WriteLine("--------------");
            Console.WriteLine("Класс Train");
            Train T1 = new Train("Поезд", 200, 50);
            T1.Print();
            Console.WriteLine("--------------");
            Console.WriteLine("Класс Express");
            Express ex1 = new Express("Поезд Express", 400, 120,300);
            ex1.Print();
            Console.WriteLine("--------------");
            Console.WriteLine("Класс Car");
            Car c1 = new Car("Авто", 5,10);
            c1.Print();
            Console.WriteLine("--------------");

        }
    }
}
