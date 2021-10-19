using System;
using System.IO;

namespace laba5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter p = new StreamWriter("laba5.txt");
            float a, x, y;
            p.WriteLine("Результат");
            for (a = 1.25f; a <= 2f; a += 0.25f)
            {
                p.WriteLine("a=" + a);
                for (x = -2; x <= 2; x = +0.1f) ;
                {
                    if (a < 0)
                    {
                        p.WriteLine("Негативний");
                    }
                    if (Math.Sqrt(a) == 0)
                    {
                        p.WriteLine("На нуль ділити не можна");
                    }
                    else
                    {
                        y = (float)(1 - Math.Exp(-(x / Math.Pow(x, 2)) / a));
                        p.WriteLine("   x=   " + x + '\t' + "   y=   " + y);
                    }
                }
            }
            p.Close();







        }
    }
}
