using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_With_C_
{
    public class LINQ_Set
    {
        //Distinct  --> Remove Duplicates form DataSource
        //Except    --> Returns all elements from the first data source which don't excit in the second data source
        //Intersect --> Returns common elements on data sourse
        //Union     --> It combines two data sources and produces single result
        public static void StartUp()
        {
           
        }

        public static void DistinctStart()
        {
            List<int> intCollection = new List<int>()
            {
                1,2,3,2,3,4,4,5,6,3,4,5
            };

            IEnumerable<int> MS =intCollection.Distinct();

            IQueryable<int> QS = (from a in intCollection
                    select a).Distinct().AsQueryable();

            foreach (var item in MS)
            {
                Console.WriteLine(item);
            }
        }

        public static void ExceptStart()
        {
            List<int> dataSource1 = new List<int>() { 1, 2, 3, 4, 5, 6 };
            List<int> dataSource2 = new List<int>() { 1, 3, 5, 8, 9, 10 };

            var MS = dataSource1.Except(dataSource2);  // 2 4 6

            var QS= (from a in dataSource1
                    select a).Except(dataSource2);

            foreach (var item in MS)
            {
                Console.WriteLine(item);
            }
        }

        public static void IntersectStart()
        {
            List<int> dataSource1 = new List<int>() { 1, 2, 3, 4, 5, 6 }; 
            List<int> dataSource2 = new List<int>() { 1, 3, 5, 8, 9, 10 };

            var MS = dataSource1.Intersect(dataSource2);  //1 3 5.

            var QS=(from a in dataSource1
                   select a).Intersect(dataSource2);
        }

        public static void UnionEnd()
        {
            List<int> dataSource1 = new List<int>() { 1, 2, 3, 4, 5, 6 };
            List<int> dataSource2 = new List<int>() { 1, 3, 5, 8, 9, 10 };

            var MS=dataSource1.Union(dataSource2); //1 2 3 4 5 6 8 9 10

            var QS = (from a in dataSource1
                      select a).Union(dataSource2);
        }
    }
}
