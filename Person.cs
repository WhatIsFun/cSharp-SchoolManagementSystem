using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharp_SchoolManagementSystem
{
    internal class Person
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        public string Birthday { get; set; }

        public Person(string Name, int Age, string Birthday, string Address)
        {
            this.Name = Name;
            this.Age = Age;
            this.Birthday = Birthday;
            this.Address = Address;
        }

        public virtual void Display()
        {
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("Age: {0}", Age);
            Console.WriteLine("Address: {0}", Address);
            Console.WriteLine("Birthday: {0}", Birthday);

        }
    }
}
