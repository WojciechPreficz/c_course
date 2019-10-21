using System;
using System.Collections.Generic;
using System.Text;

namespace Employees.Model
{
    public enum TypeOfContract
    {
        EmploymentContrat,
        SpecificTaskContract
    }
    public class Employee : IEmployee
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public TypeOfContract Contract;
        public int Wage;

        public Employee(string name, string surname, TypeOfContract contract, int wage)
        {
            Name = name;
            Surname = surname;
            Contract = contract;
            Wage = wage;
        }

        public void CalculateCharge(TypeOfContract contract, int wage)
        {
            if(contract == TypeOfContract.EmploymentContrat)
            {
                var totalCost = wage * 140 / 100;
                Console.WriteLine($"Cost is {totalCost}");
            } else
            {
                var totalCost = wage * 180 / 100;
                Console.WriteLine($"Cost is {totalCost}");
            }
        }
    }
}
