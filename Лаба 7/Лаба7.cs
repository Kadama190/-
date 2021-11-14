using System;

namespace laba7
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, k = 0;
            string strValue;
            int[] iArray2 = new int[30];
            int[,] iArray = new int[4, 4];
            Console.WriteLine(" Заполните масив числами");
            for (i = 0; i < 4; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    strValue = Console.ReadLine();
                    iArray[i, j] = Convert.ToInt32(strValue);
                }
            }
            Console.WriteLine("\nДвомерный масив A[4,4]");
            for (i = 0; i < 4; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    Console.WriteLine("\niArray [" + i + "," + j + "] =" + iArray[i, j]);
                }
            }
            Console.WriteLine("\nОтрицательные елементы по главной диагонал");
            for (i = 0; i < 4; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    if (i == j && iArray[i, j] < 0)
                    {
                        Console.WriteLine("\niArray [" + i + "," + j + "] =" + iArray[i, j]);
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
