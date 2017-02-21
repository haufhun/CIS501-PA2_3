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

void MyButtonClick(object sender, EventArgs e)
        {
            Button button = sender as Button;
            //here you can check which button was clicked by the sender
        }
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
        public uxUserInterface(Account a , ReadFileHandler readFileHandler, SimulateHandler simulate, DeletePortfolioHandler deletePortfolio, 
            AddPortfolioHandler addPortfolio, SellStocksHandler sellStocks, BuyStocksHandler buyStocks, DepositCashHandler depositFunds, 
            WithdrawCashHandler withdrawFunds)
        {
            ///Initializing account///
            _account = a;


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
            uxBuyStocks1.Click += Button_Click;
            uxBuyStocks2.Click += Button_Click;
            uxBuyStocks3.Click += Button_Click;

        }

        private void uxAccountTab_Click(object sender, EventArgs e)
        {

        }

        private void uxTotalInvestedOutput_Click(object sender, EventArgs e)
        {

        }

        ///Porfolio Button clicks are under this Expanding tab
        
        private void uxPortfolio1_ButtonClick(object sender, EventArgs e)
        {
            uxPortfolioName.Text = uxPortfolio1.Text;
        }

        private void uxPortfolio2_ButtonClick(object sender, EventArgs e)
        {
            uxPortfolioName.Text = uxPortfolio2.Text;
        }

        private void uxPortfolio3_ButtonClick(object sender, EventArgs e)
        {
            uxPortfolioName.Text = uxPortfolio3.Text;
        }

        
        private void uxOpenTickerFile_Click(object sender, EventArgs e)
        {
            _readFileHandler(uxOpenFileDialog);
            
            uxSimulateStockPrices.Enabled = true;
            uxRadioBttnHigh.Enabled = true;
            uxRadioBttnMedium.Enabled = true;
            uxRadioBttnLow.Enabled = true;
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
            uxGetPortfolioNameForm getPortfolioNameForm = new uxGetPortfolioNameForm();

            if (getPortfolioNameForm.ShowDialog() == DialogResult.OK)
            { 
                _addPortfolioHandler(getPortfolioNameForm.PortfolioName, AddPortfolioToToolStrip);
            }
        }
       

        private void AddPortfolioToToolStrip(string portfolioName)
        {
            _numOfPortolios++;

            switch (_numOfPortolios)
            {
                case 1:                 
                    uxPortfolio1.Visible = true;
                    uxPortfolio1.Text = portfolioName;
                    DisplayPortfolio(portfolioName);     
                    break;
                case 2:
                    uxPortfolio2.Visible = true;
                    uxPortfolio2.Text = portfolioName;
                    DisplayPortfolio(portfolioName);
                    break;
                case 3:
                    uxPortfolio3.Visible = true;            
                    uxAddPortfolio.Visible = false;
                    uxPortfolio3.Text = portfolioName;
                    DisplayPortfolio(portfolioName);
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

        private void DisplayPortfolio(string portfollioName)
        {
            uxPortfolioName.Text = portfollioName;
        }

        public void ShowMyBuyStocksForm()
        {
            //foreach (ListViewItem l in uxHomeListInfo.SelectedItems)
            //{
            //    MessageBox.Show(l.ToString());
            //}
            
            //if()
            //Form2 testDialog = new Form2();

            //// Show testDialog as a modal dialog and determine if DialogResult = OK.
            //if (testDialog.ShowDialog(this) == DialogResult.OK)
            //{
            //    // Read the contents of testDialog's TextBox.
            //    this.txtResult.Text = testDialog.TextBox1.Text;
            //}
            //else
            //{
            //    this.txtResult.Text = "Cancelled";
            //}
            //testDialog.Dispose();
            uxBuyStocksForm buyStocksForm = new uxBuyStocksForm();
            buyStocksForm.Show();
        }

        private void uxBuyStocks1_Click(object sender, EventArgs e)
        {
            
            
        }

        private void Button_Click(object sender, EventArgs e)
        {
            ShowMyBuyStocksForm();
            //string buttonText = ((Button)sender).Text;

            //switch (buttonText)
            //{
       
            //}
    }
}
}
