using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADWLesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            //AL3();
            Console.ReadLine();
        }
        public static void AL34()
        {
            GuessType("Hello");
            GuessType(545);
            GuessType(new Car() { fuel = 50});
        }

        public static void GuessType<T>(T item)
        {
            switch (item)
            {
                case string str:
                    {
                        Console.WriteLine($"You past string with length{str.Count()}");
                        break;
                    }
                case int number:
                    {
                        Console.WriteLine($"You past number{number}");
                        break;
                    }
                case Car car:
                    {
                        Console.WriteLine($"Your past car with fuel{car.fuel}");
                        break;
                    }
                default:
                    break;
            }
        }
        //public static void AL3()
        //{
        //    var student1 = new Student() { name = "Vanya"};
        //    var student2 = new Student() { name = "Vanya"};

        //    students.Add(student1);
        //    students.Add(student2);

        //    for (int i = 0; i < 100; i++)
        //    {
        //        students.Add(new Student() { name = i.ToString() });
        //    }

        //    foreach (Student item in students)
        //    {
        //        Console.WriteLine($"{item.name}:{item.id}");
        //    }
        //}
        //class Student
        //{
        //    private static int nextId { get; set; }
        //    public int id { get; private set; }
        //    public string name { get; set; }

        //    static Student()
        //    {
        //        if (true)
        //        {
        //            nextId = 1000000;
        //        }
        //        else nextId = 0;
        //    }

        //    public Student()
        //    {
        //        id = nextId;
        //        nextId++;
        //    }
        //}
        //static List<Student> students = new List<Student>();
    }
}
