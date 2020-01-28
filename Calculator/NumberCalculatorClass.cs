using System;

namespace Calculator
{
    public class NumberCalculatorx
    {

        // instance variables
        private string myOperator;
        private int numberOfnumbers;
        private int myNumber;
        private int answer;
        private int[] numbersArray;

        public int PerformOneCalculation()
        {
            Console.WriteLine("Enter an operator * - + /");
            myOperator = Console.ReadLine();

            numberOfnumbers = UserInput(
                $"How many numbers do you want to {myOperator} ?");

            numbersArray = new int[numberOfnumbers];

            int count = 1;

            for (int i = 0; i < numbersArray.Length; i++)
            {
                myNumber = UserInput($"Please enter number {count}");
                count = count + 1;
                numbersArray[i] = myNumber;
            }

            // calculator method to go through each number in array and apply operator to it
            answer = numbersArray[0];
            for (int i = 0; i < numbersArray.Length - 1; i++)
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
            return answer;
        }

        private int UserInput(string prompt)
        {
            Console.WriteLine(prompt);
            var number = GetNumber(Console.ReadLine());
            return number;
        }

        private int GetNumber(string response)
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