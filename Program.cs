using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var x1 = new TSquare();
            var x2 = new TSquare(4);
            var x3 = new TSquare(x2);
            var tc1 = new TCube();
            var tc2 = new TCube(4);
            var tc3 = new TCube(tc1);
            Console.WriteLine(x1);
            Console.WriteLine(x2);
            Console.WriteLine(x3);
            Console.WriteLine(TSquare.count);
            Console.WriteLine(x2.Square());
            x1 = 2 * x2 + x2;
            Console.WriteLine(x1);
            Console.WriteLine(tc1);
            Console.WriteLine(tc2);
            Console.WriteLine(tc2.Square());
            Console.WriteLine(tc2.V());
            Console.ReadLine();
        }
        public class TSquare
        {
            public static int count;

            private double _a;
            public double A
            {
                get { return _a; }
                set
                {
                    if (value > 0)
                    {
                        _a = value;
                    }
                }
            }

            public TSquare(double a)
            {
                this.A = a;
                count++;
            }
            public TSquare()
            {
                this.A = 1;
                count++;
            }
            public TSquare(TSquare x)
            {
                this.A = x.A;
                count++;
            }
            static TSquare()
            {
                count = 0;
            }
            public override string ToString()
            {
                return string.Format($"a={_a}");
            }
            public double Square()
            {
                return (A * A);
            }
            public double Perimetr()
            {
                return 4 * A;
            }
            public bool IsEqual(TSquare x)
            {
                return A == x.A;
            }
            public static TSquare operator +(TSquare x1, TSquare x2)
            {
                return new TSquare(x1.A + x2.A);
            }
            public static TSquare operator -(TSquare x1, TSquare x2)
            {
                return new TSquare(x1.A - x2.A);
            }
            public static TSquare operator *(TSquare x1, double d)
            {
                return new TSquare(x1.A * d);
            }
            public static TSquare operator *(double d, TSquare x1)
            {
                return new TSquare(x1.A * d);
            }
        }
        public class TCube : TSquare
        {
            public TCube(double a) : base(a)
            {

            }
            public TCube()
            {
                this.A = 1;
            }
            public TCube(TCube tc)
            {
                this.A = tc.A;
            }
            public override string ToString()
            {
                return $"a={A}";
            }
            public new double Square()
            {
                return (6 * base.Square());
            }
            public double V()
            {
                return base.Square() * A;
            }
            public bool IsEqual(TCube tc)
            {
                return this.A == tc.A;
            }
            public static TCube operator +(TCube tc1, TCube tc2)
            {
                return new TCube(tc1.A + tc2.A);
            }
            public static TCube operator -(TCube tc1, TCube tc2)
            {
                return new TCube(tc1.A - tc2.A);
            }
            public static TCube operator *(TCube tc1, double d)
            {
                return new TCube(tc1.A * d);
            }
            public static TCube operator *(double d, TCube tc1)
            {
                return new TCube(tc1.A * d);
            }
        }
    }
}

