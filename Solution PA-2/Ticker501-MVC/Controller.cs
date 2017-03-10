using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Ticker501_MVC.Model;
using Ticker501_MVC.Model.Interfaces;
using Ticker501_MVC.View;

namespace Ticker501_MVC
{
    public class Controller
    {
        /// <summary>
        /// The instance of the account.
        /// </summary>
        private readonly IAccount _account;
        /// <summary>
        /// The instance of the database,
        /// </summary>
        private readonly IDatabase _database;
        /// <summary>
        /// The list of observers to call.
        /// </summary>
        private readonly List<Observer> _observers;
        /// <summary>
        /// The list of portolio observers to call.
        /// </summary>
        private PortfolioObserver _portfolioObserver;
        /// <summary>
        /// The toolstrip menu update for the mainm form of portfolios
        /// </summary>
        private AddPortfolioObserver _addPortfolioObserver;
        /// <summary>
        /// Updates the toolstrip menu on a delete method.
        /// </summary>
        private DeletePortfolioObserver _deletePortfolioObserver;
        /// <summary>
        /// Populates all the values in a buy stock form.
        /// </summary>
        private BuyStockObserver _buyStockObserver;
        /// <summary>
        /// Populates all the values in a sell stock form.
        /// </summary>
        private SellStockObserver _sellStockObserver;

        /// <summary>
        /// A error message delegate used to display error messges.
        /// </summary>
        private DisplayErrorMessageObserver _displayErrorMessageObserver;

        /// <summary>
        /// contructs the Controller and initialized the account private field
        /// </summary>
        /// <param name="a">Accoutn object</param>
        /// <param name="db">An instance of the database.</param>
        public Controller(IAccount a, IDatabase db)
        {
            _account = a;
            _database = db;
            _observers = new List<Observer>();
        }

        /// <summary>
        /// Registers an observer to call in order to update fields in the GUI.
        /// </summary>
        /// <param name="o">The delegate of the method to be called that updates the form.</param>
        public void Register(Observer o)
        {
            _observers.Add(o);
        }

        /// <summary>
        /// The portfolio observer that updates the portfolio tab.
        /// </summary>
        /// <param name="o">The delegate that updates the portfolio tab.</param>
        public void PortfoioRegister(PortfolioObserver o)
        {
            _portfolioObserver = o;
        }
        /// <summary>
        /// Register the add portfolio observer on the toolstrip menu for the main form
        /// </summary>
        /// <param name="o"></param>
        public void AddPortfolioRegister(AddPortfolioObserver o)
        {
            _addPortfolioObserver = o;
        }
        /// <summary>
        /// Sets the delete portfolio observer to the method passed into this function.
        /// </summary>
        /// <param name="o">The function that updates the display when delete portfolio is called.</param>
        public void DeletePortfolioRegister(DeletePortfolioObserver o)
        {
            _deletePortfolioObserver = o;
        }

        /// <summary>
        /// Register the display error message method in the user interface to the private field.
        /// </summary>
        /// <param name="o">The error message delegate in the user interface.</param>
        public void ErrorMessageRegister(DisplayErrorMessageObserver o)
        {
            _displayErrorMessageObserver = o;
        }

        /// <summary>
        /// Registers the buy stock observer.
        /// </summary>
        /// <param name="o"></param>
        public void BuyStockRegister(BuyStockObserver o)
        {
            _buyStockObserver = o;
        }

        /// <summary>
        /// Registers the buy stock observer.
        /// </summary>
        /// <param name="o"></param>
        public void SellStockRegister(SellStockObserver o)
        {
            _sellStockObserver = o;
        }


        /// <summary>
        /// Will update the info on the portfolio tab when a new portfolio is selected
        /// </summary>
        public void DisplayPortfolioSelectedObserver(string portfolioName)
        {
            _portfolioObserver(portfolioName);
        }

        /// <summary>
        /// Signals the observers to update fields of the user interface
        /// </summary>
        private void SignalObservers()
        {
            foreach (var o in _observers)
            {
                o();
            }

            //need to check if there is a portfolio created yet
            //_portfolioObserver(_currentPortfolioSelected);

            //if (_account.GetListOfPortfolioNames().Count > 0)
            //{
            //foreach (var portO in _portfolioObservers)
            //{
            //   portO();
            //}
            //}
        }


        /// <summary>
        /// shows the form passed into the argument
        /// </summary>
        /// <param name="form">The Form to open</param>
        /// <param name="sender">The tool strip button that caused this event to fire.</param>
        public void OpenForm(Form form, object sender)
        {
            form.Show();
            if (form.Name.Contains("Buy"))
            {
                _buyStockObserver();
                var parent = (sender as ToolStripMenuItem).OwnerItem;
                var name = parent.Text;
                (form as BuyStocksForm).RegisterPortfolioName(name);
            }
            else if (form.Name.Contains("Sell"))
            {
                var parent = (sender as ToolStripMenuItem).OwnerItem;
                var name = parent.Text;
                (form as SellStocksForm).RegisterPortfolioName(name);
                _sellStockObserver();
            }
        }

