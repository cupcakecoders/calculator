using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Calculator!");
            Console.WriteLine("Type your first number");
            int firstNumber = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Type your second number");
            int secondNumber = int.Parse(Console.ReadLine());
            
            Console.WriteLine(firstNumber * secondNumber);
        }
    }
}