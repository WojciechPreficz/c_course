using EmployeePersistence;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeManagement
{
    public static class EmployeeFunctions
    {
        public static int CountEmployeesOlderThan50(IEnumerable<Employee> employees)
        {
            return employees.Where(employee => employee.Age > 50).Count();   
        }

        public static IEnumerable<string> ListSurnamesOfEmployeesEarningOver9900(IEnumerable<Employee> employees)
        {
            return employees.Where(employee => employee.Wage > 9900).Select(emp => emp.Surname);
        }

        public static List<Employee> FindEmployeesYoungerThan18AndEarningLessThan1100(IEnumerable<Employee> employees)
        {
            return employees.Where(emp => emp.Age < 18).Where(emp => emp.Wage < 1100).ToList();
        }

        public static string Find_NameAndSurname_OfTheOldestEmployeeWhoEarnsBetween6500And7000(IEnumerable<Employee> employees)
        {
            return employees.Where(emp => (emp.Wage > 6500 && emp.Wage < 7000)).OrderByDescending(emp => emp.Age).Select(emp => emp.Name + " " + emp.Surname).First().ToString();
        }

        public static bool EmployeesUnderAgeOf18Exist(IEnumerable<Employee> employees)
        {
            return employees.Where(emp => emp.Age < 18).Any();
        }

        public static bool EmployeeWithoutSurnameExists(IEnumerable<Employee> employees)
        {
            return employees.Where(emp => emp.Surname == "").Any();
        }

        public static double AverageWageWithoutTop100andBottom100Wages(IEnumerable<Employee> employees)
        {
            double sum = employees.OrderBy(emp => emp.Wage).Skip(100).OrderByDescending(emp => emp.Wage).Skip(100).Sum(emp => emp.Wage);
            double count = employees.Count() - 200;

            return sum / count;
        }

        public static string FindTheMostPopularNameStartingWithTheOldestLetterOfTheAlphabet(IEnumerable<Employee> employees)
        {
            return employees.GroupBy(emp => emp.Name).OrderByDescending(emp => emp.Count()).ThenByDescending(emp => emp.Key).Take(1).Select(emp => emp.Key).First();
        }

        public static int FindTheNumberOfEmployeesWhosSalaryIsDivisibleByTheirId(IEnumerable<Employee> employees)
        {            
            return employees.Where(emp => emp.Wage % emp.Id == 0).Count();
        }

        public static int FindTheAgeDifferenceBetweenTheEldestAndYoungestEmployee(IEnumerable<Employee> employees)
        {
            var youngest = employees.OrderBy(emp => emp.Age).Select(emp => emp.Age).First();
            var oldest = employees.OrderByDescending(emp => emp.Age).Select(emp => emp.Age).First();

            return oldest - youngest;
        }

        public static int FindTheNumberOfEmployeesWhosNameIsLongerThenSurname(IEnumerable<Employee> employees)
        {
            return employees.Where(emp => emp.Name.Length > emp.Surname.Length).Count();
        }

        public static string FindTheYoungestEmployeeNameWithTheHighestWage(IEnumerable<Employee> employees)
        {            
            return employees.OrderBy(emp => emp.Age).ThenByDescending(emp => emp.Wage).Select(emp => emp.Name).First();
        }

        public static string FindTheThirdBestWageEmployeeNameWithSurnameLonger5(IEnumerable<Employee> employees)
        {
            return employees.Where(emp => emp.Surname.Length > 5).OrderByDescending(emp => emp.Wage).Skip(2).Select(emp => emp.Name).First();
        }
    }
}