        /// <summary>
        /// Deposits funds into the account, catching any exception.
        /// </summary>
        /// <param name="cash">The amount of cash to deposit.</param>
        public void DepositFunds(decimal cash)
        {
            var toAdd = cash - Account.TRANSFER_FEE;
            if (toAdd > 0)
            {
                _account.CashBalance += toAdd;
                SignalObservers();
            }
            else
            {
                _displayErrorMessageObserver("The amount you want to deposit is less than the deposit fee of $4.99. Please enter another number.");
            }
        }

        /// <summary>
        /// Withdraws funds from the account, catching any exception.
        /// </summary>
        /// <param name="cash">The amount of cash to withdraw.</param>
        public void WithdrawFunds(decimal cash)
        {
            var toWithdraw = cash + Account.TRANSFER_FEE;
            if ( toWithdraw < _account.CashBalance)
            {
                _account.CashBalance -= toWithdraw;
                SignalObservers();
            }
            else
            {
                _displayErrorMessageObserver("You don't have enough money in your account. Please enter a different number.");
            }
        }

        /// <summary>
        /// Buys stocks of a given portfolio name and ticker name and number of shares.
        /// </summary>
        /// <param name="portfolioName">The portfolio name.</param>
        /// <param name="tickerName">The ticker name.</param>
        /// <param name="numberOfShares">The number of shares.</param>
        public void BuyStocks(string portfolioName, string tickerName, int numberOfShares)
        {
            try
            {
                Tuple<string, string, decimal> valueFromDatabase;
                IStock stock = new Stock(tickerName);
                    if (_database.StockDatabase.TryGetValue(tickerName, out valueFromDatabase))
                    {
                            var cost = numberOfShares*valueFromDatabase.Item3;
                            if (cost <= (_account.CashBalance - Account.TRADE_FEE))
                            {
                                if (_account.Portfolios[portfolioName].Stocks.ContainsKey(tickerName))
                                {
                                    _account.Portfolios[portfolioName].Stocks[tickerName].NumberOfShares += numberOfShares;
                                }
                                else
                                {
                                    _account.Portfolios[portfolioName].Stocks.Add(tickerName, stock);
                                    _account.Portfolios[portfolioName].Stocks[tickerName].NumberOfShares += numberOfShares;
                                }                               
                                stock.InvestedBalance += cost;
                                _account.Portfolios[portfolioName].InvestedBalance += cost;
                                _account.Portfolios[portfolioName].NumberOfStocks+= numberOfShares;
                                _account.CashBalance -= (cost + Account.TRADE_FEE);
                                _account.InvestedBalance += stock.InvestedBalance;
                                _account.NumberOfStocks += numberOfShares;
                                SignalObservers();
                                _portfolioObserver(portfolioName);
                            }
                            else
                            {
                                _displayErrorMessageObserver(
                                    "You currently do not have enought funds to perform this action");
                            }
                    }
            }
            catch (Exception)
            {
                _displayErrorMessageObserver("Error trying to buy stocks.");
            }
        }

        /// <summary>
        /// Sells stocks given a portfolio name, ticker name, and number of stocks.
        /// </summary>
        /// <param name="portfolioName">The portfolio name.</param>
        /// <param name="tickerName">The ticker name.</param>
        /// <param name="numberOfShares">The number of shares.</param>
        public void SellStocks(string portfolioName, string tickerName, int numberOfShares)
        {

            try
            {
                Tuple<string, string, decimal> valueFromDatabase;
                IStock stock = new Stock(tickerName);
                    if (_database.StockDatabase.TryGetValue(tickerName, out valueFromDatabase))
                    {
                            var cost = numberOfShares*valueFromDatabase.Item3;
                            if (cost <= (_account.CashBalance - Account.TRADE_FEE))
                            {
                                if(_account.Portfolios[portfolioName].Stocks.ContainsKey(tickerName))
                                {
                                    _account.Portfolios[portfolioName].Stocks[tickerName].NumberOfShares -=  numberOfShares;
                                }
                                else
                                {
                                    _account.Portfolios[portfolioName].Stocks.Add(tickerName, stock);
                                    _account.Portfolios[portfolioName].Stocks[tickerName].NumberOfShares -= numberOfShares;
                                }
                                stock.InvestedBalance -= cost;
                                _account.Portfolios[portfolioName].InvestedBalance -= cost;
                                _account.Portfolios[portfolioName].NumberOfStocks--;
                                _account.CashBalance += (cost - Account.TRADE_FEE);
                                _account.InvestedBalance -= stock.InvestedBalance;
                                _account.NumberOfStocks -= numberOfShares;
                                SignalObservers();
                                _portfolioObserver(portfolioName);
                                if (stock.NumberOfShares == 0)
                                {
                                    _account.Portfolios[portfolioName].Stocks.Remove(tickerName);
                                }
                            }
                    }
            }
            catch (Exception)
            {
                _displayErrorMessageObserver("Error trying to sell stocks.");
            }
        }

