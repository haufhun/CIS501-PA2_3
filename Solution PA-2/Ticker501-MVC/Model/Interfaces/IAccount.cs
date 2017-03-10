using System.Collections.Generic;

namespace Ticker501_MVC.Model.Interfaces
{
    public interface IAccount
    {
        decimal CashBalance { get; set; }

        decimal InvestedBalance { get; set; }
        
        int NumberOfStocks { get; set; }

        Dictionary<string, IPortfolio> Portfolios { get; set; }

        decimal GainsLosses { get; }

        decimal Fees { get; set; }
    }
}
