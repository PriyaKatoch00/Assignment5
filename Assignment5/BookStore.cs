using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace Assignment5
{
    class Book
    {
        public int BookID;
        public string BookName;
    }
    internal class BookStore
    {
        static void Main(string[] args)
        {
            Hashtable hs = new Hashtable();
            hs.Add(1111, "The Alchemist");
            hs.Add(2189, " The Monk who sold Ferrari");
            hs.Add(1673, " Dino Comics");
            hs.Add(3267, " Three Thousand Stiches");

            string name = hs[2189] as string;

            foreach(var x in hs.Keys)
            {
                Console.WriteLine("Key: {0}  Value: {1}", x, hs[x]);
            }
            foreach (DictionaryEntry d  in hs)
            {
                Console.WriteLine("Key: {0}  Value: {1}", d.Key, d.Value);
            }

        }
    }
}
