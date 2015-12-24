using System;

namespace FuncAndAction
{
    class Program
    {
        static void Main(string[] args)
        {

            Action action = new Action(() =>
            {
                Console.WriteLine("Inside Action !");
                Console.WriteLine("Inside Action 2 !");
            });

            // The following 2 invocation are equivalent
            action();
            action.Invoke();

            Action<int, string> actionWithParameters = new Action<int, string>((i, s) =>
            {
                Console.WriteLine("i : " + i);
                Console.WriteLine("s : " + s);
            });

            actionWithParameters.Invoke(5, "Home");
            actionWithParameters(5, "Home");

            Func<int, string, bool> func = new Func<int, string, bool>((i, s) =>
            {
                Console.WriteLine("i : " + i + "s : " + s);

                return true;
            });

            var result = func.Invoke(3, "IntilaQ");
            var result2 = func(3, "IntilaQ");

            InvokeFunc(func);

            Console.Read();
        }

        private static void InvokeFunc(Func<int, string, bool> func)
        {
            func.Invoke(4, "Home");
        }
    }
}
