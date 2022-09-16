using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    internal class Student2
    {
        public static void Main()
        {



            ArrayList list1 = new ArrayList();
            list1.Add("Raghav");
            list1.Add("Pranay");
            list1.Add("Aashi");
            list1.Add("Nitibha");
            list1.Add("Amay");



            Console.WriteLine("ArrayList before sort:");
            foreach (string i in list1)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();


            Console.WriteLine("ArrayList after sort:");


            list1.Sort();


            foreach (string i in list1)
            {
                Console.WriteLine(i);
            }
        }
    }
}
