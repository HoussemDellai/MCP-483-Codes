using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListAndDictionary
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> list = new List<int>
            {
                5, 7, 4, 6, 8
            };

            var list2 = new List<int>();

            foreach (var i in list)
            {
                if (i % 2 == 0)
                {
                    list2.Add(i);
                }
            }

            var list3 = list.Where(i => i % 2 == 0).ToList();

            list.RemoveAt(2);

            var list4 = from x
                        in list
                        where x % 2 == 0
                        select x;

            var n = list.Find(i =>
            {
                return i / 2 == 4 || i / 3 == 2;
            });
            var n1 = list.First();
            var n2 = list.Last();

            var l = new[] { "5", "4", "2" };

            IEnumerable<string> y = new List<string> { "A", "B", "C", "D", "E" };

            var x1 = y.Skip(2).Take(4).ToList();

            if (list.Any())
            {

            }

            Console.WriteLine(n);

            foreach (var i in list4)
            {
                Console.WriteLine(i);
            }

            var employee1 = new Employee
            {
                Name = "Hassen",
                Surname = "Abdallah",
                DateDeNaissance = new DateTime(1990, 5, 20),
            };

            var employee2 = new Employee
            {
                Name = "Hassen",
                Surname = "Abdallah",
                DateDeNaissance = new DateTime(1980, 5, 20),
            };

            var employee3 = new Employee
            {
                Name = "Hassen",
                Surname = "Abdallah",
                DateDeNaissance = new DateTime(1985, 5, 20),
            };

            var employeesList = new List<Employee>
            {
                employee1, employee2, employee3
            };

            var filteredemployeesList = employeesList.Where(employee => employee.DateDeNaissance.Year > 1983).ToList();

            Console.WriteLine(filteredemployeesList.Count);

            Dictionary<string, Employee> dictionary = new Dictionary<string, Employee>
            {
                {"emp1", employee1},
                {"emp2", employee2},
                {"emp3", employee3}
            };

            if (dictionary.ContainsKey("emp3"))
            {
                var e = dictionary["emp3"];
            }

            var d = from emp
                    in dictionary
                    where emp.Value.DateDeNaissance.Year > 1983
                    select new
                    {
                        A = emp.Key,
                        B = emp.Value.Name,
                        C = emp.Value.DateDeNaissance
                    };

            Console.Read();
        }
    }
}
