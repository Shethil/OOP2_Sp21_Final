using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    class Program
    {

        public delegate void math(int a, int b);

        public static void Add(int a, int b)
        {
            Console.WriteLine("Addition: "+(a+b));
        }

        public static void Sub(int a, int b)
        {
            Console.WriteLine("Subtraction: " + (a - b));
        }
        static void Main(string[] args)
        {
            math calc = Add;

            calc(14, 12);

            calc = Sub;
            calc(14, 12);

            Person p = new Person();
            calc = p.AddtoCGPA;

            calc(90, 85);

            math cacl2 = Add;
            cacl2 += Sub;
            cacl2 += p.AddtoCGPA;

            cacl2(90, 85);

            cacl2 -= Sub;
            cacl2(90, 85);
        }
    }
}
