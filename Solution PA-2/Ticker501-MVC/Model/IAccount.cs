using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ticker501_MVC.Model
{
    public interface IAccount
    {
        decimal CashBalance { get; set; }

        decimal InvestedBalance { get; set; }
        
        int NumberOfStocks { get; set; }

        Dictionary<string, IPortfolio> Portfolios { get; set; }

        decimal GainsLosses { get; set; }
    }
}
