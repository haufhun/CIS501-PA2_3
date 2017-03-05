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
        /// Defines the type of method that handles a deposit cash input event 
        /// </summary>
        private DepositCashHandler _depositCashHandler;

        /// <summary>
        /// Defines the type of method that handles a withdraw cash input event
        /// </summary>
        private WithdrawCashHandler _withdrawCashHandler;

        /// <summary>
        /// Defines the type of method that handles a buy stock input event 
        /// </summary>
        private BuyStocksHandler _buyStocksHandler;

        /// <summary>
        /// Defines the type of method that handles a sell stock input event
        /// </summary>
        private SellStocksHandler _sellStocksHandler;

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
                            OpenForm openForm, PortfolioSelectedHandler portfolioSelected, DepositCashHandler depositFunds, WithdrawCashHandler withdrawFunds, 
                            BuyStocksHandler buyStocks, SellStocksHandler sellStocks, AddPortfolioHandler addPortfolio, DeletePortfolioHandler deletePortfolio, 
                            SimulateHandler simulate, ReadFileHandler readTickerFile)
        {
            //Initialize Account and Forms
            _account = a;
            _getPNForm = GPNForm;
            _addFundsForm = aFundsForm;
            _withdrawFundsForm = wFundsForm;
            _bSForm = bSForm;
            _sSForm = sSForm;

            //Initialize Open Form handlers
            _openForm = openForm;

            //Initialize Handlers
            _portfolioSelectedHandler = portfolioSelected;
            _depositCashHandler = depositFunds;
            _withdrawCashHandler = withdrawFunds;
            _buyStocksHandler = buyStocks;
            _sellStocksHandler = sellStocks;
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
//////////////////////////////////////////////////////////////////////


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

    }
}
