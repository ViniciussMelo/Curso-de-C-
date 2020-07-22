using System;
using Workout01.Entities.Enums;
using System.Collections.Generic;

namespace Workout01.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public WorkerLevel level { get; set; }
        public decimal baseSalary { get; set; }
        public Department Department { get; set; }
        public List<HourContract> Contracts { get; set; }

        public Worker()
        {

        }

        public void addContract(HourContract contract)
        {
            Contracts.Add(contract);
        }

        public void removeContract(HourContract contract)
        {
            HourContract contractRemove = Contracts.Find(cont => cont == contract);
            Contracts.Remove(contractRemove);
        }

        public double income(int year, int month)
        {
            double income = 0.00;

            foreach(HourContract obj in Contracts){
                income += obj.totalValue();
            }

            return income;
        }
    }
}
