using System.Collections.Generic;

namespace Ticker501_MVC.Model.Interfaces
{
    public interface IPortfolio
    {
       /// <summary>
       /// This gets and sets the invested balance for the portfolio.
       /// </summary>
       decimal InvestedBalance { get; set; }

       /// <summary>
       /// This gets and sets the number of stocks for the portfolio.
       /// </summary>
       int NumberOfStocks { get; set; }

        /// <summary>
        /// This gets the gains and losses for portfolio level.
        /// </summary>
       decimal GainsLosses { get; }
        
       /// <summary>
       /// This gets and sets the dictionary holding the stocks in the portfolio.
       /// </summary>
       Dictionary<string, IStock> Stocks { get; set; }

    }
}
