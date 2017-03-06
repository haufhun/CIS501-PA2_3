using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticker501_MVC.Model
{
    public class IPortfolio
    {
        public decimal InvestedBalance { get; set; }

        public int NumberOfStocks { get; set; }

        public Dictionary<string, IStock> Stocks { get; set; }

    }
}
