using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;


namespace Calculator
{
    class Program
    {
        private const int NumberCalculator = 1;
        private const int DateCalculator = 2;
        
        static void Main(string[] args)
        {
            File.WriteAllText("/Users/kk/Documents/techswitch/C#/Calculator/Calculator/logs.txt", String.Empty);

            PrintWelcomeMessage();
            
            while (true)
            {
                int calculationMode = AskForCalculationMode();

                if (calculationMode == NumberCalculator)
                {
                    var newnumbercalculation = new NumberCalculatorx();
                    newnumbercalculation.PerformOneCalculation();
                    
                }
                else
                {
                    var newdatecalculation = new DateCalculatorx();
                    newdatecalculation.PerformOneDateCalculation();
                }
            }
        }

        static void PrintWelcomeMessage()
        {
            Console.WriteLine("Welcome to the Calculator!");
        }
        

        static int AskForCalculationMode()
        {
            var calculatorType = Prompts.UserInput("Which calculator do you want? \n 1) Numbers \n 2) Dates");
            return calculatorType;
        }
    }
}
