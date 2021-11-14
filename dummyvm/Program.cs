using System;
using System.Collections;
namespace dummyvm
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Memory mainMemory = new Memory();
            CPU cpu = new CPU(mainMemory);
            Instruction[] sampleProgram = new Instruction[] { new Instruction(Opcodes.PUSH, 2), new Instruction(Opcodes.PUSH, 2), new Instruction(Opcodes.ADD, 2), new Instruction(Opcodes.PRINT), new Instruction(Opcodes.HALT) };         
            mainMemory.LoadProgram(sampleProgram);
            cpu.ExecuteProgram();
        }
    }
}
