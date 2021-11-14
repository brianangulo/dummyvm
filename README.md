# dummyvm
Simplified Stack based virtual machine

## CPU
Stack machine with a stack held in memory instead opposed to a register based stack. 
**Registers:** There are 2 registers one holds a pointer to the stack in memory and the other one is an accumulator register
**Instructions** There are 6 total Opcodes instruction. Each instruction is composed of an OpCode and an optional maximum of 1 integer number.

       - HALT  =  0x00, // stops program execution. For simplicity this is also the default value for when program memory is empty. Every program should terminate with a halt instruction
       - PUSH  =  0x01, // pushes the integer value on the instruction to the top of the stack
       - POP   =  0x02, // pops value at the top of the stack
       - PRINT =  0x03, // this one for simplicity's sake it just prints value to the screen
       - ADD   =  0x04, // fetches and pops the top 2 values of the stack executes a addition then pushes the result to the top of the stack
       - SUB   =  0x05, // fetches and pops the top 2 values of the stack executes a substraction then pushes the result to the top of the stack

## Memory
Memory is an instance of a C# ArrayList the push/pop logic is controlled by the CPU. It can only hold integers for simplicity
There is also a separate Array contained within memory allocated to load and serve programs from. The CPU can fetch instructions directly from this allocation.

## Program
A program is an array of Instructions and it can be loaded 
