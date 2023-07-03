namespace cSharp_SchoolManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create instances of students
            Student student1 = new Student("Mr.Krabs", 18, "3 May 1998","Al Seeb", "1100", "12");
            Student student2 = new Student("Sandy", 17, "30 Jun 1999", "Al Seeb", "1202", "11");

            // Create instances of teachers
            Teacher teacher1 = new Teacher("Mrs. Puff", 30, "13 Jul 1989", "Nizwa", "73203");
            Teacher teacher2 = new Teacher("Gary", 50, "20 Aug 1978", "Ibri", "8559");

            // Create instances of courses
            Course course1 = new Course(3001, "Mathematics", "Learn about algebra, geometry, calculus and more");
            Course course2 = new Course(3002, "English", "Learn about grammar, literature, writing and more");
            Course course3 = new Course(3003, "Science", "Learn about physics, chemistry, biology and more");

            Console.WriteLine("    Welcome To    ");
            Console.WriteLine(" +-+-+-+-+-+-+-+-+-+\r\n |W|h|a|t|I|s|F|u|n|\r\n +-+-+-+-+-+-+-+-+-+");
            Console.WriteLine("School Management System\n");
            // Display the details of students
            Console.WriteLine("Students:");
            student1.Display();
            Console.WriteLine();
            student2.Display();
            Console.WriteLine();
            Console.WriteLine("_____________________");

            // Display the details of teachers
            Console.WriteLine("Teachers:");
            teacher1.Display();
            Console.WriteLine();
            teacher2.Display();
            Console.WriteLine();
            Console.WriteLine("_____________________");

            // Display the details of courses
            Console.WriteLine("Courses:");
            course1.Display();
            Console.WriteLine();
            course2.Display();
            Console.WriteLine();
            course3.Display();
            Console.WriteLine();
            Console.WriteLine("_____________________");

            // Enroll students in courses
            Console.WriteLine("Enrolling students in courses:");
            student1.Enroll(course1);
            student1.Enroll(course2);
            student2.Enroll(course2);
            student2.Enroll(course3);
            Console.WriteLine("_____________________");
            Console.WriteLine();


            // Assign teachers to courses
            Console.WriteLine("Assigning teachers to courses:");
            course1.Assign(teacher1);
            course2.Assign(teacher2);
            course3.Assign(teacher1);
            Console.WriteLine("_____________________");
            Console.WriteLine();

            // Display the updated course and student/teacher details
            Console.WriteLine("Updated course details:");
            course1.Display();
            Console.WriteLine();
            course2.Display();
            Console.WriteLine();
            course3.Display();
            Console.WriteLine();
            Console.WriteLine("_____________________");

            Console.WriteLine("Updated student details:");
            student1.Display();
            Console.WriteLine();
            student2.Display();
            Console.WriteLine();
            Console.WriteLine("_____________________");

            Console.WriteLine("Updated teacher details:");
            teacher1.Display();
            Console.WriteLine();
            Console.WriteLine("_____________________");
        }
    }
}
    
