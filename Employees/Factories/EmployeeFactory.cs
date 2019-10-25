using Employees.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Employees.Factories
{
    public static class EmployeeFactory
    {
        public static BaseEmployee CreateEmployee(RequestEmployee requestedEmployee)
        {
            if (requestedEmployee.TypeOfContract == TypeOfContract.EmploymentContrat)
            {
                return new Employee(requestedEmployee.Name, requestedEmployee.Surname, requestedEmployee.Wage, requestedEmployee.EmployeeId);
            }
            else
            {
                return new SpecificEmployee(requestedEmployee.Name, requestedEmployee.Surname, requestedEmployee.Wage, requestedEmployee.EmployeeId);
            }
        }
    }
}
