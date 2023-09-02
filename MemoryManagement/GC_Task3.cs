using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryManagement
{
    public class GC_Task3
    {
        public static void StartUp()
        {
            var points = new List<Point>(Enumerable.Repeat(new Point(), 10));
            foreach (var p in points)
            {
                p.IncX();
            }
            foreach (var p in points)
            {
                Console.WriteLine(p.X); //With Struct is will be shown 0,0,0,... struct works with the copy of the object
                                        //With Class it will be shown  1,1,1,... class works with the reference of the obj
            }
            Console.ReadKey();
        }
    }

    public struct Point
    {
        public int X;

        public void IncX()
        {
            X++;
        }
    }
}

// In the provided code, you are creating a list of Point structs, but since Point is a value type (struct),
// it's important to note that when you iterate over the list, you are working with copies of the original
// Point instances. Therefore, when you call p.IncX(), it increments the X property on a copy of the Point object,
// not on the original object stored in the list.