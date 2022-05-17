using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Zavd2());
        }
       

        static string Zavd2()
        {
            Console.WriteLine("Zavd 2");
            Console.Write("number = ");
            int number = int.Parse(Console.ReadLine());
            int[] numbers = new int[4];
            int min = number % 10;
            int minPosition = 3;

            for (int i = 3; i >= 0; i--)
            {
                int x = number % 10;
                if (x < min)
                {
                    min = x;
                    minPosition = i;
                }
                if (number >= 1 && number <= 10)
                {
                    x = number;
                }

                numbers[i] = x;
                number /= 10;
            }
            numbers[minPosition] = numbers[2];
            numbers[2] = min;
            return String.Join("", numbers);
        }
    }
}