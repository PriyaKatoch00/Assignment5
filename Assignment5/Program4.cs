using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    class Student
    {
        public int RollNo, CurrClass;
        public string Name;
        public char Sec;

    }
    internal class Program4
    {
        public static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter RollNo, Name, Class & Section");
                int RollNo = int.Parse(Console.ReadLine());
                string Name = Console.ReadLine();
                int CurrClass = int.Parse(Console.ReadLine());
                char Sec = Convert.ToChar(Console.ReadLine());
                students.Add(new Student() { RollNo = RollNo, Name = Name, CurrClass = CurrClass, Sec = Sec });
            }
            Console.WriteLine("Student Details");
            foreach (Student s in students)
            {
                Console.WriteLine($"{s.Name} {s.RollNo} {s.CurrClass} {s.Sec}");
            }
        }
    }
}
