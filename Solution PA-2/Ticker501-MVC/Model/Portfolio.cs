using System.Collections.Generic;
using Ticker501_MVC.Model.Interfaces;

namespace Ticker501_MVC.Model
{
    public class Portfolio : IPortfolio
    {
        public decimal InvestedBalance { get; set; }
        public int NumberOfStocks { get; set; }
        public Dictionary<string, IStock> Stocks { get; set; }
        public decimal GainsLosses { get; set; }

        /// <summary>
        /// Constructor that initializes all components of the portfolio.
        /// </summary>
        public Portfolio()
        {
            InvestedBalance = 0m;
            NumberOfStocks = 0;
            Stocks = new Dictionary<string, IStock>();
        }

    }
}