        /// <summary>
        /// Adds a new portfolio given a portfolio name, and an observer to update the toolstrip menu.
        /// </summary>
        /// <param name="portfolioName">The portfolio name.</param>
        public void AddPortfolio(string portfolioName)
        {
            if (_account.Portfolios.ContainsKey(portfolioName))
            {
                _displayErrorMessageObserver("You already have a portfolio named \"" + portfolioName + "\".");
            }
            else
            {
                _account.Portfolios.Add(portfolioName, new Portfolio());
                _addPortfolioObserver(portfolioName);
                _portfolioObserver(portfolioName);
            }
        }

        /// <summary>
        /// Deletes the portfolio, catching any account exception or regular exception that may be needed.
        /// </summary>
        /// <param name="portfolioName">The name of the portfolio.</param>
        public void DeletePortfolio(string portfolioName)
        {
            foreach (var s in _account.Portfolios[portfolioName].Stocks.Values)
            {
                var currentValue = _database.StockDatabase[s.Name].Item3;

                _account.CashBalance += s.NumberOfShares * currentValue;
                _account.InvestedBalance -= s.NumberOfShares * currentValue;
            }

            _account.Portfolios.Remove(portfolioName);

            _deletePortfolioObserver(portfolioName);
            _portfolioObserver(null);
            SignalObservers();
        }

        /// <summary>
        /// Simulates stock market activity, either high, medium or low volatility based on user choice.
        /// </summary>
        public void Simulate(int volatility)
        {
            var d = new Dictionary<string, Tuple<string, string, decimal>>();
            var r = new Random();
            decimal change;
            decimal sign;
            switch(volatility)
            {
                case 1:
                    {
                        foreach (
                            var t in _database.StockDatabase.Values)
                        {
                            sign = r.Next(2);
                            if (sign == 0)
                            {
                                sign = -1;
                            }
                            else
                            {
                                sign = 1;
                            }
                            change = ((Convert.ToDecimal(r.Next(13)) + Convert.ToDecimal(3)) / Convert.ToDecimal(100))*sign;
                            decimal newAmount = t.Item3 + t.Item3 * change;
                            Tuple<string, string, decimal> x = new Tuple<string, string, decimal>(t.Item1, t.Item2, newAmount);
                            d.Add(t.Item1, x);
                        }
                        break;
                    }
                case 2:
                    {
                        foreach (Tuple<string, string, decimal> t in _database.StockDatabase.Values)
                        {
                            sign = r.Next(2);
                            if (sign == 0)
                            {
                                sign = -1;
                            }
                            else
                            {
                                sign = 1;
                            }
                            change = ((Convert.ToDecimal(r.Next(7)) + Convert.ToDecimal(2)) / Convert.ToDecimal(100)) * sign;
                            decimal newAmount = t.Item3 + t.Item3 * change;
                            Tuple<string, string, decimal> x = new Tuple<string, string, decimal>(t.Item1, t.Item2, newAmount);
                            d.Add(t.Item1, x);
                        }
                        
                        break;
                    }
                case 3:
                    {
                        
                        foreach (Tuple<string, string, decimal> t in _database.StockDatabase.Values)
                        {
                            change = ((r.Next(4) + 1) / 100);
                            sign = r.Next(2);
                            if(sign==0)
                            {
                                sign = -1;
                            }
                            else
                            {
                                sign = 1;
                            }
                            change = ((Convert.ToDecimal(r.Next(4)) + Convert.ToDecimal(1)) / Convert.ToDecimal(100)) * sign;
                            decimal newAmount = t.Item3 + t.Item3 * change;
                            Tuple<string, string, decimal> x = new Tuple<string, string, decimal>(t.Item1, t.Item2, newAmount);
                            d.Add(t.Item1, x);
                        }
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
            _database.StockDatabase = d;
            SignalObservers();
        }

        /// <summary>
        /// Reads the ticker information from a file.
        /// </summary>
        /// <param name="openFile"> An instance of the open dialog to get the file from.</param>
        public bool ReadTickerFile(OpenFileDialog openFile)
        {
            try
            {
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    var fileName = openFile.FileName;
                    using (var input = new StreamReader(fileName))
                    {
                        while (!input.EndOfStream)
                        {
                            var inputLine = input.ReadLine();
                            string[] split = null;
                            if (inputLine != null && !(inputLine.Trim().Length <= 5))
                            {
                                split = inputLine.Split('-');
                                split[0] = split[0].Trim().ToUpper();
                                split[2] = split[2].Substring(1);
                            }

                            if (split != null)
                            {
                                if(!_database.StockDatabase.ContainsKey(split[0]))
                                    _database.StockDatabase.Add(split[0], new Tuple<string, string, decimal>(split[0], split[1], Convert.ToDecimal(split[2])));
                                else
                                {
                                    _database.StockDatabase[split[0]] = new Tuple<string, string, decimal>(split[0],
                                        split[1], Convert.ToDecimal(split[2]));
                                }
                            }
                        }
                    }
                    SignalObservers();
                    return true;
                }
            }
            catch (Exception)
            {
                _displayErrorMessageObserver("Error when reading file. Please try again.");
            }
            return false;
        }

        
    }
}
