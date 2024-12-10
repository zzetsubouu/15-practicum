using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_task
{
    /// <summary>
    /// Задача 10. Удаление всех четных элементов из массива, и в новом массиве сложить элементы.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int[] omas = { 3, 2, 7, 5, 4, 8, 1, 9, 5 };
            omas = omas.Where(x => x % 2 != 0).ToArray();
            foreach (var item in omas)
            {
                Console.WriteLine(item);
            }
            int sum = omas.Sum();
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
