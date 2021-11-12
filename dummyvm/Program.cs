using System;
using System.Collections;
namespace dummyvm
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Memory testMem = new Memory();
            //testMem.Add(1);
            //testMem.Add(2);
            //testMem.Add(3);

            // testMem.DebugMemory();
            //testMem.Peek();

            Console.WriteLine(Opcodes.HALT);
        }
    }
}
