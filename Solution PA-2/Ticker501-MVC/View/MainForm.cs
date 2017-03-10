using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.Remoting.Channels;
using System.Windows.Forms;
using Ticker501_MVC.Model;
using Ticker501_MVC.Model.Interfaces;

namespace Ticker501_MVC.View
{
    public partial class MainForm : Form
    {
        private PortfolioSelectedHandler _portfolioSelectedHandler;

        private OpenForm _openForm;

        /// <summary>
        /// Defines the type of method that handles a delete portfolio input event
        /// </summary>
        private DeletePortfolioHandler _deletePortfolioHandler;

        /// <summary>
        /// Defines the type of method that handles a simulate input event
        /// </summary>
        private SimulateHandler _simulateHandler;

        /// <summary>
        /// Defines the type of method that handles a read file input event
        /// </summary>
        private ReadFileHandler _readFileHandler;

        /// <summary>
        /// A list of all the portfolio buttons on the tool strip menu.
        /// </summary>
        private List<ToolStripSplitButton> _listOfPortfolioButtons;

        private IAccount _account;
        private IDatabase _database;

        private GetPortfolioNameForm _getPNForm;
        private AddWithdrawFundsForm _addFundsForm;
        private AddWithdrawFundsForm _withdrawFundsForm;
        private BuyStocksForm _bSForm;
        private SellStocksForm _sSForm;

        /// <summary>
        /// Constructor for User interface. Initilazies the model, forms and handlers.
        /// </summary>
        public MainForm(IAccount a, IDatabase db, GetPortfolioNameForm gpnForm, AddWithdrawFundsForm aFundsForm, AddWithdrawFundsForm wFundsForm, BuyStocksForm bSForm, SellStocksForm sSForm, OpenForm openForm, PortfolioSelectedHandler portfolioSelected, DeletePortfolioHandler deletePortfolio, SimulateHandler simulate, ReadFileHandler readTickerFile)
        {
            //Initialize Account and Forms
            _account = a;
            _database = db;
            _getPNForm = gpnForm;
            _addFundsForm = aFundsForm;
            _withdrawFundsForm = wFundsForm;
            _bSForm = bSForm;
            _sSForm = sSForm;

            //Initialize Handlers
            _openForm = openForm;
            _portfolioSelectedHandler = portfolioSelected;
            _deletePortfolioHandler = deletePortfolio;
            _simulateHandler = simulate;
            _readFileHandler = readTickerFile;

            InitializeComponent();

            //Makes All Buy Buttons Refrence the same buttonClick
            uxBuyStocks1.Click += BuyStocksButton_Click;
            uxBuyStocks2.Click += BuyStocksButton_Click;
            uxBuyStocks3.Click += BuyStocksButton_Click;
            //Makes all sell buttons refrene the same buttonClick
            uxSellStocks1.Click += SellStocksButton_Click;
            uxSellStocks2.Click += SellStocksButton_Click;
            uxSellStocks3.Click += SellStocksButton_Click;

            //Adds all portfolio buttons to list
            _listOfPortfolioButtons = new List<ToolStripSplitButton>();
            _listOfPortfolioButtons.Add(uxPortfolio1);
            _listOfPortfolioButtons.Add(uxPortfolio2);
            _listOfPortfolioButtons.Add(uxPortfolio3);
        }
/////////// Click Events inside this collapsed block /////////////////


        /// <summary>
        /// Button click fo Open File button
        /// </summary>
        private void uxOpenTickerFile_Click(object sender, EventArgs e)
        {
            if (_readFileHandler(uxOpenFileDialog))
            {
                uxSimulateStockPrices.Enabled = true;
                uxRadioBttnHigh.Enabled = true;
                uxRadioBttnMedium.Enabled = true;
                uxRadioBttnLow.Enabled = true;
            }
        }

        /// <summary>
        /// Simulate stock prices buttonclick event. Passes a 1 for high, 2 for medium, or a 3 for low volatility 
        ///    into the simulateHandler delegate based on radio button choice.
        /// </summary>
        private void uxSimulateStockPrices_Click(object sender, EventArgs e)
        {
            if (uxRadioBttnHigh.Checked)
            {
                _simulateHandler(1);
            }
            else if (uxRadioBttnMedium.Checked)
            {
                _simulateHandler(2);
            }
            else if (uxRadioBttnLow.Checked)
            {
                _simulateHandler(3);
            }
        }

        /// <summary>
        /// CLick handler for Add funds button
        /// </summary>
        private void uxAddFunds_Click(object sender, EventArgs e)
        {
            _openForm(_addFundsForm, sender);
            
        }

