using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryManagement
{
    public class ResurrectingObject_Start
    {
        public static void StartUp()
        {

            var obj = new ResurrectingObject();
            //obj = null;
           
            // Force garbage collection to trigger finalization
            //GC.Collect();
            obj.Dispose();
           // GC.WaitForPendingFinalizers();

            Console.WriteLine("End of program");
        }
    }

    public class ResurrectingObject
    {
        public ResurrectingObject()
        {
            Console.WriteLine("Resurrecting object Created");
        }

        ~ResurrectingObject()
        {
            Console.WriteLine("Object Finalized");

            GC.ReRegisterForFinalize(this);
            Console.WriteLine("Object Resurrecting and re-regested for finalization");
        }

        public void Dispose()
        {
            Console.WriteLine("Object Disposed");
            GC.SuppressFinalize(this);
        }
    }
}
