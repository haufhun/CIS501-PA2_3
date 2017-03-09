using System;
using System.Data;
using System.Windows.Forms;
using Ticker501_MVC.Model.Interfaces;

namespace Ticker501_MVC.View
{
    public partial class BuyStocksForm : Form
    {
        /// <summary>
        /// Defines the type of method that handles a buy stock input event 
        /// </summary>
        private Action<string, string, int> _buyStocksHandler;
        /// <summary>
        /// The database object.
        /// </summary>
        private readonly IDatabase _database;
        /// <summary>
        /// The account object.
        /// </summary>
        private readonly IAccount _account;
        /// <summary>
        /// The portfolio to perform the operation on.
        /// </summary>
        private string _portfolioName;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="buyStocksHandler">The method in the controller that buys the stocks.</param>
        /// <param name="database">The database object.</param>
        /// <param name="account">The account object.</param>
        public BuyStocksForm(Action<string, string, int> buyStocksHandler, IDatabase database, IAccount account)
        {
            _buyStocksHandler = buyStocksHandler;
            _database = database;
            _account = account;

            InitializeComponent();
            uxBuyBySharesOrPrice.SelectedIndex = 0;
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
        /// Handles the user closing the form, by hiding it and clearing contents.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxCloseBttn_Click(object sender, EventArgs e)
        {
            //clear

            //Need a handler for this?
            Hide();
        }
        /// <summary>
        /// Handles the user trying to buy a stock.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxBuyStockBttn_Click(object sender, EventArgs e)
        {
            if (uxBuyStockListInfo.SelectedItems.Count > 0)
            {

                var tickerName = uxBuyStockListInfo.SelectedItems[0].SubItems[0].Text;
                string cost = null;
                int numberOfShares = 0;
                switch(uxBuyBySharesOrPrice.SelectedIndex)
                {
                    case 0:
                        numberOfShares = Convert.ToInt32(uxNumberOfShares.Value);
                        break;
                    case 1:
                        numberOfShares = (int) (Convert.ToDecimal(uxAmount.Text) /
                                                Convert.ToDecimal(uxBuyStockListInfo.SelectedItems[0].SubItems[2].Text.Substring(1)));
                        break;
                }

                cost = (numberOfShares * Convert.ToDecimal(uxBuyStockListInfo.SelectedItems[0].SubItems[2].Text.Substring(1))).ToString("c");
                _buyStocksHandler(_portfolioName, tickerName, numberOfShares);
                //uxResultLabel.Text = "You bought " + numberOfShares + " share(s) of " + tickerName +
                //                     " for a total of " + cost;
            }
            else
            {
                MessageBox.Show("Please select a stock!");
            }
        }
        /// <summary>
        /// Changes form to either buy stocks by shares or by cash amount.
        /// </summary>
        private void uxBuyBySharesOrPrice_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (uxBuyBySharesOrPrice.SelectedIndex)
            {
                case 0:
                    uxNumberOfShares.Enabled = true;
                    uxAmount.Enabled = false;
                    break;
                case 1:
                    uxAmount.Enabled = true;
                    uxNumberOfShares.Enabled = false;
                    break;
                default:
                    uxNumberOfShares.Enabled = false;
                    uxAmount.Enabled = false;
                    break;
            }
        }


        /// <summary>
        /// Displays the info to the listView
        /// </summary>
        public void DisplayListView()
        {
            uxBuyStockListInfo.BeginUpdate();
            uxBuyStockListInfo.Items.Clear();

            foreach (var i in _database.StockDatabase.Values)
            {
                //Tickername, companyName, pricePerShare
                string[] itemInfo = { i.Item1, i.Item2, i.Item3.ToString("C") };

                uxBuyStockListInfo.Items.Add(new ListViewItem(itemInfo));
            }

            uxBuyStockListInfo.EndUpdate();
        }
    }
}
