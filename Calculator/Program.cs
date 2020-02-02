using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;


namespace Calculator
{
    class Program
    {
        enum CalculatorType
        {
            NumberCalc = 1,
            DateCalc = 2
        }
        
        static void Main(string[] args)
        {
            File.WriteAllText("/Users/kk/Documents/techswitch/C#/Calculator/Calculator/logs.txt", String.Empty);

            PrintWelcomeMessage();
            
            while (true)
            {
                
                CalculatorType calculationMode = AskForCalculationMode();
                 
                if (calculationMode == CalculatorType.NumberCalc)
                
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
        

        private static CalculatorType AskForCalculationMode()
        {
            var userCalChoice = Prompts.UserInput("Which calculator do you want? \n 1) Numbers \n 2) Dates");
            if (userCalChoice == 1)
            {
                return CalculatorType.NumberCalc;
            }
            if (userCalChoice == 2)
            {
                return CalculatorType.DateCalc;
            }
            else
            {
                return AskForCalculationMode();
            }
        }
    }
}
