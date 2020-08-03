using System;
using System.IO;
using Workout01.Entities;
using System.Globalization;

namespace Workout01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter file full path: ");
            string sourceFilePath = Console.ReadLine();

            try
            {
                string[] lines = File.ReadAllLines(sourceFilePath);

                string sourcetFolderPath = Path.GetDirectoryName(sourceFilePath);
                string targetFolderPath = sourcetFolderPath + @"\out";
                string targetFilePath = targetFolderPath + @"\summary.csv";

                Directory.CreateDirectory(targetFolderPath);

                using (StreamWriter sw = File.CreateText(targetFilePath))
                {
                    foreach (string line in lines)
                    {
                        string[] fields = line.Split(",");
                        string name = fields[0];
                        double price = Double.Parse(fields[1], CultureInfo.InvariantCulture);
                        int quantity = int.Parse(fields[2]);

                        Product prod = new Product(name, price, quantity);

                        sw.WriteLine(prod.Name + "," +prod.Total().ToString("F2", CultureInfo.InvariantCulture));
                    }
                    Console.WriteLine("Completed!");
                }
            } catch (IOException e)
            {
                Console.WriteLine("An error occurred!\n" + e.Message);
            }
        }
    }
}
