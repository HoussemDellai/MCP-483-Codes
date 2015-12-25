using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionSample
{
    class Program
    {
        static void Main(string[] args)
        {

            int i = 42;
            System.Type itype = i.GetType();

            Console.WriteLine(itype);

            Assembly pluginAssembly = Assembly.Load("ReflectionSample");
            //Assembly pluginAssemblyFrom = Assembly.LoadFrom(@"Path");
            Assembly pluginAssembly2 = Assembly.GetAssembly(typeof(MyPlugin));
            Assembly pluginAssembly4 = Assembly.GetAssembly(typeof(Program));
            Assembly pluginAssembly3 = Assembly.GetExecutingAssembly();

            var types = pluginAssembly.GetTypes();

            //var plugins = from type in pluginAssembly.GetTypes()
            //              where typeof(IPlugin).IsAssignableFrom(type) && !type.IsInterface
            //              select type;

            foreach (Type pluginType in types)
            {
                if (pluginType.IsClass)
                {

                    Console.WriteLine("pluginType.FullName : " + pluginType.FullName);

                    var objectInstance = Activator.CreateInstance(pluginType);

                    MemberInfo[] memberInfos = objectInstance.GetType().GetMembers();

                    foreach (var memberInfo in memberInfos)
                    {
                        Console.WriteLine(memberInfo.Name);
                    }

                    MethodInfo loadMethod = objectInstance.GetType()
                        .GetMethod("Load", new Type[] { typeof(int) });

                    if (loadMethod != null)
                    {
                        bool result = (bool) loadMethod.Invoke(objectInstance, new object[] { 41 });
                    }
                }
            }

            Console.Read();
        }
    }
}
