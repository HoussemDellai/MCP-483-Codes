using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionSample
{
    public interface IPlugin
    {
        string Name
        {
            get;
        }
        string Description
        {
            get;
        }
        bool Load(int i);
    }

    public class MyPlugin : IPlugin
    {
        public string Name
        {
            get
            {
                return "MyPlugin";
            }
        }
        public string Description
        {
            get
            {
                return "My Sample Plugin";
            }
        }
        public bool Load(int i)
        {

            Console.WriteLine("Inside Load Method of Plugin !!!! " + i);

            return true;
        }
    }
}
