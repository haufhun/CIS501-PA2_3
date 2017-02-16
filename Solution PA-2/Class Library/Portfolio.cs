﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Class_Library
{
    /// <summary>
    /// Contains data about a portolio.
    /// </summary>
    public class Portfolio
    {
        /// <summary>
        /// A dictionary of all the stocks that the portfolio contains.
        /// </summary>
        private readonly Dictionary<string, Stock> _stocks;
        /// <summary>
        /// The total investment put into this portfolio.
        /// </summary>
        private decimal _totalInvested;
        /// <summary>
        /// The total number of shares in the portfolio.
        /// </summary>
        private int _totalNumberOfShares;
        /// <summary>
        /// A public property allowing get functinality of total invested.
        /// </summary>
        public decimal TotalInvested => _totalInvested;

        /// <summary>
        /// COnstructor initializes the stocks dictionary, total invested, and total number of shares.
        /// </summary>
        public Portfolio()
        {
            _stocks = new Dictionary<string, Stock>();
            _totalInvested = 0;
            _totalNumberOfShares = 0;
        }
        /// <summary>
        /// Adds a stock to a portfolio.
        /// </summary>
        /// <param name="tickerName">The ticker name.</param>
        /// <param name="numberOfShares">THe number of shares.</param>
        public void AddStock(string tickerName, int numberOfShares)
        {
            var buyPrice = DataBase.PriceAndTickerName[tickerName].Item3;
            if (!_stocks.ContainsKey(tickerName))
            {
                _stocks.Add(tickerName, new Stock(tickerName, buyPrice, numberOfShares));
            }
            else
            {
                _stocks[tickerName].AddMoreShares(buyPrice, numberOfShares);
            }
            _totalNumberOfShares += numberOfShares;
            _totalInvested += buyPrice * numberOfShares;
        }
        /// <summary>
        /// Deletes a portfolio, which sells all of the stocks held within the portfolio.
        /// </summary>
        /// <returns>The total value of selling all the shares.</returns>
        public decimal DeletePortfolio()
        {
            var total = _stocks.Values.Sum(s => s.SellNumberOfShares(s.TotalNumberOfShares));
            _stocks.Clear();
            return total;
        }
        /// <summary>
        /// Gets the gains/losses report for the portfolio.
        /// </summary>
        /// <returns>The gains/losses value.</returns>
        public decimal GetGainsAndLossesReport()
        {
            return GetCurrentValueOfAllStocks() - _totalInvested;
        }
        /// <summary>
        /// Sells a stock given a name and number of shares.
        /// </summary>
        /// <param name="tickerName">The name of the stock.</param>
        /// <param name="numberOfShares">The number of shares.</param>
        /// <returns></returns>
        public decimal SellStock(string tickerName, int numberOfShares)
        {
            var totalPrice = _stocks[tickerName].SellNumberOfShares(numberOfShares);
            _totalNumberOfShares -= numberOfShares;
            _totalInvested -= totalPrice;
            _stocks.Remove(tickerName);
            return totalPrice;
        }
        /// <summary>
        /// Gets the current value of all the shares inside this portfolio.
        /// </summary>
        /// <returns>The total value of all shares at current market price.</returns>
        public decimal GetCurrentValueOfAllStocks()
        {
            return _stocks.Values.Sum(s => s.GetCurrentMarketValue());
        }
        /// <summary>
        /// Gets the postions balance of this portfolio.
        /// </summary>
        /// <param name="list">A list of positions info, such as value of each stock, the percent of each stock, the ticker name and full name.</param>
        public void GetPositionsBalance(List<Tuple<decimal, double, string, string>> list)
        {
            foreach (var s in _stocks.Values)
            {
                decimal d = s.GetCurrentMarketValue();
                double i = s.TotalNumberOfShares;
                string ticker = s.TickerName;
                string name = DataBase.PriceAndTickerName[ticker].Item2;
                list.Add(new Tuple<decimal, double, string, string>(d, i / _totalNumberOfShares, ticker, name));
            }
        }
        /// <summary>
        /// Returns whether a stock is already contained in this portfolio or not. 
        /// </summary>
        /// <param name="tickerName">The ticker name.</param>
        /// <returns>Whether or not the stock exists inside the portfolio or not.</returns>
        public bool ContainsStock(string tickerName)
        {
            return _stocks.ContainsKey(tickerName);
        }
    }
}