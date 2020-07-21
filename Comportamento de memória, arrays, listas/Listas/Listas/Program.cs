using System;
using System.Collections.Generic;

namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            list.Add("Vinicius");
            list.Add("Teste");
            list.Add("Wesley");
            list.Add("Matheus");
            list.Insert(1, "Marco");

            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("\nList count: " + list.Count);

            string s1 = list.Find(name => name[0] == 'M');
            Console.WriteLine("\nFirst 'M': " + s1);

            string s2 = list.FindLast(name => name[0] == 'M');
            Console.WriteLine("\nLast 'M': " + s2);

            int pos1 = list.FindIndex(name => name[0] == 'M');
            Console.WriteLine("\nFirst position: " + pos1);

            int pos2 = list.FindLastIndex(name => name[0] == 'M');
            Console.WriteLine("\nLast position: " + pos2);

            Console.WriteLine("\nNames with length 5: ");
            List<string> result = list.FindAll(name => name.Length == 5);
            foreach (string obj in result)
            {
                Console.WriteLine(obj);
            }
            
            Console.WriteLine("\nRemove 'Marco'");
            list.Remove("Marco");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("\nRemove all");
            list.RemoveAll(name => name[0] == 'M');
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("\nRemove at");
            list.RemoveAt(2);
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("\nRemove range");
            list.RemoveRange(1, 1);
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
