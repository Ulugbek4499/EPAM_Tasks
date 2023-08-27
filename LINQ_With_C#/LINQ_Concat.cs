using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_With_C_
{
    public class LINQ_Concat
    {
        // Concat it concatenate two sequences into one sequence. 
        public static void StartUp()
        {
            List<int> sequence1 = new List<int> { 1, 2, 3, 4 };
            List<int> sequence2 = new List<int> { 2, 4, 6, 8 };

            var MS=sequence1.Concat(sequence2); //1 2 3 4 2 4 6 8

            var QS = (from a in sequence1
                      select a).Concat(sequence2);

            foreach (var item in MS)
            {
                Console.WriteLine(item);
            }
        }
    }
}
