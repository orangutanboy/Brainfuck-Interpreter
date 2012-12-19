using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BrainfuckInterpreter
{
    public enum OpCode : byte
    {
        IncrementPointer = (byte)'>',
        DecrementPointer = (byte)'<',
        IncrementValue = (byte)'+',
        DecrementValue = (byte)'-',
        OutputValue = (byte)'.',
        InputValue = (byte)',',
        BeginLoop = (byte)'[',
        EndLoop = (byte)']'        
    }
}
