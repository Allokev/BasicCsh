using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_4_Word_s_counting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите слово:");
            string word = Console.ReadLine();
            int count = 0;
            for(int x = 0; word.Length > x; x++)
            {
                if (word[x] == 'a'|| word[x]=='а')
                {
                    count++;
                }
            }

            Console.WriteLine("Количесвто букв А в слове {0} равно: {1}", word, count);
            Console.ReadLine();
        }
    }
}
