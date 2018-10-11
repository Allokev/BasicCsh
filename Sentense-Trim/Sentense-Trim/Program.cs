using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sentense_Trim
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение:");
            string sentense = Console.ReadLine();
            int number = sentense.Length;
            if (number > 13)
                sentense = sentense.Remove(13);

            Console.WriteLine(sentense+"...");
            Console.ReadLine();
                    
        }
    }
}
