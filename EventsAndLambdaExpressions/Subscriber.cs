using System;

namespace EventsAndLambdaExpressions
{
    public class Subscriber
    {

        private Publisher _publisher;

        public Subscriber(Publisher publisher)
        {
            _publisher = publisher;
        }

        public void SubscribeToEvent()
        {
            // Using Method
            _publisher.OnStockOverflow += PublisherOnStockOverflow;
            
            // Using Lambda Expression
            _publisher.OnStockOverflow += (stock) =>
            {
                Console.WriteLine("Stock Overflow !!!" + stock);
            };
        }

        /// <summary>
        /// This method will be raised every time
        /// </summary>
        private void PublisherOnStockOverflow(int stock)
        {
            Console.WriteLine("Stock Overflow !!!" + stock);
        }
    }
}
