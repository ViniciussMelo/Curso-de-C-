using System;
using Workout01.Entities.Enums;
using System.Collections.Generic;

namespace Workout01.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; }
        public List<HourContract> Contracts { get; set; }

        public Worker()
        {

        }

        public Worker(string name, WorkerLevel level, double baseSalary, Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
            Contracts = new List<HourContract>();
        }

        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }

        public void RemoveContract(HourContract contract)
        {
            HourContract contractRemove = Contracts.Find(cont => cont == contract);
            Contracts.Remove(contractRemove);
        }

        public double Income(int year, int month)
        {
            double income = BaseSalary;

            foreach(HourContract obj in Contracts){
                if (obj.Date.Year == year && obj.Date.Month == month)
                {
                    income += obj.TotalValue();
                }
            }

            return income;
        }
    }
}
