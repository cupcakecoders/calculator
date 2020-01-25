using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Calculator!");
            
            Console.WriteLine("Enter an operator");
            string myOperator = Console.ReadLine();

            Console.WriteLine("Type your first number");
            int firstNumber = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Type your second number");
            int secondNumber = int.Parse(Console.ReadLine());

            int answer = 0;
            switch (myOperator)
            
            {
                case "*":
                    answer = firstNumber * secondNumber;
                    break;
                case "/":
                    answer = firstNumber / secondNumber;
                    break;
                case "+":
                    answer = firstNumber + secondNumber;
                    break;
                case "-":
                    answer = firstNumber - secondNumber;
                    break;
            }
            
            Console.WriteLine($"The answer is = {answer}");
        }
    }
}