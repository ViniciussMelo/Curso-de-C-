using System;
using System.IO;

namespace UsingBlock
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\temp\file1.txt";
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        Console.WriteLine(sr.ReadLine());
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred!\n" + e.Message);
            }
        }
    }
}
