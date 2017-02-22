using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Class_Library;

namespace Portfolio_GUI
{
    public partial class uxSellStockForm : Form
    {
        //private fields for contructors.////////////
        private SellStocksHandler _sellStocksHandler;
        private string _portfolioName;
        private Account _account;
        /////////////////////////////////////////////

        /// <summary>
        /// Contructor for buy stocks form.
        /// </summary>
        /// <param name="portfolioName">Portfolio name</param>
        /// <param name="handler">sell stock handler delegate</param>
        /// <param name="a">the account object</param>
        public uxSellStockForm(string portfolioName, SellStocksHandler handler, Account a)
        {
            _portfolioName = portfolioName;
            _account = a;
            _sellStocksHandler = handler;
            InitializeComponent();
            DisplayListView();
        }

        /// <summary>
        /// Click handler for the sell stock button the main handle event.
        /// </summary>
        private void uxSellStockBttn_Click(object sender, EventArgs e)
        {
            
            if (uxSellStockListInfo.SelectedItems.Count > 0)
            {
                string tickerName = uxSellStockListInfo.SelectedItems[0].SubItems[0].Text;

                int numberOfShares = Convert.ToInt32(uxNumberOfShares.Value);
                _sellStocksHandler(_portfolioName, tickerName, numberOfShares);
                var cost =
                (numberOfShares *
                 Convert.ToDecimal(uxSellStockListInfo.SelectedItems[0].SubItems[2].Text.Substring(1))).ToString(
                    "c");
                uxResultLabel.Text = "You sold " + numberOfShares + " share(s) of " + tickerName +
                                      " for a total of " + cost;

                DisplayListView();
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
            Close();
        }

        /// <summary>
        /// Displays the info to the listView.
        /// </summary>
        private void DisplayListView()
        {
            var infoList = _account.GetAllPortfolioStockInfoTuple(_portfolioName);

            uxSellStockListInfo.BeginUpdate();
            uxSellStockListInfo.Items.Clear();

            foreach (var i in infoList)
            {
                //  Tickername, companyName, pricePerShare, sharesOwned, networthOfShares
                string[] itemInfo = {i.Item1, i.Item2, i.Item3.ToString("C"), i.Item4.ToString(), i.Item5.ToString("C")};

                uxSellStockListInfo.Items.Add(new ListViewItem(itemInfo));
            }

            uxSellStockListInfo.EndUpdate();
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

        //private void uxSellStockListInfo_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (uxSellStockListInfo.SelectedItems.Count > 0)
        //    {
        //       // uxNumberOfShares.Maximum = Convert.ToDecimal(uxSellStockListInfo.SelectedItems[0].SubItems[3].Text);
        //        var currentPrice = Convert.ToDecimal(uxSellStockListInfo.SelectedItems[0].SubItems[2].Text.Substring(1));
        //        uxPotentialAmount.Text = "Potential Profit: " + (currentPrice * uxNumberOfShares.Value).ToString("C");
        //    }
        //}


    }
}
