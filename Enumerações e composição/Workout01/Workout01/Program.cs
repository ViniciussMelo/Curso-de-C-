using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workout01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter department's name: ");
            string departmenName = Console.ReadLine();

            Console.WriteLine("Enter worker data: ");
            Console.Write("Name: ");
            string workerName = Console.ReadLine();

            Console.Write("Level (Junior/MidLevel/Senior): ");
            string workerLevel = Console.ReadLine();

            Console.Write("Base salary: ");
            double workerBaseSalary = double.Parse(Console.ReadLine());

            Console.Write("How many contracts to this worker?");
            int contractNumber = int.Parse(Console.ReadLine());

            for (int i = 0; i < contractNumber; i++)
            {
                Console.WriteLine("Enter #" + (i + 1) + " contract data:");
                
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());

                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine());

                Console.Write("Duration (hours): ");
                int hours = int.Parse(Console.ReadLine());
            }
        }
    }
}
