using System;
using System.Collections.Generic;
using System.IO;

namespace Workout03
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dictionary = new Dictionary<string, int>();

            Console.Write("Enter the full path: ");
            string path = Console.ReadLine();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while(!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(",");
                        string name = line[0].ToUpper();
                        int quantity = int.Parse(line[1]);

                        if (dictionary.ContainsKey(name))
                        {
                            dictionary[name] += quantity;
                        } else
                        {
                            dictionary.Add(name, quantity);
                        }
                    }
                }

                foreach (var item in dictionary)
                {
                    Console.WriteLine(item.Key + ": " + item.Value);
                }
            }
            catch (IOException exp)
            {
                Console.WriteLine(exp.Message);
            }
        }
    }
}
