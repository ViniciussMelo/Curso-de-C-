using System;
using System.Collections.Generic;
using System.Globalization;

namespace WorkoutList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> listEmployees = new List<Employee>();

            Console.WriteLine("How many employees will be registered ?: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write("Id of " + (i + 1) + "º employee: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Name of " + (i + 1) + "º employee: ");
                string name = Console.ReadLine();

                Console.Write("Salary of " + (i + 1) + "º employee: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                listEmployees.Add(new Employee(id, name, salary));
            }

            Console.Write("Enter the employee id that will have salary increase: ");
            int idIncreaseSalary = int.Parse(Console.ReadLine());

            Employee emp = listEmployees.Find(employee => employee.Id == idIncreaseSalary);

            if (emp == null)
            {
                Console.WriteLine("This id does not exist!");
            } else {
                Console.Write("Enter the percentage: ");
                double percent = double.Parse(Console.ReadLine());

                emp.salaryIncrease(percent);
            }

            Console.WriteLine("Updated list of employees:");
            foreach (Employee employee in listEmployees)
            {
                Console.WriteLine(employee);
            }
        }
    }
}
