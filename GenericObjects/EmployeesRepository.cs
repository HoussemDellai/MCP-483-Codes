using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericObjects
{
    public class EmployeesRepository
    {

        private readonly List<Employee> _employees = new List<Employee>();

        public void Add(Employee employee)
        {

            _employees.Add(employee);
        }

        public void Remove(Employee employee)
        {
            
            if (_employees.Contains(employee))
            {
                _employees.Remove(employee);
            }
        }
    }
}
