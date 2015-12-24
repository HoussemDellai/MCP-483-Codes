using System;
using System.Diagnostics.Contracts;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                int x = 5;

                int y = x / 0;

                string z = "jhkjsdk";

                int a = Convert.ToInt32(z);

                //SetNameUsingContract("");
                //GetNameUsingContract();
            }
            catch (DivideByZeroException exception)
            {
                Console.WriteLine("Impossible de diviser par Zero !");
                Console.WriteLine(exception.Message);
            }
            catch (FormatException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
            finally
            {
                // will always occur
            }

            try
            {
                SetName("Houssem");
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                Console.WriteLine(exception.Data);
                Console.WriteLine(exception.Source);
            }
        }

        public static void SetName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("name is null or white space: " + name);
            }

            if (name.Length > 5)
            {
                throw new ArgumentException("Argument name is too long : " + name);
            }
        }

        public static void SetNameUsingContract(string name)
        {
            Contract.Requires(! string.IsNullOrWhiteSpace(name), "value is empty!");

            Name = name;
        }

        public static string GetNameUsingContract()
        {
            Contract.Ensures(!string.IsNullOrWhiteSpace(Contract.Result<string>()));

            return Name;
        }

        public static string Name { get; protected set; }
    }
}
