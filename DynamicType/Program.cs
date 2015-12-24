using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Office.Interop.Excel;

namespace DynamicType
{
    class Program
    {
        static void Main(string[] args)
        {
            //dynamic d = 5;
            //d = "home";

            //var v = 5;
            //v = "home"; // error


            dynamic employee = new
            {
                Name = "Hassen",
                Surname = "Dellai",
                Age = 25,
            };

            //employee.Name = "Houssem"; // Error, Name is readonly
            //employee.Name = 5; //

            //employee.DateNaissance = "1980";// doesn't work

            Console.WriteLine(employee);
            Console.WriteLine(employee.Name);
            //Console.WriteLine(employee.DateNaissance); // generates exeption

            employee = new
            {
                NomProduit = "Phone",
                Prix = 500,
            };

            Console.WriteLine(employee);
            Console.WriteLine(employee.NomProduit);

            IEnumerable<dynamic> entities = new List<dynamic>
            {
                new
                {
                    ColumnA = "Hassen",
                    ColumnB = "Mohamed",
                },
                new
                {
                    ColumnA = "Hssen",
                    ColumnB = "Marwen",
                },
            };

            DisplayInExcel(entities);
        }

        static void DisplayInExcel(IEnumerable<dynamic> entities)
        {
            var excelApp = new Application
            {
                Visible = true
            };
            excelApp.Workbooks.Add();

            dynamic workSheet = excelApp.ActiveSheet;

            workSheet.Cells[1, "A"] = "Header A";
            workSheet.Cells[1, "B"] = "Header B";

            var row = 1;
            foreach (var entity in entities)
            {
                row++;
                workSheet.Cells[row, "A"] = entity.ColumnA;
                workSheet.Cells[row, "B"] = entity.ColumnB;
            }

            workSheet.Columns[1].AutoFit();
            workSheet.Columns[2].AutoFit();
        }
    }
}
