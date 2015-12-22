using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebugAndTrace
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 20;

            int y = x * 3;

            // Shows up only on Debug mode.
            Debug.WriteLine(x);
            Debug.Assert(x < 10, "x < 10 : Release mode");

            // Shows up only on Release mode.
            Trace.WriteLine("Message showing even in Release mode.");
            Trace.Assert(x < 10, "x < 10 : Release mode");

            Console.Read();
        }
    }
}