        /// <summary>
        /// Click handler for withdraw funds button
        /// </summary>
        private void uxWithdrawFunds_Click(object sender, EventArgs e)
        {
            _openForm(_withdrawFundsForm, sender);
        }

        /// <summary>
        /// Click handler for Add Portfolio Button
        /// </summary>
        private void uxAddPortfolio_Click(object sender, EventArgs e)
        {
            _openForm(_getPNForm, sender);
        }

        /// <summary>
        /// Handles if the user selects portfolio 1 on the portfolio tab.
        /// </summary>      
        private void uxPortfolio1_ButtonClick(object sender, EventArgs e)
        {
            uxPortfolioName.Text = uxPortfolio1.Text;
            _portfolioSelectedHandler(uxPortfolio1.Text);
        }

        /// <summary>
        /// Hanldes if the user selects portfolio 2 on the portfolio tab.
        /// </summary>
        private void uxPortfolio2_ButtonClick(object sender, EventArgs e)
        {
            uxPortfolioName.Text = uxPortfolio2.Text;
            _portfolioSelectedHandler(uxPortfolio2.Text);
        }

        /// <summary>
        /// handles if the user selects portfolio 3 on the portfolio tab.
        /// </summary>
        private void uxPortfolio3_ButtonClick(object sender, EventArgs e)
        {
            uxPortfolioName.Text = uxPortfolio3.Text;
            _portfolioSelectedHandler(uxPortfolio3.Text);
        }

        /// <summary>
        /// Handles the user pushing the delete portfolio button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxDeletePortfolio_Click(object sender, EventArgs e)
        {
            var parent = (sender as ToolStripMenuItem).OwnerItem;
            var name = parent.Text;
            _deletePortfolioHandler(name);
        }

        /// <summary>
        /// click handler for all buy stocks buttons
        /// </summary>
        private void BuyStocksButton_Click(object sender, EventArgs e)
        {
            _openForm(_bSForm, sender);
        }

        /// <summary>
        /// Click handler for all sell stocks buttons
        /// </summary>
        private void SellStocksButton_Click(object sender, EventArgs e)
        {
            _openForm(_sSForm, sender);
        }

        /// <summary>
        /// Exits the program if the user clicks the exit button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxExitProgram_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        /// <summary>
        /// Disables the ability to click the portfolios button if the database 
        /// has not been opened for the first time.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxTabControl_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPage == uxPortfolioTab && uxSimulateStockPrices.Enabled == false)
            {
                e.Cancel = true;
                MessageBox.Show("Please Open a ticker file first.");
            }
        }
//////////////////////////////////////////////////////////////////////

        /// <summary>
        /// Updates all the information on the Home tab.
        /// </summary>
        public void DisplayHomeStockInfo()
        {
            uxHomeListInfo.BeginUpdate();
            uxHomeListInfo.Items.Clear();

            foreach (var i in _database.StockDatabase.Values)
            {
                string[] itemInfo = { i.Item1, i.Item2, i.Item3.ToString("C") };
                var item = new ListViewItem(itemInfo);

                uxHomeListInfo.Items.Add(item);
            }

            uxHomeListInfo.EndUpdate();
           // DisplayGainsAndLossesPretty(uxHomeGainsLosses, _account.GetGainsAndLossesReport());
        }

