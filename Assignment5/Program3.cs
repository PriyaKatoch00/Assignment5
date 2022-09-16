using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    internal class Program3
    {
        public static void Main(string[] args)
        {
            List<List<string>> employees = new List<List<string>>();
            for (int i = 0; i < 5; i++) employees.Add(new List<string>());
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Enter Name & Designation");
                string name = Console.ReadLine();
                string desg = Console.ReadLine();
                if (desg.Equals("Program Manager")) employees[0].Add(name);
                else if (desg.Equals("Project Manager")) employees[1].Add(name);
                else if (desg.Equals("Team Lead")) employees[2].Add(name);
                else if (desg.Equals("Senior Programmer")) employees[3].Add(name);
                else employees[4].Add(name);
            }

            foreach (List<string> emp in employees)
            {
                foreach (string e in emp) Console.WriteLine(e);
            }
        }
    }
}
