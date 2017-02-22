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


        
        private Account _account;
        
        private int _numOfPortolios = 0;
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
        public uxUserInterface(Account a , ReadFileHandler readFileHandler, SimulateHandler simulate, 
                                DeletePortfolioHandler deletePortfolio,  AddPortfolioHandler addPortfolio, 
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

        }

        private void uxAccountTab_Click(object sender, EventArgs e)
        {

        }

        private void uxTotalInvestedOutput_Click(object sender, EventArgs e)
        {

        }

        ///Porfolio Button clicks are under this Expanding tab///
        
        private void uxPortfolio1_ButtonClick(object sender, EventArgs e)
        {
            uxPortfolioName.Text = uxPortfolio1.Text;
            _currentPortfolio = uxPortfolio1.Text;
        }

        private void uxPortfolio2_ButtonClick(object sender, EventArgs e)
        {
            uxPortfolioName.Text = uxPortfolio2.Text;
            _currentPortfolio = uxPortfolio2.Text;
        }

        private void uxPortfolio3_ButtonClick(object sender, EventArgs e)
        {
            uxPortfolioName.Text = uxPortfolio3.Text;
            _currentPortfolio = uxPortfolio3.Text;
        } 
        /////////////////////////////////////////////////////////
        
        private void uxOpenTickerFile_Click(object sender, EventArgs e)
        {
           if( _readFileHandler(uxOpenFileDialog))
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
        }

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
            uxBuyStocksForm buyStocksForm = new uxBuyStocksForm(portfolioName, _buyStocksHandler, _account);
            buyStocksForm.Show();


        }

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
            var sellStocksForm = new uxSellStockForm(portfolioName, _sellStocksHandler, _account);
            sellStocksForm.Show();
        }

        private void uxAddFunds_Click(object sender, EventArgs e)
        {
            var addWithdrawFundsForm = new uxAddWithdrawFundsForm(1);

            if (addWithdrawFundsForm.ShowDialog() == DialogResult.OK)
            {
                _depositCashHandler(addWithdrawFundsForm.Amount);
            }
        }

        private void uxWithdrawFunds_Click(object sender, EventArgs e)
        {
            var addWithdrawFundsForm = new uxAddWithdrawFundsForm(2);

            if (addWithdrawFundsForm.ShowDialog() == DialogResult.OK)
            {
                _withdrawCashHandler(addWithdrawFundsForm.Amount);
            }
        }

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
            _numOfPortolios++;

            switch (_numOfPortolios)
            {
                case 1:                 
                    uxPortfolio1.Visible = true;
                    uxPortfolio1.Text = portfolioName;
                    _currentPortfolio = uxPortfolio1.Text;
                    DisplayPortfolio();     
                    break;
                case 2:
                    uxPortfolio2.Visible = true;
                    uxPortfolio2.Text = portfolioName;
                    _currentPortfolio = uxPortfolio2.Text;
                    DisplayPortfolio();
                    break;
                case 3:
                    uxPortfolio3.Visible = true;            
                    uxAddPortfolio.Visible = false;
                    uxPortfolio3.Text = portfolioName;
                    _currentPortfolio = uxPortfolio3.Text;
                    DisplayPortfolio();
                    break;
                default:
                    MessageBox.Show("Somehow the add portfolio button was visible and you already have the maximum number of portfolios!");
                    _numOfPortolios--;
                    break;
            }

        }

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
        }

        public void DisplayAccount()
        {

            var t = _account.GetAccountBalance();

            uxAccBalOutput.Text = t.Item1.ToString("C");
            uxAccNetWorthOutput.Text = t.Item3.ToString("C");
            uxAccTotalInvestedOutput.Text = t.Item2.ToString("C");
            uxAccNetWorthStocksOutput.Text = _account.GetCashBalance().ToString("C");
            uxAccGainsLossesOutput.Text = _account.GetGainsAndLossesReport().ToString("C");

            uxAccListInfo.BeginUpdate();
            uxAccListInfo.Items.Clear();

            var list = new List<Tuple<decimal, double, string, string>>();
            _account.GetPositionsBalance(list);
            foreach (var i in list)
            {
                //TickerName    Company Name    Price per share     Shares owned    Networth of shares   position balance
                string[] itemInfo = { i.Item1.ToString("C"), i.Item2.ToString("P"), i.Item3, i.Item4 };
                ListViewItem item = new ListViewItem(itemInfo);
                uxAccListInfo.Items.Add(item);
            }

            uxAccListInfo.EndUpdate();
        }

        public void DisplayPortfolio()
        {
            uxPortfolioName.Text = _currentPortfolio;
            var info = _account.GetPortfolioBalance(_currentPortfolio);

            uxPrtBalOutput.Text = _account.CashBalance.ToString("C");
            uxPrtPercentageOfAccountOutput.Text = info.Item3.ToString("P");
            uxPrtTotalInvestedOuput.Text = info.Item2.ToString("C");

            //USe method he created getcurrentvalueofportfolio  //uxPrtNetWorthOutput.Text = _account.ToString("C");//
            // use method getgainsandlossesofportfolio //uxPrtGainsLossesOutput.Text = _account.g.ToString("C");//

            var infoList = _account.GetAllPortfolioStockInfoTuple(_currentPortfolio);

            uxPrtListInfo.BeginUpdate();
            uxPrtListInfo.Items.Clear();

            foreach (var i in infoList)
            {
                //  Tickername, companyName, pricePerShare, sharesOwned, networthOfShares, PositionBalance
                string[] itemInfo = { i.Item1, i.Item2, i.Item3.ToString("C"), i.Item4.ToString(), i.Item5.ToString("C"), i.Item6.ToString("P") };

                uxPrtListInfo.Items.Add(new ListViewItem(itemInfo));
            }

            uxPrtListInfo.EndUpdate();
        }



        public void DisplayErrorMessage(string message)
        {
            MessageBox.Show(message);
        }

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

        private void uxExitProgram_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
