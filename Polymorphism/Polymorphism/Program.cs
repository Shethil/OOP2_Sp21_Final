using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Shithil", "19-39698-1", "01-08-1999", 3.75f, 148);
            s1.ShowInfo();

            Person p1 = new Student("Illusion", "**-*****-*", "65-17-*9*99", 0.0f, 999);
            p1.ShowInfo();


        }
    }
}
