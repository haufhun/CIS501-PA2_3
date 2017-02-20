﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Class_Library;

namespace Portfolio_GUI
{
    public partial class uxUserInterface : Form
    {
        //defines the type of method that handles a deposit cash input event 
        private DepositCashHandler _depositCashHandler;
        // defines the type of method that handles a withdraw cash input event
        private WithdrawCashHandler _withdrawCashHandler;
        // defines the type of method that handles a buy stock input event 
        private BuyStocksHandler _buyStocksHandler;
        // defines the type of method that handles a sell stock input event
        private SellStocksHandler _sellStocksHandler;
        // defines the type of method that handles a add portfolio input event 
        private AddPortfolioHandler _addPortfolioHandler;
        // defines the type of method that handles a delete portfolio input event
        private DeletePortfolioHandler _deletePortfolioHandler;
        // defines the type of method that handles a simulate input event
        private SimulateHandler _simulateHandler;
        // defines the type of method that handles a read file input event
        private ReadFileHandler _readFileHandler;


        
        private Account _account;
        private uxGetPortfolioNameForm getPortfolioNameForm;
        private uxBuyStocksForm buyStocksForm;
        private uxSellStockForm sellStockForm;

        private int _numOfPortolios = 0;


        public uxUserInterface(Account a , uxGetPortfolioNameForm getPNameForm, uxBuyStocksForm bStkForm, uxSellStockForm sStkForm,
            ReadFileHandler readFileHandler, SimulateHandler simulate, DeletePortfolioHandler deletePortfolio, AddPortfolioHandler addPortfolio, 
            SellStocksHandler sellStocks, BuyStocksHandler buyStocks, DepositCashHandler depositFunds, WithdrawCashHandler withdrawFunds)
        {
            ///Initializing account and inputForms///
            _account = a;
            getPortfolioNameForm = getPNameForm;
            buyStocksForm = bStkForm;
            sellStockForm = sStkForm;

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
        }

        private void uxAccountTab_Click(object sender, EventArgs e)
        {

        }

        //private void label3_Click(object sender, EventArgs e)
        //{

        //}

        //private void label4_Click(object sender, EventArgs e)
        //{

        //}

        private void uxTotalInvestedLabel_Click(object sender, EventArgs e)
        {

        }

        private void uxTotalInvestedOutput_Click(object sender, EventArgs e)
        {

        }

        private void uxPortfolio1_ButtonClick(object sender, EventArgs e)
        {
            uxPortfolioName.Text = uxPortfolio1.Text;
            //uxPortfolio1.Text = "";
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

        private void uxAddPortfolio_Click(object sender, EventArgs e)
        {
            

            uxGetPortfolioNameForm getPortfolio = new uxGetPortfolioNameForm();
            if (getPortfolio.ShowDialog() == DialogResult.OK)
            {
                string portfolioName = getPortfolioNameForm.PortfolioName;
                _addPortfolioHandler(portfolioName);

                AddPortfolioToToolStrip();// have controller call this?
            }

         

        }


        private void AddPortfolioToToolStrip()
        {
            _numOfPortolios++;

            switch (_numOfPortolios)
            {
                case 0:                 
                    uxPortfolio1.Visible = true;                    
                    break;
                case 1:
                    uxPortfolio2.Visible = true;   
                    break;
                case 2:
                    uxPortfolio3.Visible = true;
                    uxAddPortfolio.Visible = false;    
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
        public void ShowMyBuyStocksForm()
        {
            
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
        }

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
                string[] itemInfo = { i.Item1.ToString("C"), i.Item2.ToString("P"), i.Item3,i.Item4 };
                ListViewItem item = new ListViewItem(itemInfo);
                uxAccListInfo.Items.Add(item);
            }

            uxAccListInfo.EndUpdate();
        }
    }
}
