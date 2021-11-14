using System;
using System.Collections;
namespace dummyvm
{
    /// <summary>
    /// Abstraction over am Array to simulate memory it should only contain integers within itself and a space for programs
    /// </summary>
    public class Memory: ArrayList
    {
        // program in memory
        private Instruction[] program = new Instruction[] { new Instruction(Opcodes.HALT, 0) };
        /// <summary>
        /// Constructor initializes with custom initial mem size
        /// </summary>
        /// <param name="initialMemSize"></param>
        public Memory(int initialMemSize)
            : base(initialMemSize)
        {
            
        }
        /// <summary>
        /// Constructing without specific initial memory allocation
        /// </summary>
        public Memory()
            : base()
        {

        }

        /// <summary>
        /// Logs all operands in memory
        /// </summary>
        public void DebugMemory()
        {
            foreach(var item in this)
            {
                Console.WriteLine(item);
            }
        }

        /// <summary>
        /// Loads a program into memory
        /// </summary>
        /// <param name="program"></param>
        public void LoadProgram(Instruction[] program)
        {
            this.program = program;
        }

        /// <summary>
        /// Clears program
        /// </summary>
        public void ClearProgram()
        {
            program = new Instruction[] { new Instruction(Opcodes.HALT, 0) };
        }

        /// <summary>
        /// Takes in index and return program instruction
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public Instruction FetchProgramInstruction(int index)
        {
                return program[index];
        }

        /// <summary>
        /// checks if memory is empty e.g no program is loaded
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty()
        {
            return Count == 0;
        }

        /// <summary>
        /// Utility function takes in memory and provides the index for the last item in it
        /// </summary>
        /// <param name="array"></param>
        /// <returns>Index of last operand</returns>
        public static int LastIndex(Memory array)
        {
            return array.Count - 1;
        }

        /// <summary>
        /// Logs the last item to enter memory
        /// </summary>
        public void Peek()
        {
            Console.WriteLine(this[Count - 1]);
        }
    }
}
