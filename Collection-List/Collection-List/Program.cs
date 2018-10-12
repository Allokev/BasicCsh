using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_List
{
    class Program
    {

        static void Main(string[] args)
        {
            //ArrayListPoem();
            NeighborCollection();
            Console.ReadLine();
        
        }

        public static void ArrayListPoem()
        {
            List<Song> poem = new List<Song>();
            for (int i = 0; i < 5; i++)
            {
                var song = new Song();
                Console.Write("Введите строку:");
                song.Lyrics = Console.ReadLine();
                poem.Add(song);
            }

            //poem.Sort();
            //poem.RemoveAt(poem.Count - 1);

            object[] poemArray = poem.ToArray();

            foreach (var item in poemArray)
            {
                Console.WriteLine(item);
            }
        }

        public class Song
        {
            public string Lyrics;
            public override string ToString()
            {
                return this.Lyrics;
            }
        }
        
        public class Neighbor
        {
            public string FullName { get; set; }
            public string FlatNumber { get; set; }
            public int PhoneNumber { get; set; }

            public override string ToString()
            {
                return "Имя: " + FullName + " Номер телефона: " + PhoneNumber;
            }

        }
        public static void NeighborCollection()
        {
            Neighbor valNei = new Neighbor();
            List<Neighbor> floorNeighbors = new List<Neighbor>();

            floorNeighbors.Add(new Neighbor() { FullName = "Дмитрий", FlatNumber = "203", PhoneNumber = 2488901 });
            floorNeighbors.Add(new Neighbor() { FullName = "Елена", FlatNumber = "202", PhoneNumber = 2474503 });
            floorNeighbors.Add(new Neighbor() { FullName = "Владислав", FlatNumber = "204", PhoneNumber = 2436234 });

            Console.Write("Введи номер квартиры соседа:");
            string number = Convert.ToString(Console.ReadLine());
            Console.Write("Его данные - {0}", floorNeighbors.Find(x => x.FlatNumber.Contains(number)));
            
            
            /*foreach (var item in floorNeighbors)
            {
                Console.WriteLine(item);
            }*/
        }










    }
    
}
