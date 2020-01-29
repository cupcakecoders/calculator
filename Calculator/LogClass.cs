using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace Calculator 
{
    public static class LogCalculations
    {

        public static void Log(string value)

        {
            using (StreamWriter w = File.AppendText("/Users/kk/Documents/techswitch/C#/Calculator/Calculator/logs.txt"))
            {
                w.WriteLine(value);
            }
        }
    }
}


