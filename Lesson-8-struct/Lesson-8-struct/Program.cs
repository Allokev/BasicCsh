using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_8_struct
{
    class Program
    {
        static void Main(string[] args)
        {
            Structure();
        }
        struct LetterE
        {
            string[,] eLetter;
            public LetterE(string[,] eLetter)
            {
                this.eLetter = eLetter;
            }
        }

        
        
            public static void Structure()
            {
                string[,] eLetter = new string[4, 4] {
                { "", "-", "-","-" },
                { "", "|", " ", " " },
                { "", "|", "-", "-" },
                { "", "_", "_", "_" }
                    
            };
            foreach (var item in eLetter)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
             


           }

    }
}
