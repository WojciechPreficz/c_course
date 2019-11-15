using EmployeeManagement;
using EmployeePersistence;
using FluentAssertions;
using System.Collections.Generic;
using Xunit;

namespace EmployeeLinqTests
{
    public class EmployeeFunctionsTests
    {
        private readonly IEnumerable<Employee> employees;

        public EmployeeFunctionsTests()
        {
            var employeeRepository = new EmployeeRepository();
            employees = employeeRepository.Employees();
        }

        [Fact]
        public void CountEmployeesOlderThan50()
        {
            var result = EmployeeFunctions.CountEmployeesOlderThan50(employees);

            result.Should().Be(483);
        }

        [Fact]
        public void ListSurnamesOfEmployeesEarningOver9900()
        {
            var result = EmployeeFunctions.ListSurnamesOfEmployeesEarningOver9900(employees);

            var expectedResult = new List<string>
            {
                "Licari", "Andrew", "Noyes", "MacLucais", "Worham",
                "Grimsdith", "Blundan", "Gorstidge", "McAvinchey", "O'Deoran"
            };

            result.Should().BeEquivalentTo(expectedResult);
        }

        [Fact]
        public void FindEmployeesYoungerThan18AndEarningLessThan1100()
        {
            var result = EmployeeFunctions.FindEmployeesYoungerThan18AndEarningLessThan1100(employees);

            var expectedResult = new List<Employee>
            {
                new Employee
                {
                    Age = 10,
                    Id = 188,
                    Name = "Bondy",
                    Surname = "McGloughlin",
                    Wage = 1054
                }
            };

            result.Should().BeEquivalentTo(expectedResult);
        }

        [Fact]
        public void Find_NameAndSurname_OfTheOldestEmployeeWhoEarnsBetween6500And7000()
        {
            var result = EmployeeFunctions.Find_NameAndSurname_OfTheOldestEmployeeWhoEarnsBetween6500And7000(employees);

            result.Should().BeEquivalentTo("Marya Oolahan");
        }

        [Fact]
        public void EmployeesUnderAgeOf18Exist_ReturnsTrue_IfThereAreEmployeesUnderAgeOf18()
        {
            var result = EmployeeFunctions.EmployeesUnderAgeOf18Exist(employees);

            result.Should().BeTrue();
        }

        [Fact]
        public void EmployeeWithoutSurnameExists_ReturnsFalse_IfAllEmployeesHaveSurname()
        {
            var result = EmployeeFunctions.EmployeeWithoutSurnameExists(employees);

            result.Should().BeFalse();
        }

        [Fact]
        public void AverageWageWithoutTop100andBottom100Wages()
        {
            var result = EmployeeFunctions.AverageWageWithoutTop100andBottom100Wages(employees);

            result.Should().Be(5405.55);
        }

        [Fact]
        public void FindTheMostPopularNameStartingWithTheOldestLetterOfTheAlphabet()
        {
            var result = EmployeeFunctions.FindTheMostPopularNameStartingWithTheOldestLetterOfTheAlphabet(employees);
            result.Should().Be("Virge");
        }

        [Fact]
        public void FindTheNumberOfEmployeesWhosSalaryIsDivisibleByTheirId()
        {
            var result = EmployeeFunctions.FindTheNumberOfEmployeesWhosSalaryIsDivisibleByTheirId(employees);
            result.Should().Be(7);
        }

        [Fact]
        public void FindTheAgeDifferenceBetweenTheEldestAndYoungestEmployee()
        {
            var result = EmployeeFunctions.FindTheAgeDifferenceBetweenTheEldestAndYoungestEmployee(employees);
            result.Should().Be(99);
        }

        [Fact]
        public void FindTheNumberOfEmployeesWhosNameIsLongerThenSurname()
        {
            var result = EmployeeFunctions.FindTheNumberOfEmployeesWhosNameIsLongerThenSurname(employees);
            result.Should().Be(276);
        }

        [Fact]
        public void FindTheYoungestEmployeeNameWithTheHighestWage()
        {
            var result = EmployeeFunctions.FindTheYoungestEmployeeNameWithTheHighestWage(employees);
            result.Should().Be("Brittaney");
        }

        [Fact]
        public void FindTheThirdBestWageEmployeeNameWithSurnameLonger5()
        {
            var result = EmployeeFunctions.FindTheThirdBestWageEmployeeNameWithSurnameLonger5(employees);
            result.Should().Be("Susie");
        }
    }
}