using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    public class CustomException : Exception
    {
        public override string Message
        {
            get
            {
                return "Custom Eception";
            }
        }
    }
}
