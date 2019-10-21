using System;
using System.Collections.Generic;
using System.Text;

namespace Employees.Model
{
    interface IEmployee
    {
        void CalculateCharge(TypeOfContract contract, int wage);
    }
}
