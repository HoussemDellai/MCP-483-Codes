using System;
using System.Runtime.Serialization;

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
