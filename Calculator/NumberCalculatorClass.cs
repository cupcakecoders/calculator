using System;
using System.Collections.Generic;
using System.Linq;

namespace Calculator
{
    public class NumberCalculatorx
    {

        // instance variables
        private string myOperator;
        // private int numberOfnumbers;
        private int? myNumber;
        private int answer;

        public int PerformOneCalculation()
        {
            Console.WriteLine("Enter an operator * - + /");
            myOperator = Console.ReadLine();

            // numberOfnumbers = Prompts.UserInput(
            //     $"How many numbersList do you want to {myOperator} ?");

            List<int> numbersList = new List<int>();

            // for (int i = 0; i < numbersList.Count; i++)

                int count = 0;
                while (true)
                {      
                    myNumber = Prompts.UserInput($"Please enter number:");
                    if (myNumber.HasValue)
                    {
                        numbersList.Insert(count, myNumber.Value);
                        count = count + 1;
    
                    }
                    else
                    {
                        break;
                    }
                    
                }
                
            // calculator method to go through each number in array and apply operator to it
            answer = numbersList.First();
            
            for (int i = 0; i < numbersList.Count - 1; i++)
            {
                switch (myOperator)

                {
                    case "*":
                        answer = answer * numbersList[i + 1];
                        break;
                    case "/":
                        answer = answer / numbersList[i + 1];
                        break;
                    case "+":
                        answer = answer + numbersList[i + 1];
                        break;
                    case "-":
                        answer = answer - numbersList[i + 1];
                        break;
                }
            }

            LogCalculations.Log($"Operator {myOperator}, Numbers, {string.Join(", ", numbersList)} answer {answer}");
            
            Console.WriteLine($"The answer is {answer}");
            return answer;
        }

    }
}