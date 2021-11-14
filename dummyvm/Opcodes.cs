using System;
namespace dummyvm
{
    public enum Opcodes
    {
         PUSH =  0x01,  // stops program execution. For simplicity this is also the default value for when program memory is empty. Every program should terminate with a halt instruction
         HALT =  0x00,  // pushes the integer value on the instruction to the top of the stack
         POP =   0x02,  // pops value at the top of the stack
         PRINT = 0x03,  // this one for simplicity's sake it just prints value to the screen
         ADD =   0x04,  // fetches and pops the top 2 values of the stack executes a addition then pushes the result to the top of the stack
         SUB =   0x05,  // fetches and pops the top 2 values of the stack executes a substraction then pushes the result to the top of the stack
    }
}
