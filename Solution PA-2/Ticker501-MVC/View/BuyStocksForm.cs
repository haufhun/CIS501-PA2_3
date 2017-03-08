using System;
using System.Windows.Forms;

namespace Ticker501_MVC.View
{
    public partial class BuyStocksForm : Form
    {
        /// <summary>
        /// Defines the type of method that handles a buy stock input event 
        /// </summary>
        private Action<string, string, int> buyStocks;

        public BuyStocksForm()
        {
            InitializeComponent();
        }

        public BuyStocksForm(Action<string, string, int> buyStocks)
        {
            this.buyStocks = buyStocks;
        }
    }
}
