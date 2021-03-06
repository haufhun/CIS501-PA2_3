﻿using System;
using System.Windows.Forms;
using Ticker501_MVC.Model;
using Ticker501_MVC.View;

namespace Ticker501_MVC
{
    // defines the type of method that observes model updates
    public delegate void Observer();
    //defines the type of method that handles the portfolio event
    public delegate void PortfolioObserver(string portfolioName);
    //defines the type of method that handles the add portfolio event
    public delegate void AddPortfolioObserver(string portfolioName);
    //defines the type of method that handles the delete portfolio event
    public delegate void DeletePortfolioObserver(string portfolioName);
    //defines the type of method that handles the display error message event
    public delegate void DisplayErrorMessageObserver(string errorMessage);

    public delegate void SelectPortfolioFromWithdraw();
    //defines the type of method that handles the buy stock event
    public delegate void BuyStockObserver();
    //defines the type of method that handles the sell stock event
    public delegate void SellStockObserver();
    //defines the type of method that handles the openform event
    public delegate void OpenForm(Form f, object sender);
    //defines the type of method that handles the portfolio event
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
    public delegate void AddPortfolioHandler(string portfolioName);
    // defines the type of method that handles a delete portfolio input event
    public delegate void DeletePortfolioHandler(string portfolioName);
    // defines the type of method that handles a simulate input event
    public delegate void SimulateHandler(int volatility);
    // defines the type of method that handles a read file input event
    public delegate bool ReadFileHandler(OpenFileDialog openFile);

    /// <summary>
    /// Program class
    /// </summary>
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

            var db = new DataBase();
            var a = new Account(db);
            var c = new Controller(a, db);

            var gpnForm = new GetPortfolioNameForm(c.AddPortfolio);
            var aFundsForm = new AddWithdrawFundsForm(1, c.DepositFunds);
            var wFundsForm =  new AddWithdrawFundsForm(2, c.WithdrawFunds);
            var bSForm = new BuyStocksForm(c.BuyStocks, db, a);
            var sSForm = new SellStocksForm(c.SellStocks, a, db);

            var mForm = new MainForm(a, db, gpnForm, aFundsForm, wFundsForm, bSForm, sSForm, c.OpenForm, c.DisplayPortfolioSelected, c.DeletePortfolio, c.Simulate, c.ReadTickerFile);

            c.PortfoioRegister(mForm.DisplayPortfolio);

            c.Register(mForm.DisplayHomeStockInfo);
            c.Register(mForm.DisplayAccount);
            c.Register(mForm.SetButtonsBasedOnSufficentfunds);
            //c.Register(mForm.SetSellStockButtonBasedOnNumberOfStocks);

            c.ErrorMessageRegister(mForm.DisplayErrorMessage);

            c.AddPortfolioRegister(mForm.AddPortfolioToToolStrip);

            c.DeletePortfolioRegister(mForm.DeletePortfolio);

            c.BuyStockRegister(bSForm.DisplayListView);
            c.SellStockRegister(sSForm.DisplayListView);

            c.RegisterPortfolioFromWithdraw(mForm.SelectPortfolioPage);

            Application.Run(mForm);
        }
    }
}
