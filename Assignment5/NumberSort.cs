using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    internal class NumberSort
    {
        public static void Main()
        {
            List<int> arr = new List<int>();
            Console.WriteLine("Enter 10 numbers");
            for (int i = 0; i < 10; i++) arr.Add(int.Parse(Console.ReadLine()));
            arr.Sort();
            Console.WriteLine("Numbers after sort:");
            foreach (int i in arr)
            { Console.WriteLine(i);
        }
    }
}


   
}
