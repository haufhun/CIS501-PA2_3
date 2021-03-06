﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Class_Library
{
    /// <summary>
    /// The account class. Handles all the methods of the portfolio and the stocks. 
    /// </summary>
    public class Account
    {
        /// <summary>
        /// The trade fee for buying/selling stocks.
        /// </summary>
        public const decimal TRADE_FEE = 9.99m;
        /// <summary>
        /// The transfer fee for depositing/withdrawing money.
        /// </summary>
        public const decimal TRANSFER_FEE = 4.99m;

        /// <summary>
        /// Tracks the initial amount of money put into the account to calculate the gains/losses.
        /// </summary>
        private decimal _initalFunds;
        /// <summary>
        /// The amount of cash in the account.
        /// </summary>
        private decimal _cashFund;
        /// <summary>
        /// The amount invested in stocks in the account.
        /// </summary>
        private decimal _investedBalance;
        /// <summary>
        /// The total number of shares owned in the account.
        /// </summary>
        private int _totalNumberOfShares;
        /// <summary>
        /// The dictionary holding the portfolios, keyed by their name. 
        /// </summary>
        private Dictionary<string, Portfolio> _portfolios;
       

        /// <summary>
        /// Public property allowing get of the cash.
        /// </summary>
        public decimal CashBalance => _cashFund;
        /// <summary>
        /// Public property allowing get of the amount invested.
        /// </summary>
        public decimal InvestedBalance => _investedBalance;
        /// <summary>
        /// Public property for the number of portfolios.
        /// </summary>
        public int NumberOfPortfolios => _portfolios.Count;

        /// <summary>
        /// The total number of shares owned in the account.
        /// </summary>
        public int TotalNumberOfShares => _totalNumberOfShares;

        /// <summary>
        /// Construcotr initializes the portfolios, the initial funds, cash balance, and invested balance.
        /// </summary>
        public Account()
        {
            _portfolios = new Dictionary<string, Portfolio>();
            _totalNumberOfShares = 0;
            _initalFunds = 0;
            _cashFund = 0;
            _investedBalance = 0;
        }

        /// <summary>
        /// Adds money to the cash fund.
        /// </summary>
        /// <param name="cash">The amount wanting to be deposited before the fee.</param>
        public void AddFundsToCashFund(decimal cash)
        {
            if (_initalFunds == 0)
                _initalFunds = cash;
            _cashFund += cash - TRANSFER_FEE;
        }

        /// <summary>
        /// Subtracts money from the cash fund.
        /// </summary>
        /// <param name="cash">THe amount wanting to be withdrawn before the fee.</param>
        public void WithdrawFunds(decimal cash)
        {
            _cashFund -= TRANSFER_FEE;
            _cashFund -= cash;
        }

        /// <summary>
        /// Gets the Account Balance info, such as the cash balacne, the invested 
        /// balance, and the total of the two.
        /// </summary>
        /// <returns>A tuple of the cash, invested, and total.</returns>
        public Tuple<decimal, decimal, decimal> GetAccountBalance()
        {
            return new Tuple<decimal, decimal, decimal>(_cashFund, _investedBalance, _cashFund + _investedBalance);
        }

        /// <summary>
        /// Gets the value of the stocks at current market price.
        /// </summary>
        /// <returns>A decimal value of all the stocks at current market price.</returns>
        public decimal GetCashBalance()
        {
            return _portfolios.Values.Sum(p => p.GetCurrentValueOfAllStocks());
        }

        /// <summary>
        /// Gets the position balance for each stock and puts the info into a string.
        /// </summary>
        /// <param name="list">A list of the positions info, including price, percent, ticker name and full name.</param>
        public void GetPositionsBalance(List<Tuple<decimal, double, string, string>> list)
        {
            foreach (var p in _portfolios.Values)
                p.GetPositionsBalance(list);
        }

        /// <summary>
        /// Gets the gains/losses based on the initial funds deposited into the account.
        /// </summary>
        /// <returns>The value of the account given the cash and the value of all the stocks minus the inital funds.</returns>
        public decimal GetGainsAndLossesReport()
        {
            return (_cashFund + GetCashBalance()) - _initalFunds;
        }

        /// <summary>
        /// Adds a new portfolio to the dictionary.
        /// </summary>
        /// <param name="portfolioName">The name of the dictioanry.</param>
        public void AddPortfolio(string portfolioName)
        {
            if (_portfolios.ContainsKey(portfolioName))
                throw new SamePortfolioNameException();
            _portfolios.Add(portfolioName, new Portfolio());
        }

        /// <summary>
        /// Deletes the current portfolio by selling all the current stocks in it and removing it from the dictionary.
        /// </summary>
        /// <param name="portfolioName">The name of the portfolio.</param>
        public void DeletePortfolio(string portfolioName)
        {
            _cashFund += _portfolios[portfolioName].DeletePortfolio() - TRADE_FEE;
            _totalNumberOfShares -= _portfolios[portfolioName].TotalNumberOfShares;
            _portfolios.Remove(portfolioName);
            UpdateInvestedBalance();
        }

        /// <summary>
        /// Buys a stock and updates the cash fund and invested balance, throws an exception if the 
        /// cost is greater than the cash and the fee.
        /// </summary>
        /// <param name="portfolioName">The name of the portfolio.</param>
        /// <param name="tickerName">The ticker name.</param>
        /// <param name="numberOfShares">The number of shares.</param>
        public void BuyStock(string portfolioName, string tickerName, int numberOfShares)
        {
            var cost = numberOfShares * DataBase.PriceAndTickerName[tickerName].Item3;
            if (cost > _cashFund - TRADE_FEE)
                throw new AccountException();
            _portfolios[portfolioName].AddStock(tickerName, numberOfShares);
            _cashFund -= (TRADE_FEE + cost);
            _totalNumberOfShares += numberOfShares;
            UpdateInvestedBalance();
        }

        /// <summary>
        /// Sells a certain number of stocks, updating the cash fund and the invested balance.
        /// </summary>
        /// <param name="portfolioName">The portfolio name.</param>
        /// <param name="tickerName">The ticker name.</param>
        /// <param name="numberOfStocks">The number of stocks.</param>
        public void SellNumberOfStocks(string portfolioName, string tickerName, int numberOfStocks)
        {
            _portfolios[portfolioName].SellStock(tickerName, numberOfStocks);
            UpdateInvestedBalance();
            _cashFund += numberOfStocks * DataBase.PriceAndTickerName[tickerName].Item3 - TRADE_FEE;
            _totalNumberOfShares -= numberOfStocks;
        }

        /// <summary>
        /// Selects a given portfolio and returns it.
        /// </summary>
        /// <param name="portfolioName">The portfolio name.</param>
        /// <returns>The portfolio.</returns>
        public Portfolio SelectPortfolio(string portfolioName)
        {
            return _portfolios[portfolioName];
        }

        /// <summary>
        /// Gets a list of portfolio names.
        /// </summary>
        /// <returns>A list of portfolio names.</returns>
        public List<string> GetListOfPortfolioNames()
        {
            return _portfolios.Keys.ToList();
        }

        /// <summary>
        /// Updates the invested balance by looking at the balance of each of the portfolios. 
        /// </summary>
        private void UpdateInvestedBalance()
        {
            _investedBalance = 0;
            foreach (var p in _portfolios.Values)
            {
                _investedBalance += p.TotalInvested;
            }
        }

        /// <summary>
        /// Gets the portfolio balance and returns the info as a tuple.
        /// </summary>
        /// <param name="portfolioName">THe name of the portfolio.</param>
        /// <returns>A tuple of the portfolio, invested balance and percent of the total account.</returns>
        public Tuple<string, decimal, decimal> GetPortfolioBalance(string portfolioName)
        {
            var p = _portfolios[portfolioName];
            var total = p.TotalInvested;
            if (_investedBalance == 0)
                return new Tuple<string, decimal, decimal>(portfolioName, 0, 0);
            else
            {
                var percent = p.TotalInvested / _investedBalance;
                return new Tuple<string, decimal, decimal>(portfolioName, total, percent);
            }
        }

        /// <summary>
        /// Checks if there are sufficient funds in the cash.
        /// </summary>
        /// <param name="cash">The amount to be deposited</param>
        /// <returns>True if there is are sufficient funds, otherwise throwing an exception.</returns>
        public bool CheckForSufficientDepositFunds(decimal cash)
        {
            if (_cashFund - TRANSFER_FEE + cash < 0)
                throw new AccountException();
            return true;
        }

        /// <summary>
        /// Checks if there are sufficient funds to withdraw in the cash, otherwise throws an exception.
        /// </summary>
        /// <param name="cash">The amount to be withdrawn.</param>
        /// <returns>True if there are sufficient funds.</returns>
        public bool CheckForSufficientWithdrawlFunds(decimal cash)
        {
            if (cash + TRANSFER_FEE > _cashFund)
                throw new AccountException();
            if (cash > _cashFund + _investedBalance)
                throw new AccountException();
            if (cash > _cashFund)
                throw new AccountException("");
            return true;
        }
        /// <summary>
        /// Gets the position balance for each stock and puts the info into a string.
        /// </summary>
        /// <param name="list">A list of the positions info, including price percent, ticker name and full name.</param>
        public void GetTotalAccountPositionsBalance(List<Tuple<decimal, double, string, string>> list)
        {
            foreach (var p in _portfolios.Values)
            {
                p.GetTotalAccountPositionsBalance(list, _totalNumberOfShares);
            }
        }

        /// <summary>
        /// Gets all information about each stock in a certain portfolio, and returns a list.
        /// </summary>
        /// <param name="portfolioName">The desired portfolio to </param>
        /// <returns>A list of tuples with information about each stock, namely
        /// ticker name, full name, current price per share, shares owned, 
        /// net worth of shares, and the percent of how many shares that stock is in the portfolio.</returns>
        public List<Tuple<string, string, decimal, int, decimal, double>> GetAllPortfolioStockInfoTuple(string portfolioName)
        {
            //TIckername companyName pricePerShare sharesOwned networthOfShares positionBalance
            return _portfolios[portfolioName].GetAllPortfolioStockInfo();
        }
        /// <summary>
        /// This methods holds the tuple to get the stock information.
        /// </summary>
        /// <returns>List of stock info.</returns>
        public List<Tuple<string, string, decimal, int, decimal, double>> GetAllAccountStockInfoTuple()
        {
            //TIckername companyName pricePerShare sharesOwned networthOfShares positionBalance
            var list = new List<Tuple<string, string, decimal, int, decimal, double>>();
            foreach (var p in _portfolios.Values)
            {
                p.GetAllAccountStockInfo(list, _totalNumberOfShares);
            }
            return list;
        }

        /// <summary>
        /// This method gets max shares we are able to buy from dollar amount option.
        /// </summary>
        /// <param name="currentPrice">Current price of the stock.</param>
        /// <returns>An integer is returned with the result.</returns>
        public int GetMaxSharesToBuy(decimal currentPrice)
        {
            return (int)(_cashFund / currentPrice);
        }
    }

    /// <summary>
    /// Exception
    /// </summary>
    public class SamePortfolioNameException : AccountExceptions
    {
    }

    /// <summary>
    /// Account exceptions class, to be used for inheritance of any exceptions that inherit it.
    /// </summary>
    public class AccountExceptions : Exception
    {
        /// <summary>
        /// General account exceptions constructor.
        /// </summary>
        public AccountExceptions() { }
        /// <summary>
        /// Overload account exceptions constructor with a message.
        /// </summary>
        /// <param name="message"></param>
        public AccountExceptions(string message) : base(message) { }
    }

    /// <summary>
    /// An exception class inheriting the account exceptions.
    /// </summary>
    public class AccountException : AccountExceptions
    {
        /// <summary>
        /// General insufficent account balance funds exception constructor.
        /// </summary>
        public AccountException() { }
        /// <summary>
        /// Overload insufficient account balance funds exception with a message.
        /// </summary>
        /// <param name="message"></param>
        public AccountException(string message) : base(message) { }
    }
}