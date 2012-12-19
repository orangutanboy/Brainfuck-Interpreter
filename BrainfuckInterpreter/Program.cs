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
            Runner runner = new Runner("++++++++++[>+++++++>++++++++++>+++>+<<<<-]>++.>+.+++++++..+++.>++.<<+++++++++++++++.>.+++.------.--------.>+.>.");
            runner.Run();
            Console.ReadLine();
        }

        internal static void ErrorOut(string p)
        {
            Console.WriteLine(p);
            Environment.Exit(-1);
        }
    }
}
