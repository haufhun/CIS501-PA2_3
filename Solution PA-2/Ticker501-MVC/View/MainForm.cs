using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ticker501_MVC
{
    public partial class MainForm : Form
    {
        private PortfolioSelectedHandler _portfolioSelectedHandler;

        private OpenForm _openForm;

        /// <summary>
        ///  Defines the type of method that handles a add portfolio input event 
        /// </summary>
        private AddPortfolioHandler _addPortfolioHandler;

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

        private Account _account;

        private GetPortfolioNameForm _getPNForm;
        private AddWithdrawFundsForm _addFundsForm;
        private AddWithdrawFundsForm _withdrawFundsForm;
        private BuyStocksForm _bSForm;
        private SellStocksForm _sSForm;

        /// <summary>
        /// Constructor for User interface. Initilazies the model, forms and handlers.
        /// </summary>
        public MainForm(Account a, GetPortfolioNameForm GPNForm, AddWithdrawFundsForm aFundsForm, AddWithdrawFundsForm wFundsForm, BuyStocksForm bSForm, SellStocksForm sSForm,
                            OpenForm openForm, PortfolioSelectedHandler portfolioSelected, AddPortfolioHandler addPortfolio, DeletePortfolioHandler deletePortfolio, 
                            SimulateHandler simulate, ReadFileHandler readTickerFile)
        {
            //Initialize Account and Forms
            _account = a;
            _getPNForm = GPNForm;
            _addFundsForm = aFundsForm;
            _withdrawFundsForm = wFundsForm;
            _bSForm = bSForm;
            _sSForm = sSForm;

            //Initialize Handlers
            _openForm = openForm;
            _portfolioSelectedHandler = portfolioSelected;
            _addPortfolioHandler = addPortfolio;
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
            _openForm(_addFundsForm);
        }

        /// <summary>
        /// Click handler for withdraw funds button
        /// </summary>
        private void uxWithdrawFunds_Click(object sender, EventArgs e)
        {
            _openForm(_withdrawFundsForm);
        }

        /// <summary>
        /// Click handler for Add Portfolio Button
        /// </summary>
        private void uxAddPortfolio_Click(object sender, EventArgs e)
        {
            _openForm(_getPNForm);
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
        /// click handler for all buy stocks buttons
        /// </summary>
        private void BuyStocksButton_Click(object sender, EventArgs e)
        {
            _openForm(_bSForm);
        }

        /// <summary>
        /// Click handler for all sell stocks buttons
        /// </summary>
        private void SellStocksButton_Click(object sender, EventArgs e)
        {
            _openForm(_sSForm);
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
//////////////////////////////////////////////////////////////////////

        private void uxTabControl_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPage == uxPortfolioTab && uxSimulateStockPrices.Enabled == false)
            {
                e.Cancel = true;
                MessageBox.Show("Please Open a ticker file first.");
            }
        }

        /// <summary>
        /// Updates all the information on the Home tab.
        /// </summary>
        public void DisplayHomeStockInfo()
        {
            uxHomeListInfo.BeginUpdate();
            uxHomeListInfo.Items.Clear();

            //foreach (var i in DataBase.PriceAndTickerName.Values)
            //{
            //    string[] itemInfo = { i.Item1, i.Item2, i.Item3.ToString("C") };
            //    var item = new ListViewItem(itemInfo);

            //    uxHomeListInfo.Items.Add(item);
            //}

            uxHomeListInfo.EndUpdate();
           // DisplayGainsAndLossesPretty(uxHomeGainsLosses, _account.GetGainsAndLossesReport());
        }

        /// <summary>
        /// Updates all the information on the Account tab.
        /// </summary>
        public void DisplayAccount()
        {

            //var t = _account.GetAccountBalance();

            //uxAccBalOutput.Text = t.Item1.ToString("C");
            //uxAccNetWorthOutput.Text = t.Item3.ToString("C");
            //uxAccTotalInvestedOutput.Text = t.Item2.ToString("C");
            //uxAccNetWorthStocksOutput.Text = _account.GetCashBalance().ToString("C");
            //DisplayGainsAndLossesPretty(uxAccGainsLossesOutput, _account.GetGainsAndLossesReport());

            //uxAccListInfo.BeginUpdate();
            //uxAccListInfo.Items.Clear();

            //var list = _account.GetAllAccountStockInfoTuple();

            //foreach (var i in list)
            //{
            //    //TickerName    Company Name    Price per share     Shares owned    Networth of shares   position balance
            //    string[] itemInfo = { i.Item1, i.Item2, i.Item3.ToString("c"), i.Item4.ToString(), i.Item5.ToString("c"), i.Item6.ToString("p") };
            //    ListViewItem item = new ListViewItem(itemInfo);
            //    uxAccListInfo.Items.Add(item);
            //}

            //uxAccListInfo.EndUpdate();
        }

        /// <summary>
        /// Updates all the information on the Portfolio tab selected.
        /// </summary>
        /// <param name="currentPortfolio">name of portfolio to display</param>
        public void DisplayPortfolio(string currentPortfolio)
        {
            uxPortfolioName.Text = currentPortfolio;
            updateEnabledBuyAndSellStocks(currentPortfolio);

            // var info = _account.GetPortfolioBalance(currentPortfolio);

            // uxPrtBalOutput.Text = _account.CashBalance.ToString("C");
            // uxPrtPercentageOfAccountOutput.Text = info.Item3.ToString("P");
            // uxPrtTotalInvestedOuput.Text = info.Item2.ToString("C");
            // uxPrtNetWorthOutput.Text = _account.SelectPortfolio(currentPortfolio).GetCurrentValueOfAllStocks().ToString("c");

            // DisplayGainsAndLossesPretty(uxPrtGainsLossesOutput, _account.SelectPortfolio(currentPortfolio).GetGainsAndLossesReport());

            // var infoList = _account.GetAllPortfolioStockInfoTuple(currentPortfolio);

            uxPrtListInfo.BeginUpdate();
            uxPrtListInfo.Items.Clear();

            // foreach (var i in infoList)
            // {
            //  Tickername, companyName, pricePerShare, sharesOwned, networthOfShares, PositionBalance
            //     string[] itemInfo =
            //     {
            //         i.Item1, i.Item2, i.Item3.ToString("C"), i.Item4.ToString(), i.Item5.ToString("C"),
            //         i.Item6.ToString("P")
            //     };

            //     uxPrtListInfo.Items.Add(new ListViewItem(itemInfo));
            // }

            uxPrtListInfo.EndUpdate();
        }

        /// <summary>
        /// Enables and disables the buy and sell stock buttons according to which portfolio they are on
        /// </summary>
        /// <param name="currentPortfolio">The portfolio that they are currently on</param>
        private void updateEnabledBuyAndSellStocks(string currentPortfolio)
        {
            if (uxPortfolio1.Text == currentPortfolio)
            {
                uxBuyStocks1.Enabled = true;
                uxSellStocks1.Enabled = true;

                uxBuyStocks2.Enabled = false;
                uxSellStocks2.Enabled = false;

                uxBuyStocks3.Enabled = false;
                uxSellStocks3.Enabled = false;
            }
            else if (uxPortfolio2.Text == currentPortfolio)
            {
                uxBuyStocks1.Enabled = false;
                uxSellStocks1.Enabled = false;

                uxBuyStocks2.Enabled = true;
                uxSellStocks2.Enabled = true;

                uxBuyStocks3.Enabled = false;
                uxSellStocks3.Enabled = false;
            }
            else if (uxPortfolio3.Text == currentPortfolio)
            {
                uxBuyStocks1.Enabled = false;
                uxSellStocks1.Enabled = false;

                uxBuyStocks2.Enabled = false;
                uxSellStocks2.Enabled = false;

                uxBuyStocks3.Enabled = true;
                uxSellStocks3.Enabled = true;
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
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeletePortfolio(object sender, EventArgs e)
        {
            //var parent = (sender as ToolStripMenuItem).OwnerItem;
            //var name = parent.Text;
            //_account.DeletePortfolio(name);
            //parent.Visible = false;
            //if (_account.NumberOfPortfolios < 3) uxAddPortfolio.Visible = true;
            //_portfolioCount--;
            //ClearPortfolioPage();
        }

        private void ClearPortfolioPage()
        {
            uxPrtBalOutput.Text = "$0.00";
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
            if (_account.TotalNumberOfShares > 0)
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



        public void DisplayGainsAndLossesPretty(Label l, decimal cash)
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
