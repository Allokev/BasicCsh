using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date_deconst
{
    static class ExMetod
    {
        public static void Deconstruct(this DateTime date, out int yr, out int mnh, out int dy, out int hour, out int minut, out int secu)
        {
                yr = date.Year;
                mnh = date.Month;
                dy = date.Day;
                hour = date.Hour;
                minut = date.Minute;
                secu = date.Second;
        }
        
    }
}
