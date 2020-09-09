using ConsoleApplication1.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> emp = new List<Employee>();

            Console.Write("Enter the full path: ");
            string path = Console.ReadLine();

            Console.Write("Enter the salary: ");
            double refSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(',');
                        string name = line[0];
                        string email = line[1];
                        double salary = double.Parse(line[2], CultureInfo.InvariantCulture);

                        emp.Add(new Employee(name, email, salary));
                    }
                }
                Console.WriteLine("");

                List<string> emails = emp.Where(p => p.Salary > refSalary).OrderBy(p => p.Name).Select(p => p.Email).ToList();
                Console.WriteLine("Email of people whose salary is more than " + refSalary.ToString("F2", CultureInfo.InvariantCulture) + ": ");
                
                foreach (String email in emails)
                {
                    Console.WriteLine(email);
                }
                
                Console.WriteLine("");
                double avg = emp.Where(p => p.Name[0] == 'M').Select(p => p.Salary).Sum();
                Console.WriteLine("Sum of salary of people whose name starts with 'M': " + avg.ToString("F2", CultureInfo.InvariantCulture));
            }
            catch (IOException exp)
            {
                Console.WriteLine(exp.Message);
            }
        }
    }
}
