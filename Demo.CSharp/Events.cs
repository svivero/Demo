using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.CSharp
{
    public class Broadcaster {

        // Delegate definition 
        public delegate void PriceChangedHandler (decimal oldPrice, decimal newPrice);        

        // Creating an event the old way
        public event PriceChangedHandler PriceChanged;

        // The compiler translates the above to:
        // PriceChangedHandler priceChanged;
        // public event PriceChangedHandler PriceChanged { add { priceChanged += value; } remove { priceChanged -= value; } }

        // Creating an event the new way, using the event pattern
        public class PriceChangedEventArgs : System.EventArgs
        {
            public readonly decimal LastPrice; public readonly decimal NewPrice;
            public PriceChangedEventArgs(decimal lastPrice, decimal newPrice)
            {
                LastPrice = lastPrice;
                NewPrice = newPrice;
            }
        }
        public event EventHandler<PriceChangedEventArgs> PriceChanged2;
        protected virtual void OnPriceChanged2(PriceChangedEventArgs e)
        {
            if (PriceChanged2 != null) PriceChanged2(this, e);
        }
    }   

}
