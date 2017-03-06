using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticker501_MVC.Model
{
    public interface IPortfolio
    {
       decimal InvestedBalance { get; set; }

       int NumberOfStocks { get; set; }
        
       Dictionary<string, IStock> Stocks { get; set; }

    }
}
