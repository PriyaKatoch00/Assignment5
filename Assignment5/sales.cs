using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    abstract class sales
    {
        public abstract int sale(int dailysale);
        public int monthlysale(int dailysale)
        {
            return dailysale;
        }


    }
    interface yearlysale
    {
        public int yearlysales(int dailysale);

    }
    class sold : sales
    {
        public override int sale(int dailysale)
        {
            return dailysale * 30;
        }
        public void showdata(int dailysale)
        {
            Console.WriteLine("Monthly Sale: " + sale(dailysale));
        }

    }
    class sale : yearlysale
    {

        public int yearlysales(int dailysale)
        {
            return dailysale * 365;
        }
        public void showdata(int dailysale)
        {
            Console.WriteLine("Monthly Sale:" + yearlysales(dailysale));
        }
    }
    class Abstract
    {
        static void Main()
        {
            Console.WriteLine("Enter daily sales");
            int dailysale = int.Parse(Console.ReadLine());
            sold obj = new sold();
            sale obj2 = new sale();
            obj.sale(dailysale);
            obj.showdata(dailysale);
            obj2.showdata(dailysale);
        }
    }
}