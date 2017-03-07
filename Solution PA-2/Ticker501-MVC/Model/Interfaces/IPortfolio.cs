using System.Collections.Generic;

namespace Ticker501_MVC.Model.Interfaces
{
    public interface IPortfolio
    {
       decimal InvestedBalance { get; set; }

       int NumberOfStocks { get; set; }
        
       Dictionary<string, IStock> Stocks { get; set; }

    }
}
