using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multithreading
{
    public class Task2_Multithreading
    {
        public static async Task StartUp()
        {
            await MultithreadingStart();

          
        }

        public static async Task MultithreadingStart()
        {
            Console.Write("Enter the maximum number of readers allowed in the library (N): ");
            int N = int.Parse(Console.ReadLine());

            Console.Write("Enter the number of readers arriving (M): ");
            int M = int.Parse(Console.ReadLine());

            Console.Write("Enter the minimum time a reader spends in the library (T1 in milliseconds): ");
            int T1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the maximum time a reader spends in the library (T2 in milliseconds): ");
            int T2 = int.Parse(Console.ReadLine());

            SemaphoreSlim semaphore = new SemaphoreSlim(N, N); // Use N as the maximum count for the semaphore

            List<Task> readerTasks = new List<Task>();

            Random random = new Random();

            for (int i = 0; i < M; i++)
            {
                int readerNumber = i + 1;

                int randomTime = random.Next(T1, T2);

                Task readerTask = Task.Run(async () =>
                {
                    await semaphore.WaitAsync();

                    Console.WriteLine($"Reader {readerNumber} enters the library.");

                    // Record entry time
                    DateTime entryTime = DateTime.Now;

                    await Task.Delay(randomTime); // Use Task.Delay instead of Thread.Sleep

                    // Calculate time spent in the library
                    TimeSpan timeSpent = DateTime.Now - entryTime;

                    Console.WriteLine($"Reader {readerNumber} exits the library after {timeSpent.TotalMilliseconds} milliseconds.");

                    semaphore.Release();
                });

                readerTasks.Add(readerTask);
            }

            await Task.WhenAll(readerTasks); // Wait for all readers to finish

            Console.WriteLine("Simulation complete. All readers have exited.");
        }
    }
}
