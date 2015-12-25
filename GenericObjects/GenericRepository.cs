using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericObjects
{
    public class GenericRepository<T> where T : Employee, new()
    {

        private readonly List<T> _employees = new List<T>();
        //private T _t = default(T);
        //private string s = default(string);

        public void Add(T t)
        {
            
            _employees.Add(t);
        }

        public void Remove(T t)
        {

            if (_employees.Contains(t))
            {
                _employees.Remove(t);
            }
        }

        public List<T> GetAll()
        {
            return _employees;
        } 
    }
}
