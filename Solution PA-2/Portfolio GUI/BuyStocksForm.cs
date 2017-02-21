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
    public partial class uxBuyStocksForm : Form
    {
        
        private BuyStocksHandler _buyStocksHandler;
        private string _portfolioName;
        private Account _account;

        public uxBuyStocksForm(string portfolioName, BuyStocksHandler handler, Account a)
        {
            _portfolioName = portfolioName;
            _buyStocksHandler = handler;
            _account = a;
            InitializeComponent();
            DisplayListView();
        }

        private void DisplayListView()
        {
            uxBuyStockListInfo.BeginUpdate();
            uxBuyStockListInfo.Items.Clear();

            foreach (var i in DataBase.PriceAndTickerName.Values)
            {
                //Tickername, companyName, pricePerShare
                string[] itemInfo = {i.Item1, i.Item2, i.Item3.ToString("C")};
                
                uxBuyStockListInfo.Items.Add(new ListViewItem(itemInfo));
                
            }

            uxBuyStockListInfo.EndUpdate();
        }


        private void uxBuyStockBttn_Click(object sender, EventArgs e)
        {
            if (uxBuyStockListInfo.SelectedItems.Count > 0)
            {
                string tickerName = uxBuyStockListInfo.SelectedItems[0].SubItems[0].Text;
                
                int numberOfShares = Convert.ToInt32(uxNumberOfShares.Value);
                _buyStocksHandler(_portfolioName, tickerName, numberOfShares);
            }
            else
            {
                MessageBox.Show("Please select a stock!");
            }
        }

        private void uxBuyStockListInfo_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (uxBuyStockListInfo.SelectedItems.Count > 0)
            {
                var currentPrice = Convert.ToDecimal(uxBuyStockListInfo.SelectedItems[0].SubItems[2].Text.Substring(1));
                uxNumberOfShares.Maximum = _account.GetMaxSharesToBuy(currentPrice);
            }


        }
    }
}
