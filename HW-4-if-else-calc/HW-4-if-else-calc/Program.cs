using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_4_if_else_calc
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите число 1:");
            double number1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите число 2:");
            double number2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите арифметический оператор:");
            char symbol = Convert.ToChar(Console.ReadLine());




            if (symbol == '+') Console.WriteLine("Результат: " + (number1 + number2));
            else

            if (symbol == '-') Console.WriteLine("Результат: " + (number1 - number2));

            if (symbol == '*') Console.WriteLine("Результат: " + (number1 * number2));
            else

            if (symbol == '/') Console.WriteLine("Результат: " + (number1 / number2));

            Console.ReadLine();




        }
            

        
    }
}
