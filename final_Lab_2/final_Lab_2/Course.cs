using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final_Lab_2
{
    class Course : Student
    {
        string courseName;
        string courseCode;
        int courseCredit;

        private Student[] students;

        public Course()
        {
            this.students = new Student[30];
        }

        public Course(string courseName, string courseCode, int courseCredit)
        {
            this.courseName = courseName;
            this.courseCode = courseCode;
            this.courseCredit = courseCredit;
            this.students = new Student[30];
        }

        public string CourseName
        {
            set { courseName = value; }
            get { return courseName; }
        }

        public string CourseCode
        {
            set { courseCode = value; }
            get { return courseCode; }
        }

        public int CourseCredit
        {
            set { courseCredit = value; }
            get { return courseCredit; }
        }

        public int StudentCount { get; set; }


        public void AddStudent(params Student[] student)
        {
            foreach (Student s in student)
            {
                if (this.StudentCount < 30 && s.CourseCount < 5)
                {
                    this.students[this.StudentCount++] = s;
                    if (s.GetCourse(this.Id)==null)
                    s.AddCourse(this);
                }
            }
        }
        public void RemoveStudent(Student s)
        {
            if (s == this.students[this.StudentCount - 1])
            {
                this.students[this.StudentCount--] = null;
                s.RemoveCourse(this);
                return;
            }
            bool notFound = true;
            for (int i = 0; i < this.StudentCount - 1; ++i)
            {
                if (s == this.students[i] && notFound)
                {
                    this.students[i] = null;
                    this.StudentCount--;
                    s.RemoveCourse(this);
                    notFound = false;
                }
                if (!notFound)
                    this.students[i] = this.students[i + 1];
            }
        }
        public Student GetStudent(string id)
        {
            for (int i = 0; i < this.StudentCount; ++i)
                if (id == this.students[i].Id)
                    return this.students[i];

            return null;
        }
        public void PrintStudent()
        {
            for (int i = 0; i < this.StudentCount; ++i)
            {
                this.students[i].ShowInfo();
            }
        }



        public void ShowCourseInfo()
        {
            Console.WriteLine("Course Name is: " + courseName);
            Console.WriteLine("Course Code is: " + courseCode);
            Console.WriteLine("Course Cresit is: " + courseCredit);
        }
    }
}
