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
                    var newcalculation = new NumberCalculatorx();
                    newcalculation.PerformOneCalculation();
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
        static int UserInput(string prompt)
        {
            Console.WriteLine(prompt);
            var number = GetNumber(Console.ReadLine());
            return number;
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
