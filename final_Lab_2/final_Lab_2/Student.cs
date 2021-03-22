using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final_Lab_2
{
    class Student
    {
        String name;
        String id;
        String department;
        float cgpa;

        int maxCourse = 5;
        int totalCourse = 0;
        private Course[] course;

        public Student()
        {
            //Console.WriteLine("This is a constructor with one parameter");
            this.course = new Course[5];
        }

        public Student(String name, String id)
        {
           // Console.WriteLine("This is a constructor with two parameter");
            this.name = name;
            this.id = id;
        }

        public String Name
        {
            set { name = value; }
            get { return name; }
        }

        public String Id
        {
            set { id = value; }
            get { return id; }
        }

        public String Department
        {
            set { department = value; }
            get { return department; }
        }

        public float Cgpa
        {
            set { cgpa = value; }
            get { return cgpa; }
        }

        public int CourseCount { set; get; }
        public void AddCourse(params Course[] crs)
        {
            foreach (Course c in crs)
            {
                this.course[this.CourseCount++] = c;
                if (c.GetStudent(this.Id) == null)
                    c.AddStudent(this);
            }
        }
        public void RemoveCourse(Course c)
        {
            if (c == this.course[this.CourseCount - 1])
            {
                this.course[this.CourseCount--] = null;
                c.RemoveStudent(this);
                return;
            }

            bool notFound = true;
            for (int i = 0; i < this.CourseCount - 1; ++i)
            {
                if (c == this.course[i] && notFound)
                {
                    this.course[i] = null;
                    this.CourseCount--;
                    c.RemoveStudent(this);
                    notFound = false;
                }
                if (!notFound)
                    this.course[i] = this.course[i + 1];
            }
        }
        public Course GetCourse(string id)
        {
            for (int i = 0; i < this.CourseCount; ++i)
                if (id == this.course[i].Id)
                    return this.course[i];

            return null;
        }
        public void PrintCourse()
        {
            for (int i = 0; i < this.CourseCount; ++i)
            {
                this.course[i].ShowCourseInfo();
            }
        }

        



        public void ShowInfo()
        {
            Console.WriteLine("Name is :" + name);
            Console.WriteLine("ID is :" + id);
            Console.WriteLine("Department is :" + department);
            Console.WriteLine("CGPA is :" + cgpa);
        }
    }
}
