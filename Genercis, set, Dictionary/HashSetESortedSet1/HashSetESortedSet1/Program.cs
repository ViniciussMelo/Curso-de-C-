using System;
using System.Collections.Generic;

namespace HashSetESortedSet1
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> set = new HashSet<string>();

            set.Add("TV");
            set.Add("Notebook");
            set.Add("Tablet");

            Console.WriteLine("Hash");
            foreach (var item in set)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n\nSorted:");

            SortedSet<int> a = new SortedSet<int> { 0, 2, 4, 5, 6, 8, 10 };
            SortedSet<int> b = new SortedSet<int> { 5, 6, 7, 8, 9, 10 };

            Console.Write("A: ");
            PrintCollection(a);
            Console.Write("B: ");
            PrintCollection(b);

            // union 
            SortedSet<int> c = new SortedSet<int>(a);
            c.UnionWith(b);

            Console.Write("C: ");
            PrintCollection(c);

            // intersection
            SortedSet<int> d = new SortedSet<int>(a);
            d.IntersectWith(b);

            Console.Write("D: ");
            PrintCollection(d);

            // difference
            SortedSet<int> e = new SortedSet<int>(a);
            e.ExceptWith(b);

            Console.Write("E: ");
            PrintCollection(e);
        }

        static void PrintCollection<T>(IEnumerable<T> collection)
        {
            foreach (var item in collection)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