        /// <summary>
        /// Updates all the information on the Account tab.
        /// </summary>
        public void DisplayAccount()
        {
            uxAccBalOutput.Text = _account.CashBalance.ToString("C");
            uxPrtBalOutput.Text = _account.CashBalance.ToString("C");
            uxAccNetWorthOutput.Text = (_account.CashBalance + _account.InvestedBalance).ToString("C");
            uxAccTotalInvestedOutput.Text = _account.InvestedBalance.ToString("C");

            var total = 0m;
            foreach (var p in _account.Portfolios.Values)
            {
                foreach (var s in p.Stocks.Values)
                {
                    total += s.NumberOfShares * _database.StockDatabase[s.Name].Item3;
                }
            }

            uxAccNetWorthStocksOutput.Text = total.ToString("C");
            DisplayGainsAndLossesPretty(uxAccGainsLossesOutput, _account.GainsLosses);
            DisplayGainsAndLossesPretty(uxHomeGainsLosses, _account.GainsLosses);

            if(_account.NumberOfStocks > 0)
            {
                uxAccListInfo.BeginUpdate();
                uxAccListInfo.Items.Clear();

                foreach (var p in _account.Portfolios.Values)
                {
                    foreach (var s in p.Stocks.Values)
                    {
                        var fullName = _database.StockDatabase[s.Name].Item2;
                        var price = _database.StockDatabase[s.Name].Item3;
                    
                        //TickerName    Company Name    Price per share     Shares owned    Networth of shares   position balance
                        string[] itemInfo = { s.Name, fullName, price.ToString("C"), s.NumberOfShares.ToString(), (price * s.NumberOfShares).ToString("C"), ((double)s.NumberOfShares / _account.NumberOfStocks).ToString("p") };

                        uxAccListInfo.Items.Add(new ListViewItem(itemInfo));
                    }
                }
                uxAccListInfo.EndUpdate();
            }
        }
        /// <summary>
        /// Updates all the information on the Portfolio tab selected. 
        /// Passing a null indicates to clear the portfolio page.
        /// </summary>
        /// <param name="portfolioName">name of portfolio to display</param>
        public void DisplayPortfolio(string portfolioName)
        {
            if (portfolioName == null)
            {
                ClearPortfolioPage();
            }
            else
            {
                uxPortfolioName.Text = portfolioName;
                UpdateEnabledBuyAndSellStocks(portfolioName);

                var total = 0m;
                foreach (var p in _account.Portfolios.Values)
                {
                    foreach (var s in p.Stocks.Values)
                    {
                        total += s.NumberOfShares * _database.StockDatabase[s.Name].Item3;
                    }
                }

                uxPrtBalOutput.Text = _account.CashBalance.ToString("C");

                if (_account.Portfolios[portfolioName].NumberOfStocks == 0)
                {
                    uxPrtPercentageOfAccountOutput.Text = "0.00%";
                }
                else
                {
                    uxPrtPercentageOfAccountOutput.Text = (((double)_account.Portfolios[portfolioName].NumberOfStocks / _account.NumberOfStocks)).ToString("P");
                }

                uxPrtNetWorthOutput.Text = total.ToString("c");
                uxPrtTotalInvestedOuput.Text = _account.Portfolios[portfolioName].InvestedBalance.ToString("c");
                DisplayGainsAndLossesPretty(uxPrtGainsLossesOutput, _account.Portfolios[portfolioName].GainsLosses);

                uxPrtListInfo.BeginUpdate();
                uxPrtListInfo.Items.Clear();

                foreach (var s in _account.Portfolios[portfolioName].Stocks.Values)
                {
                    //Tickername, companyName, pricePerShare, sharesOwned, networthOfShares, PositionBalance
                    var fullName = _database.StockDatabase[s.Name].Item2;
                    var price = _database.StockDatabase[s.Name].Item3;

                    string[] itemInfo = { s.Name, fullName, price.ToString("C"), s.NumberOfShares.ToString(), (price * s.NumberOfShares).ToString("C"), ((double)s.NumberOfShares / _account.Portfolios[portfolioName].NumberOfStocks).ToString("p") };

                    uxPrtListInfo.Items.Add(new ListViewItem(itemInfo));
                }

                uxPrtListInfo.EndUpdate();
            }
        }

        /// <summary>
        /// Enables and disables the buy and sell stock buttons according to which portfolio they are on
        /// </summary>
        /// <param name="portfolioName">The portfolio that they are currently on</param>
        private void UpdateEnabledBuyAndSellStocks(string portfolioName)
        {
            if (uxPortfolio1.Text == portfolioName)
            {
                uxBuyStocks1.Enabled = _account.CashBalance > 0;
                uxSellStocks1.Enabled = _account.Portfolios[portfolioName].NumberOfStocks > 0;
                uxDeletePortfolio1.Enabled = true;

                uxBuyStocks2.Enabled = false;
                uxSellStocks2.Enabled = false;
                uxDeletePortfolio2.Enabled = false;

                uxBuyStocks3.Enabled = false;
                uxSellStocks3.Enabled = false;
                uxDeletePortfolio3.Enabled = false;
            }
            else if (uxPortfolio2.Text == portfolioName)
            {
                uxBuyStocks1.Enabled = false;
                uxSellStocks1.Enabled = false;
                uxDeletePortfolio1.Enabled = false;

                uxBuyStocks2.Enabled = _account.CashBalance > 0;
                uxSellStocks2.Enabled = _account.Portfolios[portfolioName].NumberOfStocks > 0;
                uxDeletePortfolio2.Enabled = true;

                uxBuyStocks3.Enabled = false;
                uxSellStocks3.Enabled = false;
                uxDeletePortfolio3.Enabled = false;
            }
            else if (uxPortfolio3.Text == portfolioName)
            {
                uxBuyStocks1.Enabled = false;
                uxSellStocks1.Enabled = false;
                uxDeletePortfolio1.Enabled = false;

                uxBuyStocks2.Enabled = false;
                uxSellStocks2.Enabled = false;
                uxDeletePortfolio2.Enabled = false;

                uxBuyStocks3.Enabled = _account.CashBalance > 0;
                uxSellStocks3.Enabled = _account.Portfolios[portfolioName].NumberOfStocks > 0;
                uxDeletePortfolio3.Enabled = true;
            }
            else
            {
                uxBuyStocks1.Enabled = false;
                uxSellStocks1.Enabled = false;
                uxDeletePortfolio1.Enabled = false;

                uxBuyStocks2.Enabled = false;
                uxSellStocks2.Enabled = false;
                uxDeletePortfolio2.Enabled = false;

                uxBuyStocks3.Enabled = false;
                uxSellStocks3.Enabled = false;
                uxDeletePortfolio3.Enabled = false;
            }
        }

