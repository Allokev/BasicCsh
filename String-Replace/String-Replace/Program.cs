using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Replace
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Как насчет стихотворения?");
            string poem = Console.ReadLine();
            

            var case1 = poem.Replace("о", "а");
            var case2 = case1.Replace("л", "ль");
            var case3 = case2.Replace("о", "а");

            string[] poemArray = case3.Split(',');
            foreach (var item in poemArray)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
