using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4_pr
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое значение:");
            int x = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Введите второе значение:");
            int y = Convert.ToInt32(Console.ReadLine());

            if (y >= 0 || x >= 0)
            {

                if (x == y)
                {
                    Console.WriteLine("Значеня равны");
                }
                if (x > y)
                {
                    Console.WriteLine("Значение x больше y на:" + (x - y));
                }
                if (x < y)
                {
                    Console.WriteLine("Значение x меньше y на:" + (y - x));
                }
            }
            else
            {
                Console.WriteLine("Отрицательное значение ");

                Console.ReadLine();
            }
            Console.ReadLine();

        }
    }
}
