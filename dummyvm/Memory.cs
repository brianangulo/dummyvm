using System;
using System.Collections;
namespace dummyvm
{
    /// <summary>
    /// Abstraction over am Array to simulate memory
    /// </summary>
    public class Memory: ArrayList
    {
        public Memory(int initialMemSize)
            : base(initialMemSize)
        {
            
        }

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
            foreach(Instruction instruction in program)
            {
                Add(instruction);
            }
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
