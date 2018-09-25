using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    class Program
    {
        static void Main(string[] args)
        {
            double p = 3.14;
           
            Console.WriteLine("Введите радиус круга");
            double r = Convert.ToDouble(Console.ReadLine());

            double s = p * (r * r);
            Console.WriteLine("Площадь круга равна:" + s);
            Console.ReadLine();

        }
    }
}
