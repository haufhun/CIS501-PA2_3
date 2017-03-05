﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ticker501_MVC
{
    // defines the type of method that observes model updates
    public delegate void Observer();
    public delegate void PortfolioObserver(string portfolioName);
    public delegate void AddPortfolioObserver(string portfolioName);
    public delegate void DisplayErrorMessageObserver(string errorMessage);

    public delegate void OpenForm(Form f);

    public delegate void PortfolioSelectedHandler(string portfolioName);
    //defines the type of method that handles a deposit cash input event 
    public delegate void DepositCashHandler(decimal cash);
    // defines the type of method that handles a withdraw cash input event
    public delegate void WithdrawCashHandler(decimal cash);
    // defines the type of method that handles a buy stock input event 
    public delegate void BuyStocksHandler(string portfolioName, string tickerName, int numberOfShares);
    // defines the type of method that handles a sell stock input event
    public delegate void SellStocksHandler(string portfolioName, string tickerName, int numberOfShares);
    // defines the type of method that handles a add portfolio input event 
    public delegate void AddPortfolioHandler(string portfolioName, AddPortfolioObserver addPrtMethod);
    // defines the type of method that handles a delete portfolio input event
    public delegate void DeletePortfolioHandler(string portfolioName);
    // defines the type of method that handles a simulate input event
    public delegate void SimulateHandler(int volatility);
    // defines the type of method that handles a read file input event
    public delegate bool ReadFileHandler(OpenFileDialog openFile);

    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var a = new Account();
            var c = new Controller(a);

            var gpnForm = new GetPortfolioNameForm();
            var aFundsForm = new AddWithdrawFundsForm(1); //pass withdraw and deposit cash handlers
            var wFundsForm =  new AddWithdrawFundsForm(2);
            var bSForm = new BuyStocksForm();// pass buyStocks handler
            var sSForm = new SellStocksForm();// pass SellStocks handler

            var mForm = new MainForm(a, gpnForm, aFundsForm, wFundsForm, bSForm, sSForm,
                                        c.OpenForm, c.DisplayPortfolioSelected, c.DepositFunds, c.WithdrawFunds, 
                                        c.BuyStocks, c.SellStocks, c.AddPortfolio, c.DeletePortfolio, c.Simulate, c.ReadTickerFile);

            c.PortfoioRegister(mForm.DisplayPortfolio);

            Application.Run(mForm);
        }
    }
}
