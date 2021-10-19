using System;

namespace laba5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y, S, a, b, c, d, i;
                int k;
        m1: Console.WriteLine("Ввести значення x");
            x = double.Parse((Console.ReadLine()));
            Console.WriteLine('\t' + "Промежуточные результаты" + '\n');
            k = 1;
            S = 1; b = 1;
            c = 1;
            a = x;
            while (Math.Abs(a) >= 0.000001)
            {
                S += a;
                d = x * c;
                i = b;
                b += 3;
                c = x * x;
                a = 3 * (d / i);    
                k++;
                Console.WriteLine('\t' + "Інтерація №" + k + '\n' + "a=" + a + "S=" + S + "\n");
                y = Math.Pow(x, (1 / 3));
                Console.WriteLine('\t' + "   Результати:" + '\n' + "Заданий x=" + x + '\n' + "Сумма ряду S=" + S + '\n' + "Кількість членів ряду" + k + '\n' + "Функція x=" + y + '\n');
                Console.WriteLine('\n' + "Для повторго ввода" + "Натиснути любу клавішу" + '\n' + "Для завершення дії натиснути Enter");
                string rep = Console.ReadLine();
                if (rep != "") goto m1;
            }

             
        }
    }
}
