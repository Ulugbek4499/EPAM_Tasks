using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_With_C_
{
    public class LINQ_Example
    {
        public static void StartUp()
        {
            List<int> integerList = new List<int>()
            {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10
            };

            IEnumerable<int> QuerySyntax = from obj in integerList //Data Source
                              where obj > 5 //Condition
                              select obj; //Selection

            List<int> MethodSyntax = integerList.Where(obj => obj > 5).ToList();

            int MixedSyntax = (from obj in integerList
                                where obj > 5
                                select obj).Sum();

            foreach (var item in QuerySyntax)
            {
                Console.Write(item + " ");
            }
        }
    }
}
