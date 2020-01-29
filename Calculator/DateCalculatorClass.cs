using System;

namespace Calculator
{
    public class DateCalculatorx
    {
        //instance variables
        private DateTime userDate;
        private int daysToAdd;
        private DateTime dateCalculation;
        
        public DateTime PerformOneDateCalculation()
        {
            userDate = Prompts.UserInputDate("Please enter a date: mm/dd/yyyy");
            daysToAdd = Prompts.UserInput("Please enter the number of days to add:");

            dateCalculation = userDate.AddDays(daysToAdd);

            LogCalculations.Log($"Date {userDate}, days to add {daysToAdd}, answer {dateCalculation}");
            Console.WriteLine(dateCalculation.ToShortDateString());
            return dateCalculation;
        }
    }
}