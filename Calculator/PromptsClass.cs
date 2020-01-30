using System;

namespace Calculator
{
    public class Prompts
    {
        public static DateTime UserInputDate(string prompt)
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
        public static int? UserInput(string prompt)
        {
            Console.WriteLine(prompt);
            var number = GetNumber(Console.ReadLine());
            return number;
        }
        
        static int? GetNumber(string response)
        {
            if (int.TryParse(response, out int number))
            {
                return number;
            }
            else if (response == "")
            {
                return null;
            } 
            else
            {
                return UserInput("That is not a valid response, please enter a number");
            }
        }
    }
}