using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintWelcomeMessage();

            while (true)
            {
                PerformOneCalculation();
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

            int numberOfnumbers = UserInput(
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
            int answer = numbersArray[0];
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
            int number = GetNumber(Console.ReadLine());
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
    }
}