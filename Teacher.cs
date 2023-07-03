using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace cSharp_SchoolManagementSystem
{
    internal class Teacher :Person
    {
        public string TeacherID;
        public List<string> subjects;

        public Teacher(string Name, int Age, string Birthday, string Address, string TeacherID) : base(Name, Age, Birthday, Address)
        {
            this.TeacherID = TeacherID;
            subjects = new List<string>(); 
        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine("Teacher ID: {0}", TeacherID);
            Console.WriteLine("Subjects assigned:");
            foreach (string subject in subjects)
            {
                Console.WriteLine(subject);
            }
        }
        public void Assign(string subject)
        {
            if (!subjects.Contains(subject)) // To check if the subject in the list
            {
                subjects.Add(subject); 
                Console.WriteLine("{0} assigned to teach {1}", Name, subject);
            }
            else
            {
                Console.WriteLine("{0} is already assigned to teach {1}", Name, subject);
            }
        }

    }
}
