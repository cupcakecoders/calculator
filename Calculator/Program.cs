using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace Calculator
{
    class Program
    {
        private const int NumberCalculator = 1;
        private const int DateCalculator = 2;
        
        static void Main(string[] args)
        {
            PrintWelcomeMessage();

            while (true)
            {
                int calculationMode = AskForCalculationMode();

                if (calculationMode == NumberCalculator)
                {
                    PerformOneCalculation();
                }
                else
                {
                    PerformOneDateCalculation();
                }
            }
        }

        static void PrintWelcomeMessage()
        {
            Console.WriteLine("Welcome to the Calculator!");
        }

        static void PerformOneCalculation()
        {
            Console.WriteLine("Enter an operator * - + /");
            string myOperator = Console.ReadLine();

            var numberOfnumbers = UserInput(
                $"How many numbers do you want to {myOperator} ?");

            int[] numbersArray = new int[numberOfnumbers];
            
            int count = 1;

            for (int i = 0; i < numbersArray.Length; i++)
            {
                int myNumber = UserInput($"Please enter number {count}");
                count = count + 1;
                numbersArray[i] = myNumber;
            }

            // calculator method to go through each number in array and apply operator to it
            var answer = numbersArray[0];
            for (int i = 0; i < numbersArray.Length -1; i++)
            {
                Console.WriteLine($"The number we are dealing with {numbersArray[i + 1]}");
                Console.WriteLine($"The answer currently is {answer}");

                switch (myOperator)

                {
                    case "*":
                        answer = answer * numbersArray[i + 1];
                        break;
                    case "/":
                        answer = answer / numbersArray[i + 1];
                        break;
                    case "+":
                        answer = answer + numbersArray[i + 1];
                        break;
                    case "-":
                        answer = answer - numbersArray[i + 1];
                        break;
                }
            }
            Console.WriteLine($"The answer is {answer}");
        }

        static int UserInput(string prompt)
        {
            Console.WriteLine(prompt);
            var number = GetNumber(Console.ReadLine());
            return number;
        }

        static DateTime UserInputDate(string prompt)
        {
            Console.WriteLine(prompt);
            DateTime userDate = GetValidDate(Console.ReadLine());
            return userDate;
        }

        static DateTime GetValidDate(string dateresponse)
        {
            if (DateTime.TryParse(dateresponse, out DateTime userDate))
            {
                return userDate;
            }
            else
            {
                return UserInputDate("That was not a valid date, please enter a date mm/dd/yyyy");
            }
        }

        static int GetNumber(string response)
        {
            if (int.TryParse(response, out int number))
            {
                return number;
            }
            else
            {
                return UserInput("That is not a valid response, please enter a number");
            }
        }

        static DateTime PerformOneDateCalculation()
        {
            DateTime userDate = UserInputDate("Please enter a date: mm/dd/yyyy");
            var daysToAdd = UserInput("Please enter the number of days to add:");

            DateTime dateCalculation = userDate.AddDays(daysToAdd);

            Console.WriteLine(dateCalculation.ToShortDateString());
            return dateCalculation;
        }

        static int AskForCalculationMode()
        {
            var calculatorType = UserInput("Which calculator do you want? \n 1) Numbers \n 2) Dates");
            return calculatorType;
        }
    }
}
