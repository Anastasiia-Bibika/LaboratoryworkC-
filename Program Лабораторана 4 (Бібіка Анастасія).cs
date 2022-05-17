using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var t1 = new TSquare();
            var t2 = new TSquare(4);
            var t3 = new TSquare(t2);
            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            t1 = 3 * t1 + t2;
            Console.WriteLine(t1);

            Console.WriteLine(t1.Square(t2));
            Console.WriteLine(t1.Perimetr(t2));

            Console.ReadLine();
        }

    }
    internal class TSquare
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
            _a = a;
            count++;
        }
        public TSquare()
        {
            _a = 1;
            count++;
        }
        public TSquare(TSquare t)
        {
            _a = t._a;
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
        public double Square(TSquare t)
        {
            return t._a * t._a;
        }
        public double Perimetr(TSquare t)
        {
            return t._a * 4;
        }
        public bool IsEqual(TSquare t)
        {
            return _a == t._a;
        }
        public static TSquare operator +(TSquare t1, TSquare t2)
        {
            return new TSquare(t1._a + t2._a);
        }
        public static TSquare operator -(TSquare t1, TSquare t2)
        {
            return new TSquare(t1._a - t2._a);
        }
        public static TSquare operator *(TSquare t1, double d)
        {
            return new TSquare(t1._a * d);
        }
        public static TSquare operator *(double d, TSquare t1)
        {
            return new TSquare(t1._a * d);
        }
    }
}

