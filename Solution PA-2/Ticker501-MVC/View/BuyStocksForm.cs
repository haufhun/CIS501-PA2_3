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
        private Action<string, string, int> _buyStocks;

        private readonly IDatabase _database;

        private string _selectedPortfolio;

        public BuyStocksForm(Action<string, string, int> buyStocks, IDatabase database)
        {
            _buyStocks = buyStocks;
            _database = database;

            InitializeComponent();
        }

        public void RegisterPortfolioName(string name)
        {
            _selectedPortfolio = name;
        }

        private void uxCloseBttn_Click(object sender, EventArgs e)
        {
            //clear

            //Need a handler for this?
            Hide();
        }

        private void uxBuyStockBttn_Click(object sender, EventArgs e)
        {
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
