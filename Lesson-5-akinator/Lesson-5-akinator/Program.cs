using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_5_akinator
{
    class Program
    {
        static void Main(string[] args)
        {
            int middle = 50;
            int middleH = 25;
            

            

            while (true)
            {
                Console.WriteLine("Если ваше число больше {0}, поставьте >,если меньше - <, если равно - =", middle);
                char input = Convert.ToChar(Console.ReadLine());

                if (input == '>')
                {
                    middle = middle + middleH;
                }
                else if(input == '<')
                {
                    middle = middle - middleH;
                }
                else if(input == '=')
                {
                    Console.WriteLine("Ваше число {0}", middle);
                }
                middleH = middleH / 2 + 1;
                
            }
            Console.ReadLine();

        }
    }
}
