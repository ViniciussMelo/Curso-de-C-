﻿using InterfaceIComparable.entities;
using System;
using System.Collections.Generic;
using System.IO;

namespace InterfaceIComparable
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\temp\in.txt";

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    List<Employee> list = new List<Employee>();
                    while (!sr.EndOfStream)
                    {
                        list.Add(new Employee(sr.ReadLine()));
                    }
                    list.Sort();
                    foreach (Employee emp in list)
                    {
                        Console.WriteLine(emp);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred \n" + e.Message);
            }
        }
    }
}
