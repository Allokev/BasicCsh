using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_3x3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] mass = { { 3, 9, 5, }, { 4, 7, 8 } };
            Console.WriteLine("Максимальное значение 1-го ряда:" + mass[0, 1]);
            Console.WriteLine("Максимальное значение 2-го ряда:" + mass[1, 2]);
            Console.ReadLine();
        }
    }
}
