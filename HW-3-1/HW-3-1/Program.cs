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
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите второе число:");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.Write("В сумме:" + (x + y));
            Console.Read();

        }
        static void Main(string[] args)
        {
            Summ();
        }
    }
}
