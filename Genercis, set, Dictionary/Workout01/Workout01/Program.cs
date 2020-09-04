using System;
using System.Collections.Generic;
using System.IO;
using Workout01.Entities;

namespace Workout01
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<User> set = new HashSet<User>();

            Console.Write("Enther the full path: ");
            string path = Console.ReadLine();

            try
            {
                using(StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(' ');
                        string name = line[0];
                        DateTime instant = DateTime.Parse(line[1]);

                        set.Add(new User{ Username = name, Instant = instant});
                    }
                    Console.WriteLine("Total users: " + set.Count);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
