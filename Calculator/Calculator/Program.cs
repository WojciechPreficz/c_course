using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber;
            int secondNumber;
            string action;
            bool runProgramAgain;

            do
            {
                Console.WriteLine("CALCULATOR");

                firstNumber = ChooseNumber("first");
                secondNumber = ChooseNumber("second");

                DisplayInformationAbouTypesOfActions();

                action = UserAction();

                CalculateResult(action, firstNumber, secondNumber);

                runProgramAgain = DecideOnRunningProgramAgain();
            } while (runProgramAgain);
        }

        static int ChooseNumber(string typeOfNumber)
        {
            Console.WriteLine("Choose " + typeOfNumber + " number");
            int number = Convert.ToInt32(Console.ReadLine());

            return number;
        }

        static void DisplayInformationAbouTypesOfActions()
        {
            Console.WriteLine("Choose type of action");
            Console.WriteLine("(A)DDITION");
            Console.WriteLine("(S)UBSTRACTION");
            Console.WriteLine("(M)ULTIPLICATION");
            Console.WriteLine("(D)IVISION");
        }

        static string UserAction()
        {
            bool validInput;
            string action;
            do
            {
                action = Console.ReadLine().ToUpper();
                if(action == "A" || action == "S" || action == "D" || action == "M")
                {
                    validInput = true;
                } else
                {
                    validInput = false;
                    Console.WriteLine("Wrong type of action. Please choose once again.");
                }

            } while (!validInput);
            return action;
        }

        static void CalculateResult(string action, int firstNumber, int secondNumber)
        {
            switch (action)
            {
                case "A":
                    Console.WriteLine($"\nYour result is " + (AddTwoNumbers(firstNumber, secondNumber)));
                    break;
                case "S":
                    Console.WriteLine($"\nYour result is " + (SubstractTwoNumbers(firstNumber, secondNumber)));
                    break;
                case "M":
                    Console.WriteLine($"\nYour result is " + (MultipyTwoNumbers(firstNumber, secondNumber)));
                    break;
                case "D":
                    if (firstNumber == 0 || secondNumber == 0)
                    {
                        Console.WriteLine("\nYou can't divide by 0");
                        break;
                    }
                    Console.WriteLine($"\nYour result is " + (DivideTwoNumbers(firstNumber, secondNumber)));
                    break;
            }
        }

        static int AddTwoNumbers(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }

        static int SubstractTwoNumbers(int firstNumber, int secondNumber)
        {
            return firstNumber - secondNumber;
        }

        static int DivideTwoNumbers(int firstNumber, int secondNumber)
        {
            return firstNumber / secondNumber;
        }

        static int MultipyTwoNumbers(int firstNumber, int secondNumber)
        {
            return firstNumber * secondNumber;
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
