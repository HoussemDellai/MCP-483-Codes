using System;
using Microsoft.Build.Framework;

namespace ListAndDictionary
{
    public class Employee
    {
        //[Required, MaxLength(20)]
        public string Name
        {
            get; set;
        }

        public string Surname
        {
            get; set;
        }

        public DateTime DateDeNaissance
        {
            get; set;
        }
    }
}
