using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piathnashky
{
    class Program
    {
        static void Main(string[] args)
        {
            Piathnashky();

            Console.ReadLine();
        }

        private static void Piathnashky()
        {
            
            var mass = new int[3, 3];

            mass[0, 0] = 3;
            mass[0, 1] = 5;
            mass[0, 2] = 8;
            mass[1, 0] = 2;
            mass[1, 1] = 0;
            mass[1, 2] = 4;
            mass[2, 0] = 6;
            mass[2, 1] = 9;
            mass[2, 2] = 7;

            var zeroCoordOne = 1;
            var zeroCoordTwo = 1;

            mass[zeroCoordOne, zeroCoordTwo] = 0;

            Console.WriteLine("Press -- W**A**S**D to move 0 in appropriate direction");

            while (true)
            {
                Console.WriteLine();

                for (var i = 0; i < 3; i++)
                {
                    for (var j = 0; j < 3; j++) Console.Write(mass[i, j] + "    ");

                    Console.WriteLine();
                }

                Console.WriteLine();
                                
                Console.WriteLine();

                var letter = Console.ReadLine().ToUpper();

                switch (letter)
                {
                    case "W":
                        {
                            if (zeroCoordOne != 0)
                            {
                                var timeVar = mass[zeroCoordOne - 1, zeroCoordTwo];

                                mass[zeroCoordOne - 1, zeroCoordTwo] = 0;

                                mass[zeroCoordOne, zeroCoordTwo] = timeVar;

                                zeroCoordOne--;
                            }
                            else
                            {
                                Console.WriteLine("You are on edge");
                            }

                            break;
                        }

                    case "A":
                        {
                            if (zeroCoordTwo != 0)
                            {
                                var timeVar = mass[zeroCoordOne, zeroCoordTwo - 1];

                                mass[zeroCoordOne, zeroCoordTwo - 1] = 0;

                                mass[zeroCoordOne, zeroCoordTwo] = timeVar;

                                zeroCoordTwo--;
                            }
                            else
                            {
                                Console.WriteLine("You are on edge");
                            }

                            break;
                        }

                    case "S":
                        {
                            if (zeroCoordOne != 2)
                            {
                                var timeVar = mass[zeroCoordOne + 1, zeroCoordTwo];

                                mass[zeroCoordOne + 1, zeroCoordTwo] = 0;

                                mass[zeroCoordOne, zeroCoordTwo] = timeVar;

                                zeroCoordOne++;
                            }
                            else
                            {
                                Console.WriteLine("You are on edge");
                            }

                            break;
                        }
                    
                    case "D":
                        {
                            if (zeroCoordTwo != 2)
                            {
                                var timeVar = mass[zeroCoordOne, zeroCoordTwo + 1];

                                mass[zeroCoordOne, zeroCoordTwo + 1] = 0;

                                mass[zeroCoordOne, zeroCoordTwo] = timeVar;

                                zeroCoordTwo++;
                            }
                            else
                            {
                                Console.WriteLine("You are on edge");
                            }

                            break;
                        }

                }
            }
            
        }
    }
}
