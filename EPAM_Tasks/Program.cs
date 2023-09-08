using LINQ_With_C_;
using MemoryManagement;
using Multithreading;

namespace EPAM_Tasks
{
    public class Program
    {
        static void Main(string[] args)
        {
            //          ***Memory MANAGEMENT***
            //GarbageCollections.StartUp();
            //GarbageCollection_WithoutStatic.StartUp();
            //ResurrectingObject_Start.StartUp();
            //GC_Task3.StartUp();
            //Multithreading_Example.StartUp();

            Task2_Multithreading.StartUp();

            //LINQ_Example.StartUp();

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();

        }
    }
}