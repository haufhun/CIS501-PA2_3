using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Class_Library;

namespace Portfolio_GUI
{
    public partial class uxUserInterface : Form
    {

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

        /// <summary>
        /// The instance of the account.
        /// </summary>
        private Account _account;
       // private int _portfolioCount

        /// <summary>
        /// A list of all the portfolio buttons on the tool strip menu.
        /// </summary>
        private List<ToolStripSplitButton> _listOfPortfolioButtons;

        /// <summary>
        /// count of portfolios.
        /// </summary>
        private int _portfolioCount = 0;

        /// <summary>
        /// A string holding the current portoflio selected.
        /// </summary>
        private string _currentPortfolio;

        /// <summary>
        /// Constructor for User interface
        /// </summary>
        /// <param name="a"></param>
        /// <param name="getPNameForm"></param>
        /// <param name="bStkForm"></param>
        /// <param name="sStkForm"></param>
        /// <param name="readFileHandler"></param>
        /// <param name="simulate"></param>
        /// <param name="deletePortfolio"></param>
        /// <param name="addPortfolio"></param>
        /// <param name="sellStocks"></param>
        /// <param name="buyStocks"></param>
        /// <param name="depositFunds"></param>
        /// <param name="withdrawFunds"></param>
        public uxUserInterface(Account a, ReadFileHandler readFileHandler, SimulateHandler simulate,
            DeletePortfolioHandler deletePortfolio, AddPortfolioHandler addPortfolio,
            SellStocksHandler sellStocks, BuyStocksHandler buyStocks, DepositCashHandler depositFunds,
            WithdrawCashHandler withdrawFunds)
        {
            ///Initializing account///
            _account = a;
            _currentPortfolio = null;

            ///Initializing Delegates///
            _readFileHandler = readFileHandler;
            _simulateHandler = simulate;
            _deletePortfolioHandler = deletePortfolio;
            _addPortfolioHandler = addPortfolio;
            _sellStocksHandler = sellStocks;
            _buyStocksHandler = buyStocks;
            _depositCashHandler = depositFunds;
            _withdrawCashHandler = withdrawFunds;


            InitializeComponent();

            ///Makes All Buy Buttons Refrence the same buttonClick
            uxBuyStocks1.Click += BuyStockButton_Click;
            uxBuyStocks2.Click += BuyStockButton_Click;
            uxBuyStocks3.Click += BuyStockButton_Click;
            uxSellStocks1.Click += SellStockButton_Click;
            uxSellStocks2.Click += SellStockButton_Click;
            uxSellStocks3.Click += SellStockButton_Click;

            _listOfPortfolioButtons = new List<ToolStripSplitButton>();
            _listOfPortfolioButtons.Add(uxPortfolio1);
            _listOfPortfolioButtons.Add(uxPortfolio2);
            _listOfPortfolioButtons.Add(uxPortfolio3);


        }

        //Porfolio Button clicks are under this Expanding tab

        /// <summary>
        /// Handles if the user selects portfolio 1 on the portfolio tab.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxPortfolio1_ButtonClick(object sender, EventArgs e)
        {
            uxPortfolioName.Text = uxPortfolio1.Text;
            _currentPortfolio = uxPortfolio1.Text;
            DisplayPortfolio();
        }

        /// <summary>
        /// Hanldes if the user selects portfolio 2 on the portfolio tab.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxPortfolio2_ButtonClick(object sender, EventArgs e)
        {
            uxPortfolioName.Text = uxPortfolio2.Text;
            _currentPortfolio = uxPortfolio2.Text;
            DisplayPortfolio();
        }

        /// <summary>
        /// handles if the user selects portfolio 3 on the portfolio tab.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxPortfolio3_ButtonClick(object sender, EventArgs e)
        {
            uxPortfolioName.Text = uxPortfolio3.Text;
            _currentPortfolio = uxPortfolio3.Text;
            DisplayPortfolio();

        }

        /////////////////////////////////////////////////////////
        /// <summary>
        /// Handles the user clicking the open file button on the home tab.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            else
            {
                MessageBox.Show("No radio button is selected... This is impossible..");
            }
        }

