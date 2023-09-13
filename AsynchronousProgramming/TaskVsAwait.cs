using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsynchronousProgramming
{
    public class TaskVsAwait
    {
        public static async Task StartUp()
        {
            Console.WriteLine("Starting the program");

            // I/O-bound example using async/await
            Stopwatch ioStopwatch = Stopwatch.StartNew();
            await DownloadWebPageAsync();
            ioStopwatch.Stop();
            Console.WriteLine($"I/O-bound operation took {ioStopwatch.ElapsedMilliseconds} ms");

            // CPU-bound example using Task.Run
            Stopwatch cpuStopwatch = Stopwatch.StartNew();
            await CalculateFactorialAsync(100);
            cpuStopwatch.Stop();
            Console.WriteLine($"CPU-bound operation took {cpuStopwatch.ElapsedMilliseconds} ms");

            Console.WriteLine("Program completed");
        }
        static async Task DownloadWebPageAsync()
        {
            using (var httpClient = new HttpClient())
            {
                string result = await httpClient.GetStringAsync("https://www.example.com");
                Console.WriteLine($"Downloaded {result.Length} characters");
            }
        }

        static async Task<long> CalculateFactorialAsync(int n)
        {
            return await Task.Run(() => CalculateFactorial(n));
        }

        static long CalculateFactorial(int n)
        {
            if (n == 0)
                return 1;

            long result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
