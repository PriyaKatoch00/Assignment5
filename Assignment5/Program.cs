using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    interface GovtRules
    {
        public double employeepf(double basicsalary);
        public void leavedetails();

        public double gratuity(float serviceCompleted, double basicsalary);

    }
    class TCS : GovtRules
    {
        public int empid;
        public string name;
        public string dept;
        public string desg;
        public double basicsalary;
        public float serviceCompleted;

        public TCS(int empid, string name, string dept, string desg, double basicsalary, float serviceCompleted)
        {
            this.empid = empid;
            this.name = name;
            this.dept = dept;
            this.desg = desg;
            this.basicsalary = basicsalary;
            this.serviceCompleted = serviceCompleted;
        }
        public double employeepf(double basicsalary)
        {
            double x, y, z;
            x = (12 * basicsalary) / 100;
            y = (8.33 * basicsalary) / 100;
            z = (3.67 * basicsalary) / 100;
            return x + y + z;

        }
        public void leavedetails()
        {
            Console.WriteLine("Casual leaves per month = 1 day");
            Console.WriteLine("Sick leaves per year= 12 days");
            Console.WriteLine("Privilege leaves =10 days");
        }

        public double gratuity(float serviceCompleted, double basicsalary)
        {
            if (serviceCompleted < 5)
            {
                return 0.0;
            }
            else if (serviceCompleted > 5 && serviceCompleted < 10)
            {
                return basicsalary;
            }
            else if (serviceCompleted > 10 && serviceCompleted < 20)
            {
                return 2 * basicsalary;
            }
            else if (serviceCompleted > 20)
            {
                return 3 * basicsalary;
            }
            else
            {
                return 0.0;
            }
        }
        public void showdata()
        {
            Console.WriteLine("EMPID:" + empid);
            Console.WriteLine("Name:" + name);
            Console.WriteLine("Departement:" + dept);
            Console.WriteLine("Designation:" + desg);
            Console.WriteLine("Pension fund : " + employeepf(basicsalary));
            Console.WriteLine("Gratuity :" + gratuity(serviceCompleted, basicsalary));

        }
    }
    class Accenture : GovtRules
    {
        public int empid;
        public string name;
        public string dept;
        public string desg;
        public double basicsalary;
        public float serviceCompleted;

        public Accenture(int empid, string name, string dept, string desg, double basicsalary, float serviceCompleted)
        {
            this.empid = empid;
            this.name = name;
            this.dept = dept;
            this.desg = desg;
            this.basicsalary = basicsalary;
            this.serviceCompleted = serviceCompleted;
        }
        public double employeepf(double basicsalary)
        {
            double x, y;
            x = (12 * basicsalary) / 100;
            y = (12 * basicsalary) / 100;

            return x + y;

        }
        public void leavedetails()
        {
            Console.WriteLine("Casual leaves per month = 2 days");
            Console.WriteLine("Sick leave per year= 5 days");
            Console.WriteLine("Privilege leave =5 days");
        }
        public double gratuity(float serviceCompleted, double basicsalary)
        {
            return 0.0;
        }
        public void showdata()
        {
            Console.WriteLine("EMPID:" + empid);
            Console.WriteLine("Name:" + name);
            Console.WriteLine("Departement:" + dept);
            Console.WriteLine("Designation:" + desg);
            Console.WriteLine("Pension fund : " + employeepf(basicsalary));
            Console.WriteLine("Gratuity:" + gratuity(serviceCompleted, basicsalary));

        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {




            int empid;
            string name;
            string dept;
            string desg;
            double basicsalary; ;
            float serviceCompleted;
            Console.WriteLine("Enter empID of Employee");
            empid = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Name of Employee");
            name = Console.ReadLine();
            Console.WriteLine("Enter Departement of Employee");
            dept = Console.ReadLine();
            Console.WriteLine("Enter Designation of Employee");
            desg = Console.ReadLine();
            Console.WriteLine("Enter Basic salary of Employee");
            basicsalary = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter years of service completed");
            serviceCompleted = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Company");
            string comp = Console.ReadLine();
            string c1 = "TCS";
            string c2 = "Accenture";

            GovtRules obj = new TCS(empid, name, dept, desg, basicsalary, serviceCompleted);

            TCS obj1 = new TCS(empid, name, dept, desg, basicsalary, serviceCompleted);

            Accenture obj2 = new Accenture(empid, name, dept, desg, basicsalary, serviceCompleted);
            if (comp == c1)
            {
                obj1.showdata();
                obj1.leavedetails();

            }
            else if (comp == c2)
            {
                obj2.showdata();
                obj2.leavedetails();

            }
            else
            {
                Console.WriteLine("Invalid Company");
            }


        }

    }
}
