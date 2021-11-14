using System;
using System.Collections;

namespace dummyvm
{
    public class CPU
    {
        private readonly Memory memory;
        private readonly Register<int> memoryPointer;
        private readonly Register<int> accumulator = new Register<int>();

        public CPU(Memory memory)
        {
            this.memory = memory;
            memoryPointer = new Register<int>(Memory.LastIndex(memory));
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
        private void Push(int data)
        {
            memory.Add(data);
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
                    Push(instruction.GetInstructionData());
                    break;
                case Opcodes.ADD:
                    // grabs from top of stack
                    accumulator.SetState((int)memory[memoryPointer.GetState()]);
                    Pop();
                    accumulator.SetState(accumulator.GetState() + (int)memory[memoryPointer.GetState()]);
                    Pop();
                    Push(accumulator.GetState());
                    accumulator.SetState(0);
                    break;
                case Opcodes.SUB:
                    // grabs from top of stack
                    accumulator.SetState((int)memory[memoryPointer.GetState()]);
                    Pop();
                    accumulator.SetState(accumulator.GetState() - (int)memory[memoryPointer.GetState()]);
                    Pop();
                    Push(accumulator.GetState());
                    accumulator.SetState(0);
                    break;
                case Opcodes.PRINT:
                    Console.WriteLine(memory[memoryPointer.GetState()]);
                    break;
                default:
                    return;
            }
        }

        /// <summary>
        /// Executes a program from memory, each cycle composed of a fetching + execution phase
        /// </summary>
        public void ExecuteProgram()
        {
            var index = 0;
            while(memory.FetchProgramInstruction(index).GetOpcode() != Opcodes.HALT)
            {
                // fetching instruction
                var fetchedInstruction = memory.FetchProgramInstruction(index);
                // execution fase
                ExecuteInstruction(fetchedInstruction);
                index++;
            }

        }
    }
}
