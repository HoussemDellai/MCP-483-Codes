using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionClassLibrary
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
        bool Load();
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
        public bool Load()
        {
            return true;
        }
    }
}
