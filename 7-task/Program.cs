using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_task
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] people = { "Tom", "Sam", "Bob", "Kate", "Tom", "Alice"};

            Array.Sort(people, 1, 3);
            foreach (var item in people)
            {
                Console.WriteLine(item);
            }

            //string first = Array.Find(people, person => person.Length > 3);
            //Console.WriteLine(first);
            //string last = Array.FindLast(people, person => person.Length > 3);
            //Console.WriteLine(last);
            //string[] all = Array.FindAll(people, person => person.Length <= 3);
            //foreach (var item in all)
            //{
            //    Console.WriteLine(item);
            //}
            Console.ReadKey();
            
        }
    }
}
