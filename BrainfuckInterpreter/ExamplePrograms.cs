using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BrainfuckInterpreter
{
    public static class ExamplePrograms
    {
        /// <summary>
        /// Simply prints Hello World! to the console
        /// </summary>
        public const string HelloWorld = "++++++++++[>+++++++>++++++++++>+++>+<<<<-] >++.>+.+++++++..+++.>++.<<+++++++++++++++.>.+++.------.--------.>+.>.";
        /// <summary>
        /// Takes a user input and subtracts 32 from it. If the value is the enter key then the program exits
        /// </summary>
        public const string LowerToUpper = ",-------------[-------------------.,-------------]";
        /// <summary>
        /// Calculates the first n fibonacci numbers after 1,1 where n is stored in Memory[4]
        /// </summary>
        public const string Fibonacci = "+.>+.>>>+++++ +++++[<<<[->>+<<]>>[-<+<+>>]<<<[->+<]>>[-<<+>>]<.>>>-]";
        public const string Rot13 = "-,+[-[>>++++[>++++++++<-]<+<-[>+>+>-[>>>]<[[>+<-]>>+>]<<<<<-]]>>>[-]+>--[-[<->[-]]]<[++++++++++++<[>-[>+>>]>[+[<+>-]>+>>]<<<<<-]>>[<+>-]>[-[-<<[-]>>]<<[<<->>-]>>]<<[<<+>>-]]<[-]<.[-]<-,+]";
    }
}