        /// <summary>
        /// Add Portfolio button click displays the GetPortfolio Form and then passes the portfolio name 
        ///    and addPortfolioToToolbar method into AddPortfolio Delegagte
        /// </summary>
        private void uxAddPortfolio_Click(object sender, EventArgs e)
        {
            var getPortfolioNameForm = new uxGetPortfolioNameForm();

            if (getPortfolioNameForm.ShowDialog() == DialogResult.OK)
            {
                _addPortfolioHandler(getPortfolioNameForm.PortfolioName, AddPortfolioToToolStrip);
            }
            if (_account.NumberOfPortfolios >= 3) uxAddPortfolio.Visible = false;
        }

        /// <summary>
        /// Handles the user clicking buy stock button on the portolio tab.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BuyStockButton_Click(object sender, EventArgs e)
        {
            var item = sender as ToolStripMenuItem;
            string portfolioName;
            string clickedButtonsName = item.Name;

            switch (clickedButtonsName)
            {
                case "uxBuyStocks1":
                    portfolioName = uxPortfolio1.Text;
                    break;
                case "uxBuyStocks2":
                    portfolioName = uxPortfolio2.Text;
                    break;
                case "uxBuyStocks3":
                    portfolioName = uxPortfolio3.Text;
                    break;
                default:
                    portfolioName = "Error finding portfolio";
                    break;

            }
            _currentPortfolio = portfolioName;
            uxBuyStocksForm buyStocksForm = new uxBuyStocksForm(portfolioName, _buyStocksHandler, _account);
            buyStocksForm.Show();


        }

        /// <summary>
        /// Handles the user clicking the sell stock button on the portfolio tab.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SellStockButton_Click(object sender, EventArgs e)
        {
            var item = sender as ToolStripMenuItem;
            string portfolioName;
            string clickedButtonsName = item.Name;

            switch (clickedButtonsName)
            {
                case "uxSellStocks1":
                    portfolioName = uxPortfolio1.Text;
                    break;
                case "uxSellStocks2":
                    portfolioName = uxPortfolio2.Text;
                    break;
                case "uxSellStocks3":
                    portfolioName = uxPortfolio3.Text;
                    break;
                default:
                    portfolioName = "Error finding portfolio";
                    break;

            }
            _currentPortfolio = portfolioName;
            var sellStocksForm = new uxSellStockForm(portfolioName, _sellStocksHandler, _account);
            sellStocksForm.Show();
        }

        /// <summary>
        /// Handles the user clicking add funds on the account tab.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxAddFunds_Click(object sender, EventArgs e)
        {
            var addWithdrawFundsForm = new uxAddWithdrawFundsForm(1);

            if (addWithdrawFundsForm.ShowDialog() == DialogResult.OK)
            {
                _depositCashHandler(addWithdrawFundsForm.Amount);
            }
        }

        /// <summary>
        /// Handles the user clicking withdraw funds on the account tab.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxWithdrawFunds_Click(object sender, EventArgs e)
        {
            var addWithdrawFundsForm = new uxAddWithdrawFundsForm(2);

            if (addWithdrawFundsForm.ShowDialog() == DialogResult.OK)
            {
                _withdrawCashHandler(addWithdrawFundsForm.Amount);
            }
        }

        /// <summary>
        /// Disables the suer from being able to open the portfolio tab if they haven't iported a stock database.
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

        /// <summary>
        /// Adds a portfolio to toolstrip and opens the portfolio
        /// </summary>
        /// <param name="portfolioName">Name of portfolio to create and display</param>
        private void AddPortfolioToToolStrip(string portfolioName)
        {
            //var count = 0;
            //foreach (var p in _listOfPortfolioButtons)
            //{
            //    if (p.Visible)
            //    {
            //        count++;
            //    }
            //}
                foreach (var p in _listOfPortfolioButtons)
                {
                    if (!p.Visible)
                    {
                        p.Visible = true;
                        p.Text = portfolioName;
                        _currentPortfolio = portfolioName;
                        DisplayPortfolio();
                        return;
                    }
                }
            //if (count == 2) uxAddPortfolio.Visible = false;

        }

