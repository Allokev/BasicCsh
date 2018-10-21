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

            var (_, _, _, hours, minutes, seconds) = date1;


            Console.WriteLine($"{hours}:{minutes}:{seconds}");
            
        }
        public  class DateTimeToday
        {
            public  void Deconstruct(this DateTime date,out int yr, out int mnh, out int dy, out int hrs, out int min, out int sec)
            {
                yr = date.Year;
                mnh = date.Month;
                dy = date.Day;
                hrs = date.Hour;
                min = date.Minute;
                sec = date.Second;
            }
        }
        
        
        
        
    }
    
}
