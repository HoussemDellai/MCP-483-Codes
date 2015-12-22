using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndLambdaExpressions
{
    public class Publisher
    {
        private int _stock;

        public int Stock    
        {
            get { return _stock; }
            set
            {
                if (value > 10)
                {
                    // Notify the subscribers that the room 
                    // can not support the stock
                    if (OnStockOverflow != null)
                    {
                        OnStockOverflow(value);
                    }
                }
                _stock = value;
            }
        }
        
        public delegate void StockOverflow(int stock);

        public event StockOverflow OnStockOverflow;
    }
}
