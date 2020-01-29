using System;
using System.IO;

namespace Calculator 
{
    public class LogCalculations
    {
        public static void Log()
        {
            using (StreamWriter w = File.AppendText("/Users/kk/Documents/techswitch/C#/Calculator/Calculator/logs.txt"))
            {
                w.Write("Test1");
            }
        }
        
    }
}


