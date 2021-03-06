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

            numberOfnumbers = Prompts.UserInput(
                $"How many numbers do you want to {myOperator} ?");

            numbersArray = new int[numberOfnumbers];

            int count = 1;

            for (int i = 0; i < numbersArray.Length; i++)
            {
                myNumber = Prompts.UserInput($"Please enter number {count}");
                count = count + 1;
                numbersArray[i] = myNumber;
            }

            // calculator method to go through each number in array and apply operator to it
            answer = numbersArray[0];
            for (int i = 0; i < numbersArray.Length - 1; i++)
            {
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

            LogCalculations.Log($"Operator {myOperator}, Numbers, {string.Join(", ", numbersArray)} answer {answer}");
            
            Console.WriteLine($"The answer is {answer}");
            return answer;
        }

    }
}