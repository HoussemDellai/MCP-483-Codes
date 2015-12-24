using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexSamples
{
    class Program
    {
        static void Main(string[] args)
        {

            var email = "houssem.D_ellai@intilaq.tn";

            if (email.Contains("@") || email.Contains("."))
            {

            }

            Regex regex = new Regex(@"^[aA-zZ]+.[aA-zZ]+@{1}[aA-zZ]+.{1,2}[aA-zZ]+$", RegexOptions.Compiled);

            if (regex.IsMatch(email))
            {
                Console.WriteLine("Validée !");
            }
            else
            {
                Console.WriteLine("Non validée");
            }

            string emailText = email + "5";// + "dsnvlkswh" + email;

            var match = regex.Match(emailText);
        }
    }
}
