using System;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;

namespace BrainfuckInterpreter
{
    class Program
    {
        private static string _programInstructions;

        [STAThread]
        static void Main(string[] args)
        {
            Console.InputEncoding = new ASCIIEncoding();
            Runner runner = new Runner();

            //runner.LoadAndRun(ExamplePrograms.HelloWorld);
            //runner.LoadAndRun(ExamplePrograms.LowerToUpper);
            //runner.LoadAndRun(ExamplePrograms.Fibonacci);
            //runner.LoadAndRun(ExamplePrograms.Rot13);

            _programInstructions = ReadProgram();
            runner.LoadAndRun(_programInstructions);

            Console.WriteLine();
            Console.WriteLine("Press any key to quit");
            Console.ReadKey();
        }

        //Read a program from the command line, allow user to paste from clipboard
        private static string ReadProgram()
        {
            Console.WriteLine("Enter program:");
            var program = string.Empty;
            do
            {
                var nextKey = Console.ReadKey(true);
                if (nextKey.Key == ConsoleKey.V && nextKey.Modifiers == ConsoleModifiers.Control)
                {
                    var clipBoardText = Clipboard.GetText();
                    Console.Write(clipBoardText);
                    program += clipBoardText;
                }
                else if (nextKey.Key == ConsoleKey.Enter)
                {
                    Console.WriteLine();
                    break;
                }
                else
                {
                    Console.Write(nextKey.KeyChar);
                    program += nextKey.KeyChar;
                }
            }
            while (true);
            return program;
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