        /// <summary>
        /// Updates all the information on the Home tab.
        /// </summary>
        public void DisplayHomeStockInfo()
        {
            uxHomeListInfo.BeginUpdate();
            uxHomeListInfo.Items.Clear();

            foreach (var i in DataBase.PriceAndTickerName.Values)
            {
                string[] itemInfo = {i.Item1, i.Item2, i.Item3.ToString("C")};
                var item = new ListViewItem(itemInfo);

                uxHomeListInfo.Items.Add(item);
            }

            uxHomeListInfo.EndUpdate();
            DisplayGainsAndLossesPretty(uxHomeGainsLosses, _account.GetGainsAndLossesReport());
        }

        /// <summary>
        /// Updates all the information on the Account tab.
        /// </summary>
        public void DisplayAccount()
        {

            var t = _account.GetAccountBalance();

            uxAccBalOutput.Text = t.Item1.ToString("C");
            uxAccNetWorthOutput.Text = t.Item3.ToString("C");
            uxAccTotalInvestedOutput.Text = t.Item2.ToString("C");
            uxAccNetWorthStocksOutput.Text = _account.GetCashBalance().ToString("C");
            DisplayGainsAndLossesPretty(uxAccGainsLossesOutput, _account.GetGainsAndLossesReport());

            uxAccListInfo.BeginUpdate();
            uxAccListInfo.Items.Clear();

            var list = new List<Tuple<decimal, double, string, string>>();
            _account.GetPositionsBalance(list);
            foreach (var i in list)
            {
                //TickerName    Company Name    Price per share     Shares owned    Networth of shares   position balance
                string[] itemInfo = {i.Item1.ToString("C"), i.Item2.ToString("P"), i.Item3, i.Item4};
                ListViewItem item = new ListViewItem(itemInfo);
                uxAccListInfo.Items.Add(item);
            }

            uxAccListInfo.EndUpdate();
        }

        /// <summary>
        /// Updates all the information on the Portfolio tab.
        /// </summary>
        public void DisplayPortfolio()
        {
            uxPortfolioName.Text = _currentPortfolio;
            var info = _account.GetPortfolioBalance(_currentPortfolio);

            uxPrtBalOutput.Text = _account.CashBalance.ToString("C");
            uxPrtPercentageOfAccountOutput.Text = info.Item3.ToString("P");
            uxPrtTotalInvestedOuput.Text = info.Item2.ToString("C");
            uxPrtNetWorthOutput.Text =
                _account.SelectPortfolio(_currentPortfolio).GetCurrentValueOfAllStocks().ToString("c");

            DisplayGainsAndLossesPretty(uxPrtGainsLossesOutput, _account.SelectPortfolio(_currentPortfolio).GetGainsAndLossesReport());

            var infoList = _account.GetAllPortfolioStockInfoTuple(_currentPortfolio);

            uxPrtListInfo.BeginUpdate();
            uxPrtListInfo.Items.Clear();

            foreach (var i in infoList)
            {
                //  Tickername, companyName, pricePerShare, sharesOwned, networthOfShares, PositionBalance
                string[] itemInfo =
                {
                    i.Item1, i.Item2, i.Item3.ToString("C"), i.Item4.ToString(), i.Item5.ToString("C"),
                    i.Item6.ToString("P")
                };

                uxPrtListInfo.Items.Add(new ListViewItem(itemInfo));
            }

            uxPrtListInfo.EndUpdate();
        }

        /// <summary>
        /// Delete the contents of the whole portfolio, getting the name of the portfolio
        /// from the proper parent.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeletePortfolio(object sender, EventArgs e)
        {
            var parent = (sender as ToolStripMenuItem).OwnerItem;
            var name = parent.Text;
            _account.DeletePortfolio(name);
            parent.Visible = false;
            if (_account.NumberOfPortfolios < 3) uxAddPortfolio.Visible = true;
            _portfolioCount--;
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

        /// <summary>
        /// Exits the program if the user clicks the exit button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxExitProgram_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void DisplayGainsAndLossesPretty(Label l, decimal cash)
        { 
            l.Text = cash.ToString("c");
            if(cash < 0)
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
