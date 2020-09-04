using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Workout02.Entities;

namespace Workout02
{
    class Program
    {

        static void Main(string[] args)
        {
            HashSet<Student> set = new HashSet<Student>();

            Console.Write("How many students for course A? ");
            int totalA = int.Parse(Console.ReadLine());
            Print(totalA, set);

            Console.Write("How many students for course B? ");
            int totalB = int.Parse(Console.ReadLine());
            Print(totalB, set);

            Console.Write("How many students for course C? ");
            int totalC = int.Parse(Console.ReadLine());
            Print(totalC, set);

            Console.WriteLine("Total students: " + set.Count);
        }

        static void Print(int count, HashSet<Student> set)
        {
            for (int i = 0; i < count; i++)
            {
                Console.Write("Enther the " + (i + 1) + "º Id: ");
                int id = int.Parse(Console.ReadLine());
                set.Add(new Student { Id = id });
            }
        }
    }
}
