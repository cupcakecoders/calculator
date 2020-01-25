using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Calculator!");
            Console.WriteLine("Type your first number");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Type your second number");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine(firstNumber * secondNumber);
        }
    }
}