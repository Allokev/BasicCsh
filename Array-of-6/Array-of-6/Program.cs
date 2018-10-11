using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_of_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstArray = new int[6];

            for (int count = 0; count < 6; count++)
                
                firstArray[count] = Convert.ToInt32(Console.ReadLine());
            foreach (int x in firstArray)
            {
                
                Console.WriteLine("Вывод: {0}",x);
                
            }
            Console.ReadLine();
        }

        
    }
}
