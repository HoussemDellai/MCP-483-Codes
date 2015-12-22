using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace JsonAndXmlSerialization
{

    [DataContract]
    public class Employee
    {
        [DataMember]
        public int Id
        {
            get; set;
        }

        [DataMember]
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
