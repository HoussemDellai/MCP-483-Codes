using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<Employee> list = new List<Employee>();
            GenericRepository<Employee> genericRepository = new GenericRepository<Employee>();

            var employee = new Employee
            {
                Name = "Hassen",
                Department = "R&D"
            };

            genericRepository.Add(employee);

            Console.WriteLine(genericRepository.GetAll().Count);

            genericRepository.Remove(employee);

            Console.WriteLine(genericRepository.GetAll().Count);
        }
    }
}
