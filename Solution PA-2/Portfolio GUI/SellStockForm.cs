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
        private SellStocksHandler _sellStocksHandler;
        private string _portfolioName;
        private Account _account;

        public uxSellStockForm(string portfolioName, SellStocksHandler handler, Account a)
        {
            _portfolioName = portfolioName;
            _account = a;
            _sellStocksHandler = handler;
            InitializeComponent();
            DisplayListView();

        }

        private void DisplayListView()
        {
            var infoList = _account.GetAllPortfolioStockInfoTuple(_portfolioName);

            uxSellStockListInfo.BeginUpdate();
            uxSellStockListInfo.Items.Clear();

            foreach (var i in infoList)
            {
                //  Tickername, companyName, pricePerShare, sharesOwned, networthOfShares
                string[] itemInfo = {  i.Item1, i.Item2, i.Item3.ToString("C"), i.Item4.ToString(), i.Item5.ToString("C") };

                uxSellStockListInfo.Items.Add(new ListViewItem(itemInfo));
            }

            uxSellStockListInfo.EndUpdate();
        }

        private void uxSellStockListInfo_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (uxSellStockListInfo.SelectedItems.Count > 0)
            {
                var numOfSharesOwned = uxSellStockListInfo.SelectedItems[0].SubItems[3];
                uxNumberOfShares.Maximum = Convert.ToInt32(numOfSharesOwned);
            }
        }

        private void uxSellStockBttn_Click(object sender, EventArgs e)
        {
            if (uxSellStockListInfo.SelectedItems.Count > 0)
            {
                string tickerName = uxSellStockListInfo.SelectedItems[0].SubItems[0].Text;

                int numberOfShares = Convert.ToInt32(uxNumberOfShares.Value);
                _sellStocksHandler(_portfolioName, tickerName, numberOfShares);

            }
            else
            {
                MessageBox.Show("Please select a stock!");
            }
        }
    }
}
