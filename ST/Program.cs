using System;
using AsilStok;

namespace ST
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Stock elma = new Stock("elma");
            elma.PriceChanged += OnPriceChanged;
            elma.MiktarChanged += OnMiktarChanged;
            elma.Miktar = 0;
            elma.Miktar = 20;
            elma.Price = 20.4M;
            elma.Price = 50;
            Console.ReadKey();

        }
        static void OnMiktarChanged(object o , MiktarChancedEventArgs e)
        {
            Console.WriteLine("eski miktar:" + e.oldMiktar);
            Console.WriteLine("yeni miktar:" + e.newMiktar);
        }

        static void OnPriceChanged(object o, PriceChancedEventArgs e)
        {
            Console.WriteLine("eski fiyat:" + e.oldPrice);
            Console.WriteLine("yeni fiyat:" + e.newPrice);
        }
    }
}