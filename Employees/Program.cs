using Employees.Model;
using System;
using System.Collections.Generic;

namespace Employees
{
    class Program
    {
        static List<Employee> ListOfEmployees = new List<Employee>();
        static void Main(string[] args)
        {
            bool runProgramAgain;
            string action;

            Console.WriteLine("Hi this is you employment management system. What you want to do now?");
            do
            {
                DisplayInformationAbouTypesOfActions();
                action = UserAction();
                DecideWhatYouWantTodo(action);
                runProgramAgain = DecideOnRunningProgramAgain();
            } while (runProgramAgain);
        }

        static void DisplayInformationAbouTypesOfActions()
        {
            Console.WriteLine("Choose type of action");
            Console.WriteLine("(A)dd new employedd");
            Console.WriteLine("(C)ost");
            Console.WriteLine("(D)elete employee from list");
            Console.WriteLine("(S)how all emplyees");
        }

        static string UserAction()
        {
            bool validInput;
            string action;
            do
            {
                action = Console.ReadLine().ToUpper();
                if (action == "A" || action == "S" || action == "D" || action == "C")
                {
                    validInput = true;
                }
                else
                {
                    validInput = false;
                    Console.WriteLine("Wrong type of action. Please choose once again.");
                }

            } while (!validInput);
            return action;
        }

        static void DecideWhatYouWantTodo(string action) {
            string newEmployeeName;
            string newEmployeeSurname;
            string newEmployeeContract;
            TypeOfContract newEmployeeContractEnum;
            int newEmployeeWage;
            int employeeToRemoveIndex;
            int indexOfEmployeeToShowCost;


            switch (action)
            {
                case "A":
                    Console.WriteLine("You're adding new employee \n Please type a name");
                    newEmployeeName = Console.ReadLine();
                    Console.WriteLine("Please type a surname");
                    newEmployeeSurname = Console.ReadLine();
                    Console.WriteLine("Please choose type of contract \n Default is Employment Contract \n  (E)mployment Contract (S)pecific Task Contract");
                    newEmployeeContract = Console.ReadLine().ToUpper();
                    if (newEmployeeContract == "E")
                        newEmployeeContractEnum = TypeOfContract.EmploymentContrat;
                    else if (newEmployeeContract == "S")
                        newEmployeeContractEnum = TypeOfContract.SpecificTaskContract;
                    else newEmployeeContractEnum = TypeOfContract.EmploymentContrat;

                    Console.WriteLine("Please type a wage");
                    newEmployeeWage = Convert.ToInt32(Console.ReadLine());

                    CreateNewEmployee(newEmployeeName, newEmployeeSurname, newEmployeeContractEnum, newEmployeeWage);
                    break;
                case "C":
                    Console.WriteLine("If you want to display cost of employee from list please select index");
                    indexOfEmployeeToShowCost = Convert.ToInt32(Console.ReadLine());
                    ShowCost(indexOfEmployeeToShowCost);
                    break;
                case "D":
                    Console.WriteLine("If you want to remove employee from list please select index");
                    employeeToRemoveIndex = Convert.ToInt32(Console.ReadLine());
                    RemoveEmployee(employeeToRemoveIndex);
                    break;
                case "S":
                    ShowListOfEmployees();
                    break;
            }
        }

        static void CreateNewEmployee(string name, string surname, TypeOfContract typeOfContract, int wage)
        {
            Employee employee = new Employee(name, surname, typeOfContract, wage);
            ListOfEmployees.Add(employee);
        }

        static void RemoveEmployee(int employeeIndex)
        {
            if (ListOfEmployees.Count > 0)
            {
                ListOfEmployees.RemoveAt(employeeIndex);
            } else if(employeeIndex > ListOfEmployees.Count) {
                Console.WriteLine("There is no employee with this index");
            } else
            {
                Console.WriteLine("There are no employeees");
            }
        }

        static void ShowCost(int index)
        {
            if(ListOfEmployees.Count > 0 && index < ListOfEmployees.Count)
            {
                ListOfEmployees[index].CalculateCharge(ListOfEmployees[index].Contract, ListOfEmployees[index].Wage);
            } else
            {
                Console.WriteLine("There is no employeee with this index");
            }
        }

        static void ShowListOfEmployees()
        {
            if(ListOfEmployees.Count > 0) {
                foreach (Employee SingleEmployee in ListOfEmployees) {
                    Console.WriteLine($"Name: {SingleEmployee.Name} Surname: {SingleEmployee.Surname} Type of contract: {SingleEmployee.Contract} Wage: {SingleEmployee.Wage}");
                }
            } else {
                Console.WriteLine("There are no employees");
            }
        }

        static bool DecideOnRunningProgramAgain()
        {
            Console.WriteLine("Do you want to run this again?");
            Console.WriteLine("If you want to, press 'y' else press anything");

            string userResult = Console.ReadLine();

            if (userResult == "Y" || userResult == "y")
            {
                return true;
            }
            else
            {
                Console.WriteLine("bye bye i elo");
                return false;
            }
        }
    }
}
