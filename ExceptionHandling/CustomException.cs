using System;

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
