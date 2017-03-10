using System.Collections.Generic;
using System.Linq;
using Ticker501_MVC.Model.Interfaces;

namespace Ticker501_MVC.Model
{
    public class Portfolio : IPortfolio
    {
        
        public decimal InvestedBalance { get; set; }
        public int NumberOfStocks { get; set; }
        public Dictionary<string, IStock> Stocks { get; set; }

        private readonly IDatabase _database;

        public decimal GainsLosses
        {
            get
            {
                return Stocks.Values.Sum(s => (_database.StockDatabase[s.Name].Item3 * s.NumberOfShares) - s.InvestedBalance);
            }
        }

        /// <summary>
        /// Constructor that initializes all components of the portfolio.
        /// </summary>
        public Portfolio(IDatabase database)
        {
            _database = database;
            InvestedBalance = 0m;
            NumberOfStocks = 0;
            Stocks = new Dictionary<string, IStock>();
        }

    }
}
