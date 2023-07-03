using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharp_SchoolManagementSystem
{
    internal class Course
    {
        public int CourseId;
        public string Title;
        public string Description;
        public Teacher Teacher;

        // Define a constructor to initialize these fields
        public Course(int CourseId, string Title, string Description)
        {
            this.CourseId = CourseId;
            this.Title = Title;
            this.Description = Description;
            Teacher = null; // Set the teacher to null initially
        }
        public void Display()
        {
            Console.WriteLine("Course ID: {0}", CourseId);
            Console.WriteLine("Title: {0}", Title);
            Console.WriteLine("Description: {0}", Description);
            if (Teacher != null) // Check if the teacher is not null
            {
                Console.WriteLine("Teacher: {0}", Teacher.Name);
            }
            else
            {
                Console.WriteLine("Teacher: Not assigned");
            }
        }
        public void Assign(Teacher teacher)
        {
            if (this.Teacher == null) // Check if the course has no teacher assigned
            {
                this.Teacher = teacher; // Assign the teacher to the course
                Console.WriteLine("{0} assigned to teach {1}", teacher.Name, Title);
            }
            else
            {
                Console.WriteLine("{0} is already assigned to teach {1}", this.Teacher.Name, Title);
            }
        }
    }
}
