using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coordinates
{
    class Program
    {
        static void Main(string[] args)
        {
            Coordinates coord = new Coordinates();

            Console.Write("Введите координату x: ");
            double.TryParse(Console.ReadLine(),out coord.x);

            Console.Write("Введите координату y: ");
            double.TryParse(Console.ReadLine(), out coord.y);

            Console.Write("Введите координату z: ");
            double.TryParse(Console.ReadLine(), out coord.z);
            var (x, y, z) = coord;
            Console.WriteLine($"Длина вектора равна: {Math.Sqrt(Math.Pow(x,2)+Math.Pow(y,2)+Math.Pow(z,2))}");
            Console.ReadLine();
        }
        struct Coordinates
        {
            public double x;
            public double y;
            public double z;

            public void Deconstruct(out double X, out double Y, out double Z)
            {
               X = this.x;
               Y = this.y;
               Z = this.z;
            }
        }
    }
}
