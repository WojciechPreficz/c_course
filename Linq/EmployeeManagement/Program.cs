using EmployeePersistence;
using System;
using System.Collections.Generic;

namespace EmployeeManagement
{
    class Program
    {

        static void Main(string[] args)
        {
            var repo = new EmployeeRepository();

            foreach (var emp in repo.Employees())
            {
                Console.WriteLine($"{emp.Id} {emp.Name}");
            }
            //repo.Employees().Print();
            Console.ReadLine();
        }
         
    }
    public static class Extensions
    {
        public static IEnumerable<Employee> Print(this IEnumerable<Employee> employees)
        {
            foreach (var emp in employees)
            {
                Console.WriteLine($"{emp.Id} {emp.Name}");
            }
            return employees;
        }
    }
}
