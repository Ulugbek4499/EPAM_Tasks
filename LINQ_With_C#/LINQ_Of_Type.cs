using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_With_C_
{
    public class LINQ_Of_Type
    {
        public static void StartUp()
        {
            List<object> source= new List<object>()
            {
                "Tom", "Jerry", "Henry", 1, 2,3,4, "Jane", "Jack"
            };

            List<int> intList=source.OfType<int>().ToList();

        }
    }
}
