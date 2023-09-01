using System.Threading.Channels;

namespace MemoryManagement
{
    public class GarbageCollections
    {
        public static void StartUp()
        {
            Console.WriteLine($"Allocated memory is: {GC.GetTotalMemory(false)}");
            Console.ReadLine();

            DoSomethingBigOpertations();

            GC.Collect();

            Console.WriteLine($"Allocated memory is: {GC.GetTotalMemory(false)}");
            Console.ReadLine();
        }

        public static void DoSomethingBigOpertations()
        {
            byte[] myArray=new byte[1000000];
            Console.WriteLine($"Alocated Memory is {GC.GetTotalMemory(false)}");
            Console.ReadLine();
        }
    }
}
//So, the key difference is that GC.GetTotalMemory(true) includes the memory freed up by a garbage collection that
//was explicitly triggered before measuring memory usage, while GC.GetTotalMemory(false) does not include any memory
//freed up by garbage collection.

