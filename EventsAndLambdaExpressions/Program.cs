using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndLambdaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {

            var publisher = new Publisher();
            var subscriber = new Subscriber(publisher);

            subscriber.SubscribeToEvent();
            publisher.Stock = 20;

            Console.Read();
        }
    }
}
