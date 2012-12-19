using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BrainfuckInterpreter
{
    public class Runner
    {
        public string Program { get; set; }
        private int CurrentStackAddress = 0;
        StateMachine sm;
        private bool programLoaded = false;

        public Runner()
        {
        }

        public Runner(string program)
        {
            LoadNewProgram(program);
        }

        private string ParseProgram(string program)
        {
            StringBuilder sb = new StringBuilder();
            HashSet<char> validChars = new HashSet<char>();
            validChars.Add('>');
            validChars.Add('<');
            validChars.Add('.');
            validChars.Add(',');
            validChars.Add('+');
            validChars.Add('-');
            validChars.Add('[');
            validChars.Add(']');

            foreach (char c in program)
            {
                if (validChars.Contains(c))
                {
                    sb.Append(c);
                }
            }
            return sb.ToString();
        }

        public void LoadAndRun(string program)
        {
            LoadNewProgram(program);
            Run();
        }

        public void LoadNewProgram(string program)
        {
            programLoaded = false;
            Program = ParseProgram(program);
            programLoaded = true;
        }

        public void Run()
        {
            if (programLoaded)
            {
                sm = new StateMachine(this);
                while (sm.InstructionAddress != Program.Length)
                {
                    sm.ExecuteOpcode((OpCode)Program[sm.InstructionAddress]);
                }
            }
            else
            {
                Console.WriteLine("No program has yet been loaded");
            }
        }

        private int SeekChar(char c)
        {
            for (int i = sm.InstructionAddress; i < Program.Length; i++)
            {
                if (i == c)
                {
                    return i;
                }
            }
            return -1;
        }

        public int SeekEndLoop()
        {
            return SeekChar(']');
        }

        public int SeekBeginLoop()
        {
            return SeekChar('[');
        }
    }
}
