using System;
namespace AsilStok
{ public class Stock
    {
        String tip;
        decimal price;
        decimal miktar;
        int amount = 10;
        public Stock(String tip) => this.tip = tip;

        //public delegate void MiktarChangedHandler (object sender, EventArgs a);
        //public event MiktarChangedHandler MiktarChanged;
        public delegate void EHandler<TEventArgs>(object sender, TEventArgs e);
        public event EHandler<MiktarChancedEventArgs> MiktarChanged;
        public decimal Miktar
        {
            get => miktar;
            set
            {
                if (miktar == amount) return;
                decimal oldMiktar = miktar;
                miktar = amount;
                MiktarChanged(this, new MiktarChancedEventArgs(oldMiktar, miktar));
            }
        }
        public delegate void EHandler1<TEventArgs>(object sender, TEventArgs e);
        public event EHandler<PriceChancedEventArgs> PriceChanged;
           public decimal Price
        {
            get => price;
            set
            {
                if (price == value) return;
                decimal oldPrice = price;
                price = value;
                PriceChanged(this, new PriceChancedEventArgs(oldPrice, price));
            }
        }
      }      
    public class MiktarChancedEventArgs : EventArgs
    {
        public readonly decimal oldMiktar;
        public readonly decimal newMiktar;
        public MiktarChancedEventArgs(decimal oldMiktar, decimal newMiktar)
        {
            this.oldMiktar = oldMiktar;
            this.newMiktar = newMiktar;
        }
    }
    public class PriceChancedEventArgs : EventArgs
    {
        public readonly decimal oldPrice;
        public readonly decimal newPrice;
        public PriceChancedEventArgs(decimal oldPrice, decimal newPrice)
        {
            this.oldPrice = oldPrice;
            this.newPrice = newPrice;
        }
    }
    
}
