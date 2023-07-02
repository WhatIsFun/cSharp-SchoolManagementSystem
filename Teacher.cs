using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace cSharp_SchoolManagementSystem
{
    internal class Teacher
    {
        private int teacherId;
        private List<string> subjects;

        // Define a constructor to initialize these fields and call the base class constructor
        public Teacher(string name, int age, string address, int teacherId) : base(name, age, address)
        {
            this.teacherId = teacherId;
            subjects = new List<string>(); // Create an empty list of subjects
        }
        public override void Display()
        {
            base.Display(); // Call the base class display method
            Console.WriteLine("Teacher ID: {0}", teacherId);
            Console.WriteLine("Subjects assigned:");
            foreach (string subject in subjects)
            {
                Console.WriteLine(subject);
            }
        }
        public void Assign(string subject)
        {
            if (!subjects.Contains(subject)) // Check if the subject is not already in the list
            {
                subjects.Add(subject); // Add the subject to the list
                Console.WriteLine("{0} assigned to teach {1}", Name, subject);
            }
            else
            {
                Console.WriteLine("{0} is already assigned to teach {1}", Name, subject);
            }
        }

    }
}
