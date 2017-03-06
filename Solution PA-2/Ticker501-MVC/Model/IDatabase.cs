using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticker501_MVC.Model
{
    public interface IDatabase
    {
        Dictionary<string, Tuple<string, string, decimal>> StockDatabase { get; set; }
    }
}
