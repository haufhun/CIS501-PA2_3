using System.Collections.Generic;

namespace Ticker501_MVC.Model.Interfaces
{
    public interface IAccount
    {
        /// <summary>
        /// Gets and sets the cash balance in the account.
        /// </summary>
        decimal CashBalance { get; set; }

        /// <summary>
        /// Gets and sets the invested balance in the account.
        /// </summary>
        decimal InvestedBalance { get; set; }
        
        /// <summary>
        /// Gets and sets the number of stocks in the account.
        /// </summary>
        int NumberOfStocks { get; set; }

        /// <summary>
        /// This dictionary gets and sets the Portfolios held in the account.
        /// </summary>
        Dictionary<string, IPortfolio> Portfolios { get; set; }

        /// <summary>
        /// This gets the gains and losses for the account.
        /// </summary>
        decimal GainsLosses { get; }

        /// <summary>
        /// This gets and sets the fees used in the account.
        /// </summary>
        decimal Fees { get; set; }
    }
}
