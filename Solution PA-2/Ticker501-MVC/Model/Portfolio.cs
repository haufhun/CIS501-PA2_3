using System.Collections.Generic;
using System.Linq;
using Ticker501_MVC.Model.Interfaces;

namespace Ticker501_MVC.Model
{
    public class Portfolio : IPortfolio
    {
        /// <summary>
        /// The amount of money invested in the portfolio
        /// </summary>
        public decimal InvestedBalance { get; set; }
        /// <summary>
        /// The total number of stocks in the portfolio
        /// </summary>
        public int NumberOfStocks { get; set; }
        /// <summary>
        /// A dictionary with a key of the stock name and a value of  
        /// the associated stock class.
        /// </summary>
        public Dictionary<string, IStock> Stocks { get; set; }
        /// <summary>
        /// The value of the stocks at the current price 
        /// minus the value of the stocks at their bought price.
        /// </summary>
        public decimal GainsLosses
        {
            get
            {
                return Stocks.Values.Sum(s => (_database.StockDatabase[s.Name].Item3 * s.NumberOfShares) - s.InvestedBalance);
            }
        }
        
        /// <summary>
        /// An instance of the database.
        /// </summary>
        private readonly IDatabase _database;



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
