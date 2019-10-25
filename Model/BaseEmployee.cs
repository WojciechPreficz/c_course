using System;
using System.Collections.Generic;
using System.Text;

namespace Employees.Model
{
    public abstract class BaseEmployee
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Wage;
        public int EmployeeId;

        public BaseEmployee(string name, string surname, int wage, int id)
        {
            Name = name;
            Surname = surname;
            Wage = wage;
            EmployeeId = id;
        }

        //public abstract TypeOfContract GetContractType();
        public abstract TypeOfContract TypeOfContract { get; }

        public abstract void CalculateCharge(int wage);
    }
}
