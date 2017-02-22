using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            uxBuyBySharesOrPrice.SelectedIndex = 0;
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
                var cost =
                (numberOfShares *
                 Convert.ToDecimal(uxBuyStockListInfo.SelectedItems[0].SubItems[2].Text.Substring(1))).ToString(
                    "c");
                uxResultLabel.Text = "You bought " + numberOfShares + " share(s) of " + tickerName +
                                     " for a total of " + cost;
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
                var maxSharesToBuy = _account.GetMaxSharesToBuy(currentPrice);

                if (maxSharesToBuy < 1)
                {
                    uxNumberOfShares.Maximum = maxSharesToBuy + 1;
                }
                else
                {
                    uxNumberOfShares.Maximum = maxSharesToBuy;
                }

                switch (uxBuyBySharesOrPrice.SelectedIndex)
                {
                    case 0:
                        uxAmount.Text = (uxNumberOfShares.Value * currentPrice).ToString("F");
                        break;
                    case 1:
                        if (uxAmount.Text.Length > 0)
                        {
                            uxNumberOfShares.Value = Convert.ToDecimal(uxAmount.Text) / currentPrice;
                        }
                        break;
                }
            }
            


        }

        private void uxCloseBttn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
            if (Regex.IsMatch((sender as TextBox).Text, @"\.\d\d") && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

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

        private void uxNumberOfShares_ValueChanged(object sender, EventArgs e)
        {
            if (uxBuyBySharesOrPrice.SelectedIndex == 0 && uxBuyStockListInfo.SelectedItems.Count > 0)
            {
                var currentPrice = Convert.ToDecimal(uxBuyStockListInfo.SelectedItems[0].SubItems[2].Text.Substring(1));
                uxAmount.Text = (uxNumberOfShares.Value * currentPrice).ToString("F");
            }
        }

        private void uxAmount_TextChanged(object sender, EventArgs e)
        {
            if (uxBuyBySharesOrPrice.SelectedIndex == 1 && uxBuyStockListInfo.SelectedItems.Count > 0)
            {
                if(uxAmount.Text.Length > 0)
                {
                    var currentPrice = Convert.ToDecimal(uxBuyStockListInfo.SelectedItems[0].SubItems[2].Text.Substring(1));
                    uxNumberOfShares.Value = Convert.ToDecimal(uxAmount.Text) / currentPrice;
                }
            }
        }


    }
}
