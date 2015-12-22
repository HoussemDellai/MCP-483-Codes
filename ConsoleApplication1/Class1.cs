using System;

namespace ConsoleApplication1
{
    public class Class1
    {

        private int _numberProducts;

        public int NumberProducts
        {
            get
            {
                return _numberProducts;
            }
            set
            {
                if (value > 10)
                {
                    if (StockDepasseEvent != null)
                    {
                        StockDepasseEvent(value);
                    }
                }
                _numberProducts = value;
            }
        }

        public delegate void StockDepasseDelegate(int x);

        public event StockDepasseDelegate StockDepasseEvent;

        public event EventHandler EventRaiser;
    }
}
