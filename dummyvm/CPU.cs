using System;
using System.Collections;

namespace dummyvm
{
    public class CPU
    {
        private readonly Memory memory;
        private readonly Register<int> memoryPointer;

        public CPU(Memory memory)
        {
            this.memory = memory;
            memoryPointer.SetState(Memory.LastIndex(memory));
        }

        /// <summary>
        /// Pops the last item off the stack
        /// </summary>
        private void Pop()
        {
            memory. RemoveAt(memoryPointer.GetState());
            // updating pointer
            memoryPointer.SetState(Memory.LastIndex(memory));
        }

        /// <summary>
        /// Pushes instruction into the top of the stack
        /// </summary>
        /// <param name="instruction"></param>
        private void Push(Instruction instruction)
        {
            memory.Add(instruction);
            memoryPointer.SetState(Memory.LastIndex(memory));
        }

        private void ExecuteInstruction(Instruction instruction)
        {
            switch(instruction.GetOpcode())
            {
                case Opcodes.HALT: // exit out of the program
                    return;
                case Opcodes.POP:
                    Pop();
                    break;
                case Opcodes.PUSH:
                    Push(instruction);
                    break;
                case Opcodes.ADD:
                    // grabs from top of stack
                    private  memory[memoryPointer.GetState()];
                    Pop();


            }
        }

        public void ExecuteProgram()
        {

        }
    }
}
