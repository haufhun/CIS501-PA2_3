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
        private AddWithdrawFundsForm _aWFundsForm;
        private BuyStocksForm _bSForm;
        private SellStocksForm _sSForm;


        /// <summary>
        /// Constructor for User interface. Initilazies the model, forms and handlers.
        /// </summary>
        public MainForm(Account a, AddWithdrawFundsForm aWFundsForm, BuyStocksForm bSForm, SellStocksForm sSForm, PortfolioSelectedHandler portfolioSelected, DepositCashHandler depositFunds, WithdrawCashHandler withdrawFunds, BuyStocksHandler buyStocks, SellStocksHandler sellStocks, AddPortfolioHandler addPortfolio, DeletePortfolioHandler deletePortfolio, SimulateHandler simulate, ReadFileHandler readTickerFile)
        {
            //Initialize Account and Forms
            _account = a;
            _aWFundsForm = aWFundsForm;
            _bSForm = bSForm;
            _sSForm = sSForm;

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
        }

        /// <summary>
        /// Handles if the user selects portfolio 1 on the portfolio tab.
        /// </summary>
        private void uxPortfolio1_ButtonClick(object sender, EventArgs e)
        {
            uxPortfolioName.Text = uxPortfolio1.Text;
            _portfolioSelectedHandler(uxPortfolio1.Text);
            //_currentPortfolio = uxPortfolio1.Text;
            //DisplayPortfolio();
        }

        /// <summary>
        /// Hanldes if the user selects portfolio 2 on the portfolio tab.
        /// </summary>
        private void uxPortfolio2_ButtonClick(object sender, EventArgs e)
        {
            uxPortfolioName.Text = uxPortfolio2.Text;
            _portfolioSelectedHandler(uxPortfolio2.Text);
            //_currentPortfolio = uxPortfolio2.Text;
            //DisplayPortfolio();
        }

        /// <summary>
        /// handles if the user selects portfolio 3 on the portfolio tab.
        /// </summary>
        private void uxPortfolio3_ButtonClick_1(object sender, EventArgs e)
        {
            uxPortfolioName.Text = uxPortfolio3.Text;
            _portfolioSelectedHandler(uxPortfolio3.Text);
            //_currentPortfolio = uxPortfolio3.Text;
            //DisplayPortfolio();
        }
        public void DisplayPortfolio(string currentPortfolio)
        {
            uxPortfolioName.Text = currentPortfolio;

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

    }
}
