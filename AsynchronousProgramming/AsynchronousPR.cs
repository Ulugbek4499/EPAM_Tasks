namespace AsynchronousProgramming
{
    public class AsynchronousPR
    {
        public static void MainStart()
        {
            Task1()
                .ContinueWith(task => Task2())
                .ContinueWith(task => Task3())
                .Wait();
        }

        static Task Task1()
        {
            Console.WriteLine("First Task is Starting...");
            return Task.Delay(2000)
                .ContinueWith(_ => Console.WriteLine("First Task is finished."));
        }

        static void Task2()
        {
            Console.WriteLine("Second Task is starting...");

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Second Task is running ({i + 1}/3)...");
                Task.Delay(1000).Wait();
            }

            Console.WriteLine("Second Task is finished.");
        }

        static void Task3()
        {
            Console.WriteLine("Third Task is starting...");

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine($"Third Task is running ({i + 1}/2)...");
                Task.Delay(1500).Wait();
            }

            Console.WriteLine("Third Task is finished.");
        }
    }
}