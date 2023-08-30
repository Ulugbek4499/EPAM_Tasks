using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;

namespace LINQ_With_C_
{
    public class LINQ_Aggregate_Functions
    {
        //Sum() : This method is used to calculate the total(sum) value of the collection.
        //Max(): This method is used to find the largest value in the collection
        //Min() : This method is used to find the smallest value in the collection
        //Average() : This method is used to calculate the average value of the numeric type of the collection.
        //Count(): This method is used to count the number of elements present in the collection.
        //Aggregate(): This method is used to Perform a custom aggregation operation on the values of a collection.

        public static void StartUp()
        {

        }

        public static void Start_Sum()
        {
            int[] intNumbers = new int[] { 10, 30, 50, 40, 60, 20, 70, 90, 80, 100 };

            int MSTotal = intNumbers.Sum();

            int QSTotal = (from num in intNumbers
                           select num).Sum();

            Console.WriteLine("Sum = " + QSTotal);
        }

        public static void Start_Max_Min()
        {
            int[] intNumbers = new int[] { 10, 80, 50, 90, 60, 30, 70, 40, 20, 100 };

            int MSLergestNumber = intNumbers.Max();

            int QSLergestNumber = (from num in intNumbers
                                   select num).Max();

            Console.WriteLine("Largest Number = " + MSLergestNumber);
        }


    }
}
