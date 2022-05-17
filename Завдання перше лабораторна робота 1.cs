using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a=");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("b=");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("c=");
            double c = Convert.ToDouble(Console.ReadLine());
            double max1 = Max1int(a,b,c);
            Console.WriteLine(max1);
            double min = Minint(a,b,c);
            Console.WriteLine(min);
            double max2 = Max2int(a, b, c);
            Console.WriteLine(max2);
            double y = max1 + min + max2;
            Console.WriteLine("Y = {0}", y);
        }
        static double Max1int(double a, double b, double c)
        {
            if ((a * b)> (b * c))
            {
                return (a * b);
            }
            else
            {
                return (b * c);
            }
        }
        static double Minint(double a, double b, double c)
        {
            if ((a + c)< (a + b))
            {
                return (a + c);
            }
            else
            {
                return (a + b);
            }
        }
        static double Max2int(double a, double b, double c)
        {
            if ((Math.Pow(a, 2) - Math.Pow(b, 2)) > (Math.Pow(b, 2) + Math.Pow(c, 2)))
            {
                return (Math.Pow(a, 2) - Math.Pow(b, 2));
            }
           else
            {
                return (Math.Pow(b, 2) + Math.Pow(c, 2));
            }
        }

    }
}
