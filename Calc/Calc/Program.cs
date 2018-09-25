using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сумму кредита:");
            double sum = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Под какой процент?");
            double proc = Convert.ToDouble(Console.ReadLine());

            double marja = (sum / 100) * proc;
            double final = sum + marja;
            double inMonth = final / 12;

            Console.WriteLine("Выплаты по месяцам:");

            for(int Month = 1; Month <= 12; Month++)
            {
                Console.WriteLine(Month + " месяц - "+inMonth + " руб");
                
            }
            Console.ReadLine();
        }
    }
}
