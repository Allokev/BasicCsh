using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_4_Cicle_For
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int x = 10; x >= 0; x--)
            {
                if (x % 2 == 0)
                {
                    if (x == 0)
                    {
                        Console.WriteLine(x+" - Это ноль");
                    }
                    else
                    {
                        Console.WriteLine(x + " - Четное");
                    }
                    
                    
                }
                else
                {
                    Console.WriteLine(x + " - Нечетное");
                }
                
               
                
            }
            Console.ReadLine();
            
        }
    }
}
