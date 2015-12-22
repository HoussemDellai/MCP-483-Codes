using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadAndTask
{
    class Program
    {
        public static void ThreadMethod()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("ThreadProc");
                Thread.Sleep(0);
            }
        }
        public static void Main()
        {

            Thread t = new Thread(ThreadMethod);

            t.Start();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Main thread");
                Thread.Sleep(0);
            }

            //t.Join();

            Console.Read();
        }
    }
}
