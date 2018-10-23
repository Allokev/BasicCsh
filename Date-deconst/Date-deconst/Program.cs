using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date_deconst
{
    class Program
    {
        static void Main(string[] args)
        {
            var date1 = DateTime.Now;
            var (_, _, _, hour, minut, secu) = date1;
            
            Console.WriteLine($"{hour}:{minut}:{secu}");
            Console.ReadLine();
        }
        
    }
    
}
