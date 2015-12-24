#define MySymbol

using System;
using System.Diagnostics;

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

            DebugDirective();

            Console.Read();
        }

        public static void DebugDirective()
        {
#if DEBUG
            Console.WriteLine("Debug mode");
#else
            Console.WriteLine("Not debug");
#endif

#if MySymbol

#endif
        }
    }
}
