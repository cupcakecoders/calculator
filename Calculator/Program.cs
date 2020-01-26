using System;
using System.Collections.Generic;
using System.Linq;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintWelcomeMessage();
            PerformOneCalculation();
        }

        static void PrintWelcomeMessage()
        {
            Console.WriteLine("Welcome to the Calculator!");
        }

        static void PerformOneCalculation()
        {
            Console.WriteLine("Enter an operator * - + /");
            string myOperator = Console.ReadLine();
            
            Console.WriteLine($"How many numbers do you want to {myOperator} ?");
            int numberOfnumbers = int.Parse(Console.ReadLine());
            
            int[] numbersArray = new int[numberOfnumbers];
            
            int count = 1;

            // start loop
            for (int i = 0; i < numbersArray.Length; i++)
            {
                Console.WriteLine($"Please enter number {count}");
                count = count + 1;
                int myNumber = int.Parse(Console.ReadLine());

                numbersArray[i] = myNumber;
                // Array.ForEach(numbersArray, Console.WriteLine);
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

        static void UserInput()
        {
            
        }
    }
}