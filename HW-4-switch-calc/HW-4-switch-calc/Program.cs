using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_4_switch_calc
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

            switch (symbol)
            {
                case '+':
                    Console.WriteLine("Результат: " + (number1 + number2));
                    break;

                case '-':
                    Console.WriteLine("Результат: " + (number1 - number2));
                    break;

                case '*':
                    Console.WriteLine("Результат: " + (number1 * number2));
                    break;

                case '/':
                    Console.WriteLine("Результат: " + (number1 / number2));
                    break;

            }
            Console.ReadLine();
        }
    }
}
