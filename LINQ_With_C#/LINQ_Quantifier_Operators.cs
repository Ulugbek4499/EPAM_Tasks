using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_With_C_
{
    public class LINQ_Quantifier_Operators
    {
        //All
        //Any
        //Contains
        public static void StartUp()
        {

        }

        public static void Start_All()
        {
            int[] IntArray = { 11, 22, 33, 44, 55 };

            bool ResultMS = IntArray.All(x => x > 10);

            bool ResultQS = (from num in IntArray
                             select num).All(x => x > 10);
        }
    }
}
