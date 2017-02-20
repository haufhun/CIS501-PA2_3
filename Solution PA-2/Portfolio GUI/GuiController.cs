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
        
        public GuiController(Account a )
        {
            this._account = a;
            _observers = new List<Observer>();
        }

        public void Register(Observer o)
        {
            _observers.Add(o);
        }

        public void DepositFunds(decimal cash)
        {
            //validate cash isn't null
            //validate 

            _account.AddFundsToCashFund(cash);
        }

        public void WithdrawFunds(decimal cash)
        {
            throw new NotImplementedException();
        }

        public void BuyStocks(string portfolioName, string tickerName, int numberOfShares)
        {
            //validate

            _account.BuyStock(portfolioName, tickerName, numberOfShares);
            SignalObservers();
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
            addPrtMethod();
        }


        public void DeletePortfolio(string portfolioName)
        {
            throw new NotImplementedException();
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
        public void ReadTickerFile(OpenFileDialog openFile)
        {
            try
            {
                if (openFile.ShowDialog() == DialogResult.OK)
                {

                    string fileName = openFile.FileName;
                    DataBase.GetInfoFromFile(new StreamReader(fileName));
                    SignalObservers();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

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
        }
    }
}