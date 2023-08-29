using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_With_C_
{
    public class LINQ_Ordering
    {
        //  OrderBy             --> sort by order
        //  OrderByDescending   --> sort by descending
        //  ThenBy              --> sort the data based on multiple values or multiple expressions
        //  ThenByDescending    --> 
        //  Reverse             --> 
        public static void StartUp()
        {

        }

        public static void OrderByStart()
        {
            List<int> intList = new List<int>() { 10, 45, 35, 29, 100, 69, 58, 50 };

            var MS = intList.OrderBy(num=>num);

            var MSD=intList.OrderByDescending(num=>num);

            var QS= from a in intList
                    orderby a descending
                    select a;

            foreach (var ms in MS)
            {
                Console.WriteLine(ms);
            }
        }

        public static void ThenBy()
        {
            var MS = Student.GetAllStudents()
                         .OrderBy(a => a.FirstName)
                         .ThenBy(a => a.LastName)
                         .OrderBy(a => a.FirstName);

            var QS= from std in Student.GetAllStudents()
                    orderby std.FirstName
                    orderby std.LastName
                    select std;

        }

 
    }

    public class Student
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Branch { get; set; }
        public static List<Student> GetAllStudents()
        {
            List<Student> listStudents = new List<Student>()
            {
                new Student{ID= 101,FirstName = "Preety",LastName = "Tiwary",Branch = "CSE"},
                new Student{ID= 102,FirstName = "Preety",LastName = "Agrawal",Branch = "ETC"},
                new Student{ID= 103,FirstName = "Priyanka",LastName = "Dewangan",Branch = "ETC"},
                new Student{ID= 104,FirstName = "Hina",LastName = "Sharma",Branch = "ETC"},
                new Student{ID= 105,FirstName = "Anugrag",LastName = "Mohanty",Branch = "CSE"},
                new Student{ID= 106,FirstName = "Anurag",LastName = "Sharma",Branch = "CSE"},
                new Student{ID= 107,FirstName = "Pranaya",LastName = "Kumar",Branch = "CSE"},
                new Student{ID= 108,FirstName = "Manoj",LastName = "Kumar",Branch = "ETC"},
                new Student{ID= 109,FirstName = "Pranaya",LastName = "Rout",Branch = "ETC"},
                new Student{ID= 110,FirstName = "Saurav",LastName = "Rout",Branch = "CSE"}
            };
            return listStudents;
        }
    }
}
