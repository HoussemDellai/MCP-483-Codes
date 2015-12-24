using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Web.Script.Serialization;
using System.Xml.Serialization;

namespace JsonAndXmlSerialization
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee employee = new Employee
            {
                Id = 5,
                Name = "Houssem",
                DateDeNaissance = DateTime.Now,
                Surname = "Dellai"
            };

            SerializeUsingJavaScriptSerializer(employee);

            SerializeListUsingJavascriptSerializer(employee);

            SerializeUsingXmlSerializer(employee);

            SerializeUsingDataContractJsonSerializer(employee);
            
            Console.Read();
        }

        private static void SerializeUsingDataContractJsonSerializer(Employee employee)
        {
            DataContractJsonSerializer contractJsonSerializer = new DataContractJsonSerializer(typeof(Employee));

            MemoryStream stream = new MemoryStream();

            contractJsonSerializer.WriteObject(stream, employee);

            stream.Position = 0;
            StreamReader sr = new StreamReader(stream);
            Console.Write("JSON form of Person object: ");
            Console.WriteLine(sr.ReadToEnd());
        }

        private static void SerializeUsingXmlSerializer(Employee employee)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Employee));

            string xml;
            using (StringWriter stringWriter = new StringWriter())
            {
                xmlSerializer.Serialize(stringWriter, employee);
                xml = stringWriter.ToString();
            }

            Console.WriteLine(xml);

            var employeesList = new List<Employee>
            {
                employee, employee, employee
            };

            XmlSerializer xmlSerializer2 = new XmlSerializer(typeof(List<Employee>));

            string xml2;
            using (StringWriter stringWriter2 = new StringWriter())
            {
                xmlSerializer2.Serialize(stringWriter2, employeesList);
                xml2 = stringWriter2.ToString();
            }

            Console.WriteLine(xml2);
        }

        private static void SerializeListUsingJavascriptSerializer(Employee employee)
        {

            List<Employee> employeesList = new List<Employee>();
            employeesList.Add(employee);
            employeesList.Add(employee);
            employeesList.Add(employee);

            var javaScriptSerializer = new JavaScriptSerializer();

            string jsonEmployeesList = javaScriptSerializer.Serialize(employeesList);

            Console.WriteLine(jsonEmployeesList);
        }

        private static void SerializeUsingJavaScriptSerializer(Employee employee)
        {
            JavaScriptSerializer javaScriptSerializer = new JavaScriptSerializer();
            var json = javaScriptSerializer.Serialize(employee);

            Console.WriteLine(json);

            var employeeAfterDesialization = javaScriptSerializer.Deserialize<Employee>(json);

            Console.WriteLine(employeeAfterDesialization.Name);
        }
    }
}
