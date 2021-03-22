using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final_Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Student s1 = new Student("Shethil", "101");
            Student s2 = new Student("Tamim", "102");
            Student s3 = new Student("Sakib", "103");
            Student s4 = new Student("Rana", "104");
            Student s5 = new Student("Rgib", "106");
            Student s6 = new Student("Sabbir", "107");


            Course c1 = new Course("CSC101", "OOAD",3);
            Course c2 = new Course("CSC102", "TOC",3);
            Course c3 = new Course("CSC103", "OS",3);

            c1.AddStudent(s1,s2, s3, s4, s5, s6);
            c1.PrintStudent();
            c1.RemoveStudent(s6);
            Console.WriteLine("");
            s5.PrintCourse();
            c1.PrintStudent();
            Console.WriteLine("");
            s2.AddCourse(c1, c2, c3);
            s2.PrintCourse();
            s2.RemoveCourse(c2);
            Console.WriteLine("");
            s2.PrintCourse();
            c2.PrintStudent();
        }
    }
}
