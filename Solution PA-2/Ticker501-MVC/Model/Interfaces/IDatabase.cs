using System;
using System.Collections.Generic;

namespace Ticker501_MVC.Model.Interfaces
{
    public interface IDatabase
    {
        Dictionary<string, Tuple<string, string, decimal>> StockDatabase { get; set; }
    }
}
