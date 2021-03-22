using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Student : Person
    {
        public double Cgpa { get; set; }
        public int Credit { get; set; }

        public Student(){}
        public Student(string name, string id, string dob, float cgpa, int credit): base(name, id, dob)
        {
            Cgpa = cgpa;
            Credit = credit;
        }
        /* new public void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Cgpa : "+ Cgpa);
            Console.WriteLine("Credit : "+Credit);
        } */

        override public void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Cgpa : " + Cgpa);
            Console.WriteLine("Credit : " + Credit);
        }
    }
}
