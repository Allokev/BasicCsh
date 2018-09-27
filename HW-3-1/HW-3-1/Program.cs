using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_3_1
{
    class Program
    {
        static void Summ()
        {

            Console.WriteLine("Введите первое число:");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите второе число:");
            double y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите их сумму:");
            double z = Convert.ToDouble(Console.ReadLine());

            if(z == y + x)
            {
                Console.Write("Ответ правильный");
            }
            else
            {
                Console.Write("Ответ неправильный");
            }
            
            Console.Read();

        }
        static void Main(string[] args)
        {
            Summ();
        }
    }
}
