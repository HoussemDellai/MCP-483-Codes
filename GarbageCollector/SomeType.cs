using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarbageCollector
{
    public class SomeType
    {

        ~SomeType()
        {
            // This code is called when the finalize method executes
        }

        public void Do()
        {
            
            StreamWriter stream = File.CreateText("temp.dat");
            stream.Write("some data");

            GC.Collect();
            GC.WaitForPendingFinalizers();

             //GC.WaitForFullGCComplete();

            File.Delete("temp.dat"); // Throws an IOException because the file is already open.

            DatabaseConnector databaseConnector = new DatabaseConnector();
            databaseConnector.OpenAccessToDatabase();
            databaseConnector.Dispose();

            using (DatabaseConnector dbConnector = new DatabaseConnector())
            {
                
            }

            Console.WriteLine("");
        }
    }
}
