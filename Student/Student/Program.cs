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
            GPA = int.Parse(Console.ReadLine());
        }

        public override string ToString()
        {
            return this.FirstName + " " + this.LastName + " " + this.GPA;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
