using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math
{
    class Program
    {
        static void Main(string[] args)
        {
            var poem = new ArrayList();
            
            int count = 0;
            
            

            for (count = 0; count < 5; count++)
            {
                Console.WriteLine("Введите строку стихотворения:");
                var song = new Song();
                song.Lyrics = Console.ReadLine();
                poem.Add(song);
                
                
            }

            poem.Sort();

            poem.RemoveAt(poem.Count - 1);

            object[] myArray = poem.ToArray();

            foreach (var item in myArray)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
        public class Song
        {
            public string Lyrics;

            public override string ToString()
            {
                return this.Lyrics;
            }

        }
    }
}
