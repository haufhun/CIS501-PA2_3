using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ticker501_MVC.Model.Interfaces;

namespace Ticker501_MVC.Model
{
    /// <summary>
    /// The database class holding all information about current
    /// price of each stock.
    /// </summary>
    public class DataBase : IDatabase
    {
        /// <summary>
        /// Dictionary holding the ticker name as the key and a tuple of ticker name, full name, and value.
        /// </summary>
        public Dictionary<string, Tuple<string, string, decimal>> StockDatabase { get; set; }
        /// <summary>
        /// Constructor initializes Stock Databse Dictionary.
        /// </summary>
        public DataBase()
        {
            StockDatabase = new Dictionary<string, Tuple<string, string, decimal>>();
        }
    }
}
