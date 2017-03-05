using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ticker501_MVC
{
    public class Controller
    {
        /// <summary>
        /// The instance of the account.
        /// </summary>
        private Account _account;
        /// <summary>
        /// The list of observers to call.
        /// </summary>
        private List<Observer> _observers;

        /// <summary>
        /// The list of portolio observers to call.
        /// </summary>
        private List<PortfolioObserver> _portfolioObservers;

        /// <summary>
        /// A error message delegate used to display error messges.
        /// </summary>
        private DisplayErrorMessageObserver displayErrorMessageObserver;


        public Controller()
        {
            
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
            _portfolioObservers.Add(o);
        }
        /// <summary>
        /// Register the display error message method in the user interface to the private field.
        /// </summary>
        /// <param name="o">The error message delegate in the user interface.</param>
        public void ErrorMessageRegister(DisplayErrorMessageObserver o)
        {
            displayErrorMessageObserver = o;
        }

        /// <summary>
        /// Will update the info on the portfolio tab when a new portfolio is selected
        /// </summary>
        public void DisplayPortfolioSelected(string portfolioName)
        {
            foreach (var portO in _portfolioObservers)
            {
                portO();
            }
        }

        /// <summary>
        /// Deposits funds into the account, catching any exception.
        /// </summary>
        /// <param name="cash">The amount of cash to deposit.</param>
        public void DepositFunds(decimal cash)
        {
            //try
            //{
            //    _account.AddFundsToCashFund(cash);
            //    SignalObservers();
            //}
            //catch (AccountException)
            //{
            //    displayErrorMessageObserver("There was a problem depositing money into your account.");
            //}
            //catch (Exception)
            //{
            //    displayErrorMessageObserver("Error trying to deposit funds.");
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
            //    displayErrorMessageObserver("You currently do not have enough funds to perform this action.");
            //}
            //catch (Exception)
            //{
            //    displayErrorMessageObserver("Error trying to withdraw funds.");
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
            //    displayErrorMessageObserver("You currently do not have enought funds to perform this action");
            //}
            //catch (Exception)
            //{
            //    displayErrorMessageObserver("Error trying to buy stocks.");
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
            //    displayErrorMessageObserver("Insufficient funds in your account.");
            //}
            //catch (Exception)
            //{
            //    displayErrorMessageObserver("Error trying to sell stocks.");
            //}
        }
        /// <summary>
        /// Adds a new portfolio given a portfolio name, and an observer to update the toolstrip menu.
        /// </summary>
        /// <param name="portfolioName">The portfolio name.</param>
        /// <param name="addPrtMethod">The update tool strip menu delegate.</param>
        public void AddPortfolio(string portfolioName, AddPortfolioObserver addPrtMethod)
        {
                        //try
            //{
            //    _account.AddPortfolio(portfolioName);
            //    addPrtMethod(portfolioName);
            //    SignalObservers();
            //}
            //catch (SamePortfolioNameException)
            //{
            //    displayErrorMessageObserver("You already have a portfolio named \"" + portfolioName + "\".");
            //}
            //catch (Exception)
            //{
            //    displayErrorMessageObserver("There was a problem trying to add a portfolio.");
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
            //    displayErrorMessageObserver(
            //        "Error in the account with funds when trying to process delete portfolio request.");
            //}
            //catch (Exception)
            //{
            //    displayErrorMessageObserver("Error when trying to delete portfolio " + portfolioName + ".");
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
            //    displayErrorMessageObserver("Error when trying to run the simluator");
            //}
        }
        /// <summary>
        /// Reads the ticker information from a file.
        /// </summary>
        /// <param name="fileName"> The file to read</param>
        public bool ReadTickerFile(OpenFileDialog openFile)
        {
                        //try
            //{
            //    if (openFile.ShowDialog() == DialogResult.OK)
            //    {

            //        string fileName = openFile.FileName;
            //        DataBase.GetInfoFromFile(new StreamReader(fileName));
            //        SignalObservers();
            //        return true;
            //    }
            //}
            //catch (Exception)
            //{
            //    displayErrorMessageObserver("Error when reading file. Please try again.");
            //}
            //return false;
            throw new NotImplementedException();
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
            //if (_account.GetListOfPortfolioNames().Count > 0)
            //{
               foreach (var portO in _portfolioObservers)
               {
                  portO();
               }
            //}
        }
    }
}
