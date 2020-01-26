using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Calculator!");

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

            }
            Array.ForEach(numbersArray, Console.WriteLine);
            
            // calculator method go through each number in array and apply operator to it
            for (int i = 0; i < numbersArray.Length; i++)
            {
                int answer = 0;
                switch (myOperator)

                {
                    case "*":
                        answer = numbersArray[i] * numbersArray[i + 1];
                        break;
                    case "/":
                        answer = numbersArray[i] / numbersArray[i + 1];
                        break;
                    case "+":
                        answer = numbersArray[i] + numbersArray[i + 1];
                        break;
                    case "-":
                        answer = numbersArray[i] - numbersArray[i + 1];
                        break;
                }
                Console.WriteLine($"The answer is {answer}");
            }
        }
    }
}