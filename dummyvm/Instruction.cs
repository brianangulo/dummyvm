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

        /// <summary>
        /// Only to be used with halt or print instructions
        /// </summary>
        public Instruction(Opcodes opcode)
        {
            this.opcode = opcode;
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
