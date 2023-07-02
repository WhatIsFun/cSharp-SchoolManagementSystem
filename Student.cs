using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace cSharp_SchoolManagementSystem
{
    internal class Student : Person
    {
        private string StudentID;
        private string Grade;
        private List<Course> courses;

        public Student(string Name, int Age, string Birthday, string Address, string StudentID, string Grade) : base(Name, Age, Birthday, Address)
        {
            this.StudentID = StudentID;
            this.Grade = Grade;
            courses = new List<Course>();
        }
        public List<Course> Courses
        {
            get { return courses; }
        }
        public override void Display()
        {
            base.Display(); // To call the display method on Person (base) class
            Console.WriteLine("Student ID: {0}", StudentID);
            Console.WriteLine("Grade: {0}", Grade);
            Console.WriteLine("Courses enrolled:");
            foreach (Course course in courses)
            {
                Console.WriteLine(course.Title);
            }
        }
        public void Enroll(Course course)
        {
            if (!courses.Contains(course)) // Check if the course is not already in the list
            {
                courses.Add(course); // Add the course to the list
                Console.WriteLine("{0} enrolled in {1}", Name, course.Title);
            }
            else
            {
                Console.WriteLine("{0} is already enrolled in {1}", Name, course.Title);
            }
        }
    }

}
