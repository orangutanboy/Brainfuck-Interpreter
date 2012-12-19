using System;
using System.Collections.Generic;
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
            runner.LoadAndRun(ExamplePrograms.LowerToUpper);
            Console.ReadLine();
        }

        internal static void ErrorOut(string p)
        {
            Console.WriteLine(p);
            Environment.Exit(-1);
        }
    }
}
