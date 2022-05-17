using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labaratory2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть розмірність матриці: ");
            int n = int.Parse(Console.ReadLine());
            int[,] a = new int[n, n];
            Random rnd = new Random();
           for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    a[i, j] = rnd.Next(1, 10);
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(a[i, j] + "\t");
                }
                Console.WriteLine();
            }
            int min = a[0, 0];
            int minvalue = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                   if (a[i,j]< min)
                    {
                        min = a[i, j];
                        minvalue = j;
                    }
                }
            }
         Console.Write($" Найменший елемент знаходиться у {minvalue} стовпці");
         Console.ReadLine();
        }

    }
}
