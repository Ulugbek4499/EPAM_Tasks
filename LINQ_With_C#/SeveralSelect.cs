using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_With_C_
{
    public class SeveralSelect
    {
        public static void StartUp()
        {
            List<int> integerList = new List<int>()
            {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10
            };

            List<int> intList = new List<int>()
            {
                100,200,300,400,500,600,700,800,900,1000
            };

            var mixed = from a in integerList
                        from b in intList
                        select a + b;

            foreach ( var a in mixed ) 
            {
                Console.WriteLine(a);
            }
        }
    }
}