        /// <summary>
        /// Adds a portfolio to toolstrip and opens the portfolio
        /// </summary>
        /// <param name="portfolioName">Name of portfolio to create and display</param>
        public void AddPortfolioToToolStrip(string portfolioName)
        {
            foreach (var p in _listOfPortfolioButtons)
            {
                if (!p.Visible)
                {
                    p.Visible = true;
                    p.Text = portfolioName;
                    if (_account.Portfolios.Count > 2)
                    {
                        
                        uxAddPortfolio.Visible = false;
                    }
                    //else if (_account.Portfolios.Count <= 2)
                    //{
                    //    uxAddPortfolio.Visible = true;
                    //}
           //       _currentPortfolio = portfolioName;
           //       DisplayPortfolio();
                    return;
                }
            }
        }

        /// <summary>
        /// Delete the contents of the whole portfolio, getting the name of the portfolio
        /// from the proper parent.
        /// </summary>
        /// <param name="portfolioName">The name of the portfolio.</param>
        public void DeletePortfolio(string portfolioName)
        {
            foreach (var p in _listOfPortfolioButtons)
            {
                if (p.Text == portfolioName)
                {
                    p.Visible = false;
                    if (_account.Portfolios.Count < 3) uxAddPortfolio.Visible = true;
                }
            }
            
        }

        /// <summary>
        /// Clears the entire contents of the page 
        /// </summary>
        private void ClearPortfolioPage()
        {
            uxPrtBalOutput.Text = _account.CashBalance.ToString("c");
            uxPrtPercentageOfAccountOutput.Text = "0.00 %";
            uxPrtTotalInvestedOuput.Text = "$0.00";
            uxPrtNetWorthOutput.Text = "$0.00";
            uxPortfolioName.Text = "Please Select a Portfolio";
            DisplayGainsAndLossesPretty(uxPrtGainsLossesOutput, 0.00m);

            uxPrtListInfo.BeginUpdate();
            uxPrtListInfo.Items.Clear();
            uxPrtListInfo.EndUpdate();
        }

        /// <summary>
        /// Displays an error message to the user with the given string.
        /// </summary>
        /// <param name="message">The message to be displayed to the user in a message box.</param>
        public void DisplayErrorMessage(string message)
        {
            MessageBox.Show(message);
        }

        /// <summary>
        /// Sets if the withdraw funds button and the buy stocks buttons are 
        /// enabled based on if the user has more money than the trade or transfer fee in their account.
        /// </summary>
        public void SetButtonsBasedOnSufficentfunds()
        {
            uxWithdrawFunds.Enabled = _account.CashBalance > Account.TRANSFER_FEE;

            if (_account.CashBalance > Account.TRADE_FEE)
            {
                uxBuyStocks1.Enabled = true;
                uxBuyStocks2.Enabled = true;
                uxBuyStocks3.Enabled = true;
            }
            else
            {
                uxBuyStocks1.Enabled = false;
                uxBuyStocks2.Enabled = false;
                uxBuyStocks3.Enabled = false;
            }
        }

        /// <summary>
        /// Changes the sell stock button to true or false based on if the user has stocks or not.
        /// </summary>
        public void SetSellStockButtonBasedOnNumberOfStocks()
        {
            if (_account.NumberOfStocks > 0)
            {
                uxSellStocks1.Enabled = true;
                uxSellStocks2.Enabled = true;
                uxSellStocks3.Enabled = true;
            }
            else
            {
                uxSellStocks1.Enabled = false;
                uxSellStocks2.Enabled = false;
                uxSellStocks3.Enabled = false;
            }
        }
        
        /// <summary>
        /// Displays the gains and losses in green or red based on if positive or negative
        /// </summary>
        /// <param name="l">The label to be updated.</param>
        /// <param name="cash">The value of the Gains/Losses variable.</param>
        private void DisplayGainsAndLossesPretty(Control l, decimal cash)
        {
            l.Text = cash.ToString("c");
            if (cash < 0)
            {
                l.ForeColor = Color.Red;
            }
            else if (cash > 0)
            {
                l.ForeColor = Color.SeaGreen;
            }
        }
    }
}
