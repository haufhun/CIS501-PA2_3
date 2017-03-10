using System;
using System.Collections.Generic;

namespace Ticker501_MVC.Model.Interfaces
{
    public interface IDatabase
    {
        /// <summary>
        /// This dictionary gets the Database of ticker names and prices and sets it.
        /// </summary>
        Dictionary<string, Tuple<string, string, decimal>> StockDatabase { get; set; }
    }
}
