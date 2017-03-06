using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ticker501_MVC.Model
{
    public class IAccount
    {
        public decimal CashBalance { get; set; }

        public decimal InvestedBalance { get; set; }
        
        public int NumberOfStocks { get; set; }

        public Dictionary<string, IPortfolio> Portfolios { get; set; }

        public decimal GainsLosses { get; set; }
    }
}
