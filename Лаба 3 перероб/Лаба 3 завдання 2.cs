using System;
using System.IO;

namespace laba_3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode; // Розпізнавання укр. літер
            string s;
            double x, y;
            StreamWriter f = new StreamWriter("lab3.res"); // виведення 
            StreamReader f1 = new StreamReader("lab3.txt"); // введення
            f.WriteLine("Таблиця значень\nI------------------------------I\nI      X     I     Функція     I\nI------------------------------I");
        metka: s = f1.ReadLine();
            if (s == null) goto metka1;
            x = Convert.ToDouble(s);
            y = Math.Exp(-x) * Math.Sin(Math.PI * x / 2d);
            f.WriteLine("I x = {0:f3} I y = {1:e3} I \n", x, y);
            goto metka;
        metka1: f.WriteLine("I-------------------------------I\nРозробив Вернигора Владислав Олександрович {0} \n", s);
            f.Close();
            f1. Close();
        }
    }
}
