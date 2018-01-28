using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class Student
    {
        public string FirstName;
        public string LastName;
        public double GPA;

        public void WriteFirstName()
        {
            FirstName = Console.ReadLine();   
        }

        public void WriteLastName()
        {
            LastName = Console.ReadLine();
        }

        public void WriteGPA()
        {
            GPA = double.Parse(Console.ReadLine());
        }

        public override string ToString()
        {
            return FirstName + " " + LastName + " " + GPA;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.WriteFirstName();
            s.WriteLastName();
            s.WriteGPA();

            Console.WriteLine("Student");
            Console.WriteLine(s);

            Console.ReadKey();
        }
    }
}
