using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryManagement
{
    public class GarbageCollection_WithoutStatic
    {
        public static void StartUp()
        {
            EndOfProgramGarbageCollectible obj = new EndOfProgramGarbageCollectible();

            GC.Collect();
          
            Console.WriteLine("End of program");

            obj.Dispose();
        }
    }

    public class EndOfProgramGarbageCollectible : IDisposable
    {
        public EndOfProgramGarbageCollectible()
        {
            Console.WriteLine("End Of Garbage Collection Object Created");
        }

        ~EndOfProgramGarbageCollectible()
        {
            Console.WriteLine("Object finalized and collected");
        }

        public void Dispose()
        {
            Console.WriteLine("Object disposed and collected");
        }
    }
}
