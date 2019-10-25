using System;
using System.Collections.Generic;
using System.Text;

namespace Employees.Model
{
    public class Employee : BaseEmployee
    {

        public Employee(string name, string surname, int wage, int id): base(name,surname,wage, id)
        {
        }

        public override TypeOfContract TypeOfContract => TypeOfContract.EmploymentContrat;

        public override void CalculateCharge(int wage)
        {
                Console.WriteLine($"Cost is {wage * 180 / 100}");
        }

        //public override TypeOfContract GetContractType()
        //{
        //    return TypeOfContract.EmploymentContrat;
        //}
    }
}
