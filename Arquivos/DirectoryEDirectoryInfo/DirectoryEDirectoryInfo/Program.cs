using System;
using System.IO;
using System.Collections.Generic;

namespace DirectoryEDirectoryInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\temp\myfolder";

            try
            {
                IEnumerable<string> folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FOLDERS:");

                foreach (string folder in folders)
                {
                    Console.WriteLine(folder);
                }

                IEnumerable<string> files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FILES:");

                foreach (string file in files)
                {
                    Console.WriteLine(file);
                }

                Directory.CreateDirectory(path + @"\newfolder");
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred!\n" + e.Message);
            }
        }
    }
}
