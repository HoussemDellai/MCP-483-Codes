using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadAndWriteFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "D:\\myFile.txt";

            if (!File.Exists(path))
            {
                File.Create(path);
            }

            //Environment.SpecialFolder.Desktop;

            File.WriteAllText(path, "Hello!");
            File.AppendAllText(path, "IntilaQ!");

            Console.WriteLine(File.ReadAllText(path));

            Console.WriteLine(Directory.GetCurrentDirectory());

            Console.Read();
        }
    }
}
