namespace Multithreading
{
    public class Multithreading_Example
    {
        public static void StartUp()
        {
            try
            {
                new Thread(Go).Start();
            }
            catch (Exception ex)
            {
                // We'll never get here!
                Console.WriteLine("Exception!");
            }
        }
        static void Go() { throw null; }   // Throws a NullReferenceException
    }
}