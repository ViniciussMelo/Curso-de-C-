using System;
using System.Collections.Generic;
using System.Globalization;
using Workout01.Entities;
using Workout01.Entities.Enums;

namespace Workout01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter department's name: ");
            string departmentName = Console.ReadLine();

            Console.WriteLine("Enter worker data: ");
            Console.Write("Name: ");
            string workerName = Console.ReadLine();

            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel workerLevel = (WorkerLevel) Enum.Parse(typeof(WorkerLevel), Console.ReadLine());

            Console.Write("Base salary: ");
            double workerBaseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("How many contracts to this worker? ");
            int contractNumber = int.Parse(Console.ReadLine());

            Department department = new Department(departmentName);
            Worker worker = new Worker(workerName, workerLevel, workerBaseSalary, department);

            for (int i = 0; i < contractNumber; i++)
            {
                Console.WriteLine("Enter #" + (i + 1) + " contract data:");
                
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());

                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Duration (hours): ");
                int hours = int.Parse(Console.ReadLine());

                worker.AddContract(new HourContract(date, valuePerHour, hours));
            }

            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            DateTime referenceMonth = DateTime.Parse(Console.ReadLine());

            double income = worker.Income(referenceMonth.Year, referenceMonth.Month);

            Console.WriteLine("Name: " + worker.Name);
            Console.WriteLine("Department: " + worker.Department.Name);
            Console.WriteLine("Income for " + referenceMonth.ToString("MM/yyyy") + ": " + income.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
