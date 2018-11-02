using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Market.Domains;

namespace Market
{
    class Program
    {
        static void Main(string[] args)
        {
            Products prodi = new Products();

            prodi.ProductWithChar();

            Console.ReadLine();
        }
    }
}
