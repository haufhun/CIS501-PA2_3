using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Class_Library;

namespace Portfolio_GUI
{
    internal class GuiController
    {
        private Account _account;
        private List<Observer> _observers;
        private List<PortfolioObserver> _portfolioObservers;
        private DisplayErrorMessageObserver diplayDisplayErrorMessageObserver;

        public GuiController(Account a)
        {
            this._account = a;
            _observers = new List<Observer>();
            _portfolioObservers = new List<PortfolioObserver>();
        }

        public void Register(Observer o)
        {
            _observers.Add(o);
        }

        public void PortfoioRegister(PortfolioObserver o)
        {
            _portfolioObservers.Add(o);
        }

        public void ErrorMessageRegister(DisplayErrorMessageObserver o)
        {
            diplayDisplayErrorMessageObserver = o;
        }

        

        public void DepositFunds(decimal cash)
        {
            //validate cash isn't null
            //validate 

            _account.AddFundsToCashFund(cash);
            SignalObservers();
        }

        public void WithdrawFunds(decimal cash)
        {
            try
            {
                _account.WithdrawFunds(cash);
                SignalObservers();
            }
            catch (InsufficientAccountBalanceFundsException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void BuyStocks(string portfolioName, string tickerName, int numberOfShares)
        {
            try
            {
                _account.BuyStock(portfolioName, tickerName, numberOfShares);
                SignalObservers();
            }
            catch (InsufficientAccountBalanceFundsException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void SellStocks(string portfolioName, string tickerName, int numberOfShares)
        {
            //validate isn't null
            //validate valid portfolioname and tickername
            //validate numberofshares is #
            //validate numberOfShares not too many shares to sell

            _account.SellNumberOfStocks(portfolioName, tickerName, numberOfShares);
            SignalObservers();
        }

        public void AddPortfolio(string portfolioName, AddPortfolioObserver addPrtMethod)
        {
            _account.AddPortfolio(portfolioName);
            addPrtMethod(portfolioName);
            SignalObservers();
        }


        public void DeletePortfolio(string portfolioName)
        {
            _account.DeletePortfolio(portfolioName);
            SignalObservers();
        }

        /// <summary>
        /// Simulates stock market activity, either high, medium or low volatility based on user choice.
        /// </summary>
        public void Simulate(int volatility)
        {
            //show simulator form
            switch (volatility)
            {
                case 1:
                    Simulator.SimulateHighVolatility();
                    break;
                case 2:
                    Simulator.SimulateMediumVolatility();
                    break;
                case 3:
                    Simulator.SimulateLowVolatility();
                    break;
            }
            SignalObservers();
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
                    DataBase.GetInfoFromFile(new StreamReader(fileName));
                    SignalObservers();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;

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
            if (_account.GetListOfPortfolioNames().Count > 0)
            {
                foreach (var prtO in _portfolioObservers)
                {
                    prtO();
                }
            }
        }
    }
}