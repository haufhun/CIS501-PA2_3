using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ticker501_MVC.Model.Interfaces;

namespace Ticker501_MVC
{
    public class Controller
    {
        /// <summary>
        /// The instance of the account.
        /// </summary>
        private IAccount _account;
        /// <summary>
        /// The list of observers to call.
        /// </summary>
        private List<Observer> _observers;
        /// <summary>
        /// The list of portolio observers to call.
        /// </summary>
        private PortfolioObserver _portfolioObserver;

        //private List<AddPortfolioObserver> _addPortfolioObserver;

        /// <summary>
        /// A error message delegate used to display error messges.
        /// </summary>
        private DisplayErrorMessageObserver _displayErrorMessageObserver;

        /// <summary>
        /// Current Portfoilo selected on the gui
        /// </summary>
        private string _currentPortfolioSelected;

        /// <summary>
        /// contructs the Controller and initialized the account private field
        /// </summary>
        /// <param name="a">Accoutn object</param>
        public Controller(IAccount a)
        {
            _account = a;
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

        //public void AddPortfolioRegister(AddPortfolioObserver o)
        //{
        //    _addPortfolioObserver.Add(o);
        //}

        /// <summary>
        /// Register the display error message method in the user interface to the private field.
        /// </summary>
        /// <param name="o">The error message delegate in the user interface.</param>
        public void ErrorMessageRegister(DisplayErrorMessageObserver o)
        {
            _displayErrorMessageObserver = o;
        }


        /// <summary>
        /// Will update the info on the portfolio tab when a new portfolio is selected
        /// </summary>
        public void DisplayPortfolioSelectedObserver(string portfolioName)
        {
            _currentPortfolioSelected = portfolioName;

            _portfolioObserver(portfolioName);
        }

        //private void SignalAddPortfolioObservers(string portfolioName)
        //{
        //    foreach (var o in _addPortfolioObserver)
        //    {
        //        o(portfolioName);
        //    }
        //}

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
            _portfolioObserver(_currentPortfolioSelected);

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
        public void OpenForm(Form form)
        {
            form.Show();
        }

        /// <summary>
        /// Deposits funds into the account, catching any exception.
        /// </summary>
        /// <param name="cash">The amount of cash to deposit.</param>
        public void DepositFunds(decimal cash)
        {
           // if (aWfundsForm.ShowDialog() == DialogResult.OK)
          //  {
            //   aWfundsForm.Amount;
           // }
            //try
            //{
            //    _account.AddFundsToCashFund(cash);
            //    SignalObservers();
            //}
            //catch (AccountException)
            //{
            //    _displayErrorMessageObserver("There was a problem depositing money into your account.");
            //}
            //catch (Exception)
            //{
            //    _displayErrorMessageObserver("Error trying to deposit funds.");
            //}
        }

        /// <summary>
        /// Withdraws funds from the account, catching any exception.
        /// </summary>
        /// <param name="cash">The amount of cash to withdraw.</param>
        public void WithdrawFunds(decimal cash)
        {
                        //try
            //{
            //    _account.WithdrawFunds(cash);
            //    SignalObservers();
            //}
            //catch (AccountExceptions)
            //{
            //    _displayErrorMessageObserver("You currently do not have enough funds to perform this action.");
            //}
            //catch (Exception)
            //{
            //    _displayErrorMessageObserver("Error trying to withdraw funds.");
            //}
        }

        /// <summary>
        /// Buys stocks of a given portfolio name and ticker name and number of shares.
        /// </summary>
        /// <param name="portfolioName">The portfolio name.</param>
        /// <param name="tickerName">The ticker name.</param>
        /// <param name="numberOfShares">The number of shares.</param>
        public void BuyStocks(string portfolioName, string tickerName, int numberOfShares)
        {
           //try
            //{
            //    _account.BuyStock(portfolioName, tickerName, numberOfShares);
            //    SignalObservers();
            //}
            //catch (AccountExceptions)
            //{
            //    _displayErrorMessageObserver("You currently do not have enought funds to perform this action");
            //}
            //catch (Exception)
            //{
            //    _displayErrorMessageObserver("Error trying to buy stocks.");
            //}
        }

        /// <summary>
        /// Sells stocks given a portfolio name, ticker name, and number of stocks.
        /// </summary>
        /// <param name="portfolioName">The portfolio name.</param>
        /// <param name="tickerName">The ticker name.</param>
        /// <param name="numberOfShares">The number of shares.</param>
        public void SellStocks(string portfolioName, string tickerName, int numberOfShares)
        {
                        //try
            //{
            //    _account.SellNumberOfStocks(portfolioName, tickerName, numberOfShares);
            //    SignalObservers();
            //}
            //catch (AccountException)
            //{
            //    _displayErrorMessageObserver("Insufficient funds in your account.");
            //}
            //catch (Exception)
            //{
            //    _displayErrorMessageObserver("Error trying to sell stocks.");
            //}
        }

        /// <summary>
        /// Adds a new portfolio given a portfolio name, and an observer to update the toolstrip menu.
        /// </summary>
        /// <param name="portfolioName">The portfolio name.</param>
        /// <param name="addPrtMethod">The update tool strip menu delegate.</param>
        public void AddPortfolio(string portfolioName)
        {
            _currentPortfolioSelected = portfolioName;
            SignalObservers();
            //try
            //{
            //    _account.AddPortfolio(portfolioName);
            //    addPrtMethod(portfolioName);
            //    SignalObservers();
            //}
            //catch (SamePortfolioNameException)
            //{
            //    _displayErrorMessageObserver("You already have a portfolio named \"" + portfolioName + "\".");
            //}
            //catch (Exception)
            //{
            //    _displayErrorMessageObserver("There was a problem trying to add a portfolio.");
            //}
        }



        /// <summary>
        /// Deletes the portfolio, catching any account exception or regular exception that may be needed.
        /// </summary>
        /// <param name="portfolioName">The name of the portfolio.</param>
        public void DeletePortfolio(string portfolioName)
        {
                         //try
            //{
            //    _account.DeletePortfolio(portfolioName);
            //    SignalObservers();
            //}
            //catch (AccountException)
            //{
            //    _displayErrorMessageObserver(
            //        "Error in the account with funds when trying to process delete portfolio request.");
            //}
            //catch (Exception)
            //{
            //    _displayErrorMessageObserver("Error when trying to delete portfolio " + portfolioName + ".");
            //}
        }

        /// <summary>
        /// Simulates stock market activity, either high, medium or low volatility based on user choice.
        /// </summary>
        public void Simulate(int volatility)
        {
                        //try
            //{
            //    switch (volatility)
            //    {
            //        case 1:
            //            Simulator.SimulateHighVolatility();
            //            break;
            //        case 2:
            //            Simulator.SimulateMediumVolatility();
            //            break;
            //        case 3:
            //            Simulator.SimulateLowVolatility();
            //            break;
            //    }
            //    SignalObservers();
            //}
            //catch (Exception)
            //{
            //    _displayErrorMessageObserver("Error when trying to run the simluator");
            //}
        }

        /// <summary>
        /// Reads the ticker information from a file.
        /// </summary>
        /// <param name="fileName"> The file to read</param>
        public bool ReadTickerFile(OpenFileDialog openFile)
        {
            try
            {
                if (openFile.ShowDialog() == DialogResult.OK)
                {

                    string fileName = openFile.FileName;
                   // DataBase.GetInfoFromFile(new StreamReader(fileName));
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
