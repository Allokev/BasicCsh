using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson__4_pr_2
{
    class Program
    {
        static void Main(string[] args)
        {
            char x;
            Console.WriteLine("Введите символ:");
            x = Convert.ToChar(Console.Read());

            switch (x)
            {
                case 'w':
                    Console.WriteLine("Сдвиньте вверх");
                    Console.ReadLine();
                    break;
                    

                case 'a':
                    Console.WriteLine("Сдвиньте влево");
                    Console.ReadLine();
                    break;

                case 's':
                    Console.WriteLine("Сдвиньте вниз");
                    Console.ReadLine();
                    break;

                case 'd':
                    Console.WriteLine("Сдвиньте вправо");
                    Console.ReadLine();
                    break;

                default:
                    Console.WriteLine("Нет необходимости в перемещении");
                    Console.ReadLine();
                    break;
                    

            }
            




        }
    }
}
