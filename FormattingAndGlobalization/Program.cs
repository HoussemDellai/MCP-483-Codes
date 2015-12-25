using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormattingAndGlobalization
{
    class Program
    {
        static void Main(string[] args)
        {
            double cost = 1234.56;
            Console.WriteLine(cost.ToString("C", new System.Globalization.CultureInfo("en-US")));

            // Displays $1,234.56

            DateTime d = new DateTime(2013, 4, 22);
            CultureInfo provider = new CultureInfo("en-US");
            Console.WriteLine(d.ToString("d", provider)); // Displays 4/22/2013
            Console.WriteLine(d.ToString("D", provider)); // Displays Monday, April 22, 2013
            Console.WriteLine(d.ToString("M", provider)); // Displays April 22

            CultureInfo provider2 = new CultureInfo("ar-TN");
            Console.WriteLine(d.ToString("d", provider2));
            Console.WriteLine(d.ToString("D", provider2));
            Console.WriteLine(d.ToString("M", provider2));

            int a = 1;
            int b = 2;
            string s = "a: " + a + ", b: " + b;
            string result = string.Format("a: {0:C0}, b:{1}", a, b);
            Console.WriteLine(result); // Displays ‘a: 1, b: 2’
        }
    }
}
