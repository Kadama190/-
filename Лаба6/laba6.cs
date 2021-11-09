using System;

namespace laba_6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int j;
            int dodatnyi_chysla = 0;
            string k;
            string strValue;
            int[] iArray1 = new int[20];

            for (j = 0; j < 20; j++)
            {
                strValue = Console.ReadLine();
                iArray1[j] = Convert.ToInt32(strValue);
                if (iArray1[j] >= 0)
                {
                    dodatnyi_chysla += 1;

                }
            }

            for (j = 0; j < 20; j++)
            {
                Console.WriteLine("\n" + "  |  " + j + "  |  " + iArray1[j] + "  |  ");

            }
            Console.WriteLine("\n Количество положительных элементов = " + dodatnyi_chysla);
        }
    }
}
