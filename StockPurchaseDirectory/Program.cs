using System;
using System.Collections.Generic;

namespace StockPurchaseDirectory
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> stocks = new Dictionary<string, string>();
            stocks.Add("GM", "General Motors");
            stocks.Add("CAT", "Caterpillar");
            stocks.Add("EB", "Eventbrite");
            stocks.Add("AMZN", "Amazon");
            stocks.Add("JWN", "Nordstrom");

            List<(string ticker, int shares, double price)> purchases = new List<(string, int, double)>();

            purchases.Add((ticker: "GE", shares: 150, price: 23.21));
            purchases.Add((ticker: "EB", shares: 500, price: 22.29));
            purchases.Add((ticker: "AMZN", shares: 10, price: 1223.80));
            purchases.Add((ticker: "CAT", shares: 80, price: 75.55));
            purchases.Add((ticker: "JWN", shares: 1000, price: 38.15));

            foreach (var (ticker, shares, price) in purchases)
            {
                Console.WriteLine($"Ticker: {ticker} | # of Shares: {shares} | Price: ${price}");
            }
            Console.ReadKey();
        }
    }
}
