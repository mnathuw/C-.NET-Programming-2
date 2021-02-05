using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    class Stock
    {
        private string symbol;
        private string name;
        private decimal previousClosingPrice;
        private decimal currentPrice;
        public Stock (string symbol, string name, decimal previousClosingPrice, decimal currentPrice)
        {
            this.symbol = symbol;
            this.name = name;
            this.previousClosingPrice = previousClosingPrice;
        }

        public decimal GetCurrentPrice()
        {
            return this.currentPrice;
        }

        public void SetCurrentPrice (decimal currentPrice)
        {
            this.currentPrice = currentPrice;
        }

        public decimal GetChangePercent()
        {
            return (currentPrice - previousClosingPrice) / previousClosingPrice * 100;
        }


    }
}
