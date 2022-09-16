using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    internal class Program2
    {
        public static void Main(string[] args)
        {
            SortedDictionary<int, string> arr = new SortedDictionary<int, string>();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter Employee ID & name:");
                int EmpID = int.Parse(Console.ReadLine());
                string EmpName = Console.ReadLine();
                arr.Add(EmpID, EmpName);
            }

            Console.WriteLine("Employee List:");
            foreach (int i in arr.Keys)
            {
                Console.WriteLine(i + " " + arr[i]);
            }
        }
    }
}
