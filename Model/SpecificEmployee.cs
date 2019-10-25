using System;
using System.Collections.Generic;
using System.Text;

namespace Employees.Model
{
    public class SpecificEmployee : BaseEmployee
    {
        public SpecificEmployee(string name, string surname, int wage, int id): base (name,surname,wage, id)
        {

        }

        public override TypeOfContract TypeOfContract => TypeOfContract.SpecificTaskContract;

        public override void CalculateCharge( int wage)
        {
                Console.WriteLine($"Cost is {wage * 140 / 100}");
        }

        //public override TypeOfContract GetContractType()
        //{
        //    return TypeOfContract.SpecificTaskContract;
        //}
    }
}
