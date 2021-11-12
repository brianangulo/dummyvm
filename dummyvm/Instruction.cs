using System;
namespace dummyvm
{
    public class Instruction
    {
        private readonly Opcodes opcode;
        private readonly int data;

        public Instruction(Opcodes opcode, int data)
        {
            this.opcode = opcode;
            this.data = data;
        }

        public Opcodes GetOpcode()
        {
            return opcode;
        }

        public int GetInstructionData()
        {
            return data;
        }
    }
}
