using System;
using System.Windows.Forms;
using Ticker501_MVC.Model.Interfaces;

namespace Ticker501_MVC.View
{
    public partial class SellStocksForm : Form
    {
        /// <summary>
        /// Defines the type of method that handles a sell stock input event
        /// </summary>
        private Action<string, string, int> _sellStocksHandler;
        /// <summary>
        /// The account object.
        /// </summary>
        private readonly IAccount _account;
        /// <summary>
        /// The database object.
        /// </summary>
        private readonly IDatabase _database;
        /// <summary>
        /// The portfolio currently selected.
        /// </summary>
        private string _portfolioName;
        
        /// <summary>
        /// The constructor
        /// </summary>
        /// <param name="sellStocksHandler">The method in the controller that will be called on a sell stock click event.</param>
        /// <param name="account">The isntance of the account.</param>
        /// <param name="database">The instance of the database.</param>
        public SellStocksForm(Action<string, string, int> sellStocksHandler, IAccount account, IDatabase database)
        {
            _sellStocksHandler = sellStocksHandler;
            _account = account;
            _database = database;

            InitializeComponent();
        }

        /// <summary>
        /// Registers the portfolio name to the proper portfolio selected.
        /// </summary>
        /// <param name="name"></param>
        public void RegisterPortfolioName(string name)
        {
            _portfolioName = name;
        }
        /// <summary>
        /// Displays the info to the listView.
        /// </summary>
        public void DisplayListView()
        {
            if(_account.NumberOfStocks > 0)
            {
                uxSellStockListInfo.BeginUpdate();
                uxSellStockListInfo.Items.Clear();
                foreach (var s in _account.Portfolios[_portfolioName].Stocks.Values)
                {
                    //  Tickername, companyName, pricePerShare, sharesOwned, networthOfShares
                    var fullName = _database.StockDatabase[s.Name].Item2;
                    var price = _database.StockDatabase[s.Name].Item3;

                    string[] itemInfo = { s.Name, fullName, price.ToString("C"), s.NumberOfShares.ToString(), (price * s.NumberOfShares).ToString("C") };

                    uxSellStockListInfo.Items.Add(new ListViewItem(itemInfo));
                }
                uxSellStockListInfo.EndUpdate();
            }
        }
       
        /// <summary>
        /// Click handler for the sell stock button the main handle event.
        /// </summary>
        private void uxSellStockBttn_Click(object sender, EventArgs e)
        {
            if (uxSellStockListInfo.SelectedItems.Count > 0)
            {
                var tickerName = uxSellStockListInfo.SelectedItems[0].SubItems[0].Text;

                var numberOfShares = Convert.ToInt32(uxNumberOfShares.Value);
                _sellStocksHandler(_portfolioName, tickerName, numberOfShares);
                
                //var cost =
                //(numberOfShares *
                // Convert.ToDecimal(uxSellStockListInfo.SelectedItems[0].SubItems[2].Text.Substring(1))).ToString(
                //    "c");
                //uxResultLabel.Text = "You sold " + numberOfShares + " share(s) of " + tickerName +
                //                      " for a total of " + cost;
            }
            else
            {
                MessageBox.Show("Please select a stock!");
            }
        }
        /// <summary>
        /// Click handler for Close buton. Closes the program
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxCloseBttn_Click(object sender, EventArgs e)
        {
            uxNumberOfShares.Value = 1;
            uxPotentialAmount.Text = "$0.00";

            Hide();
        }
        /// <summary>
        /// Updates info when an item is selected in the list view.
        /// </summary>
        private void uxSellStockListInfo_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (uxSellStockListInfo.SelectedItems.Count > 0)
            {
                var numOfSharesOwned = uxSellStockListInfo.SelectedItems[0].SubItems[3].Text;
                uxNumberOfShares.Maximum = Convert.ToDecimal(numOfSharesOwned);

                var currentPrice = Convert.ToDecimal(uxSellStockListInfo.SelectedItems[0].SubItems[2].Text.Substring(1));
                uxPotentialAmount.Text = "Potential Profit: " + (currentPrice * uxNumberOfShares.Value).ToString("C");
            }
        }

        /// <summary>
        /// updates information when number of shares are changed.
        /// </summary>
        private void uxNumberOfShares_ValueChanged(object sender, EventArgs e)
        {
            if (uxSellStockListInfo.SelectedItems.Count > 0)
            {
                var currentPrice = Convert.ToDecimal(uxSellStockListInfo.SelectedItems[0].SubItems[2].Text.Substring(1));
                uxPotentialAmount.Text = "Potential Profit: " + (currentPrice * uxNumberOfShares.Value).ToString("C");
            }
        }

    }
}
