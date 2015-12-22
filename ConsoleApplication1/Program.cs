using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            Func<int, string, bool> f = (i, s) =>
            {
                return true;
            };

            bool b = f.Invoke(5, "Home");


            //Contract.
            Class1 c1 = new Class1();

            c1.StockDepasseEvent += (x) =>
            {
                Console.WriteLine("Stock dépassé : " + x);
            };

            c1.EventRaiser += C1_EventRaiser;

            c1.NumberProducts = 30;

            Console.Read();
        }

        private static void C1_EventRaiser(object sender, EventArgs e)
        {
            
        }

        //private static void C1_StockDepasseEvent(int x)
        //{
        //    Console.WriteLine("Stock dépassé : " + x);
        //}
    }
}
