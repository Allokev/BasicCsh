using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_word
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите слово:");
            string word = Console.ReadLine();
            
            for (int number = word.Length-1; number >= 0; number--)
            {
                Console.Write(word[number]);
                
            }
            Console.ReadLine();
        }
    }
}
