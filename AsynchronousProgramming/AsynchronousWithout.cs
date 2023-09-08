using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsynchronousProgramming
{
    public class AsynchronousWithout
    {
        public static void SartUpAsync()
        {
            TimeConsumingWorkAsync();

            TimeConsumingWorkWithPLINQ();

            TimeConsumingWithForEach();
        }

        public static async Task TimeConsumingWorkAsync()
        {
            Console.WriteLine("Starting...");

            var task1 = Task.Run(() => TimeConsumingWork(2));
            var task2 = Task.Run(() => TimeConsumingWork(4));
            var task3 = Task.Run(() => TimeConsumingWork(6));

            await Task.WhenAll(task1, task2, task3);

            Console.WriteLine("All tasks are finished.");
        }

        public static void TimeConsumingWorkWithPLINQ()
        {
            Console.WriteLine("Starting with PLINQ...");

            var numbers = Enumerable.Range(1, 10);

            var plinqResult = numbers.AsParallel()
                .Select(num => TimeConsumingWork(num))
                .ToList();

            Console.WriteLine("PLINQ is finished.");
        }

        public static void TimeConsumingWithForEach()
        {
            Console.WriteLine("Starting Parallel.ForEach...");

            var numbers = Enumerable.Range(1, 10);

            var parallelResult = new int[10];

            Parallel.ForEach(numbers, (num) =>
            {
                parallelResult[num - 1] = TimeConsumingWork(num);
            });

            Console.WriteLine("Parallel.ForEach is finished.");
        }

        public static int TimeConsumingWork(int a)
        {
            Console.WriteLine($"Starting work for {a}");
            Thread.Sleep(2000); 
            int result = a * a;
            Console.WriteLine($"Finished work for {a}, result: {result}");
            
            return result;
        }
    }
}
