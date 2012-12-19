using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace BrainfuckInterpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = new ASCIIEncoding();
            Runner runner = new Runner();
            //runner.LoadAndRun(ExamplePrograms.HelloWorld);
            //runner.LoadAndRun(ExamplePrograms.LowerToUpper);
            //runner.LoadAndRun(ExamplePrograms.Fibonacci);
            runner.LoadAndRun(ExamplePrograms.Rot13);
            Console.ReadLine();
        }

        internal static void ErrorOut(string p)
        {
            if (Debugger.IsAttached)
            {
                Debugger.Break();
            }
            Console.WriteLine(p);
            Environment.Exit(-1);
            Console.ReadLine();
        }
    }
}
