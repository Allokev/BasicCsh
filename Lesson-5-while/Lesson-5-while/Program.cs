using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_5_while
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите степень:");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите число для степени:");
            int number2 = Convert.ToInt32(Console.ReadLine());
            int r = 1;
            int count = 1;

            do
            {
               
                r = r * number2;
                
            } while (count++ < number1);
            Console.WriteLine("Результат: "+r);
            Console.ReadLine();
        }
    }
}
