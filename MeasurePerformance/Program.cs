using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeasurePerformance
{
    class Program
    {
        static void Main(string[] args)
        {

            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            var dateTime = DateTime.Now;

            for (int i = 0; i < 1000000; i++)
            {
                string str = "Home";
            }

            stopwatch.Stop();

            Console.WriteLine(stopwatch.Elapsed.TotalMilliseconds);

            stopwatch.Restart();

            Parallel.For(0, 1000000, (i) =>
            {
                string str = "Home";
            });

            stopwatch.Stop();

            Console.WriteLine(stopwatch.Elapsed.TotalMilliseconds);

            //var time = DateTime.Now;

            //var totalMilliseconds = (dateTime - time).TotalMilliseconds;

            PerformanceCounters performanceCounters = new PerformanceCounters();
            performanceCounters.MeasurePerf();
        }
    }
}
