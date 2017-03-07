using System.Collections.Generic;
using Ticker501_MVC.Model.Interfaces;

namespace Ticker501_MVC.Model
{
    public class Account : IAccount
    {
        /// <summary>
        /// The trade fee for buying/selling stocks.
        /// </summary>
        public const decimal TRADE_FEE = 9.99m;
        /// <summary>
        /// The transfer fee for depositing/withdrawing money.
        /// </summary>
        public const decimal TRANSFER_FEE = 4.99m;

        /// <summary>
        /// The total cash in the account.
        /// </summary>
        public decimal CashBalance { get; set; }
        /// <summary>
        /// The total worth of all stocks invested into the market.
        /// </summary>
        public decimal InvestedBalance { get; set; }
        /// <summary>
        /// The total number of stocks invested.
        /// </summary>
        public int NumberOfStocks { get; set; }
        /// <summary>
        /// A field indicating how much the user has gained/lost.
        /// </summary>
        public decimal GainsLosses { get; set; }
        /// <summary>
        /// A dictionary of the portfolios associated with this account.
        /// </summary>
        public Dictionary<string, IPortfolio> Portfolios { get; set; }
        

        /// <summary>
        /// Constructor initializing all fields. 
        /// </summary>
        public Account()
        {
            CashBalance = 0m;
            InvestedBalance = 0m;
            NumberOfStocks = 0;
            Portfolios = new Dictionary<string, IPortfolio>();
            GainsLosses = 0m;
        }
        
    }
}
