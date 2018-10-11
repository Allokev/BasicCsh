using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mass = new int[5];
            for (int count = 0; count < mass.Length; count++)
            {
                mass[count] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Sort(mass);
            foreach(int item in mass)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
