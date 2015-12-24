using System;
using System.Threading;

namespace ThreadAndTask
{
    class Program
    {
        public static void ThreadMethod()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Thread Method");
                Thread.Sleep(0);
            }
        }

        [ThreadStatic]
        private static int _field;

        public static int TaskMethod()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Thread Method");
                Thread.Sleep(1000);
            }

            return 5;
        }

        public static void Main()
        {

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("Main thread");
            //    Thread.Sleep(0);
            //}

            //Thread thread1 = new Thread(ThreadMethod);

            //thread1.Start();

            //thread1.Name = "Thread #1";
            //Console.WriteLine(thread1.Name);
            //thread1.Priority = ThreadPriority.Normal;
            //Console.WriteLine(thread1.Priority);
            //Console.WriteLine(thread1.ManagedThreadId);

            //thread1.Join();

            //Thread thread2 = new Thread(() =>
            //{
            //    for (int i = 0; i < 10; i++)
            //    {
            //        Console.WriteLine("Thread Method #2");
            //        Thread.Sleep(0);
            //    }
            //});

            //thread2.IsBackground = false;

            //thread2.Start();

            //Thread thread3 = new Thread(ThreadMethodWithParameter);

            //thread3.Start("Home");

            //Thread thread4 = new Thread(ThreadtWithAccessToField);
            //Thread thread5 = new Thread(ThreadtWithAccessToField);

            //thread4.Start("Thread #4");
            //thread5.Start("Thread #5");

            //thread4.Join();
            //thread5.Join();

            //Console.WriteLine("_field : " + _field);
            
            //ThreadPool.QueueUserWorkItem(ThreadtWithAccessToField);
            //ThreadPool.QueueUserWorkItem(ThreadtWithAccessToField);

            TaskSample taskSample = new TaskSample();
            taskSample.Execute();

            //Console.Read();
        }

        private static void ThreadtWithAccessToField(object obj)
        {
            for (int i = 0; i < 10; i++)
            {
                _field++;
                Console.WriteLine("Thread" + obj + " _field := " + _field);
                Thread.Sleep(100);
            }
        }

        private static void ThreadMethodWithParameter(object obj)
        {
            string s = obj.ToString();

            Console.WriteLine(s);
        }
    }
}
