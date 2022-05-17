using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            int c = n - 1;
            int[] a = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                a[i] = rnd.Next(1, 10);
            }
            Stek steck = new Stek(c, a);
            steck.Remove(ref a, 2, c);
            steck.Insert(ref a, 8, 3, c);
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{a[i]}" + "\t");
            }
            Console.WriteLine($"sum = {steck.Sum(a)}");
            Console.WriteLine($"{ steck.ToString()}");
        }
    }
    public class Stek
    {
        private int _last;
        private int[] _stekelements;
        public Stek(int last, int[] stekelements)
        {
            _last = last;
            _stekelements = stekelements;
        }
        public int[] Insert(ref int[] _stekelements, int value, int index, int _last)
        {
            int[] newElements = new int[_stekelements.Length + 1];
            newElements[index] = value;

            for (int i = 0; i < index; i++)
                newElements[i] = _stekelements[i];
            for (int i = index; i < index; i++)
                newElements[i + 1] = _stekelements[i];
            _stekelements = newElements;
            _stekelements[1] = _stekelements.Length - 1;
            return _stekelements;
        }
        public int[] Remove(ref int[] _stekelements, int index, int _last)
        {
            int[] newElements = new int[_stekelements.Length - 1];
            for (int i = 0; i < index; i++)
                newElements[i] = _stekelements[i];
            for (int i = index + 1; i < _stekelements.Length; i++)
                newElements[i - 1] = _stekelements[i];

            _stekelements = newElements;
            _stekelements[1] = _stekelements.Length - 1;
            return _stekelements;
        }
        public int Sum(int[] _stekelements)
        {
            int sum = 0;
            for (int i = 0; i < _stekelements.Length; i++)
            {
                sum += _stekelements[i];
            }
            return sum;
        }
        public override string ToString()
        {
            return string.Format($"{_last},{_stekelements}");
        }
        public int[] Steckel { get { return _stekelements; } set { _stekelements = value; } }
        public int Lastel { get { return _last; } set { _last = value; } }
    }
}
