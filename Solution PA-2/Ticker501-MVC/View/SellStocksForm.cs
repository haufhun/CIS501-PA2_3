using System;
using System.Windows.Forms;

namespace Ticker501_MVC.View
{
    public partial class SellStocksForm : Form
    {
        /// <summary>
        /// Defines the type of method that handles a sell stock input event
        /// </summary>
        private Action<string, string, int> _sellStocks;

        public SellStocksForm(Action<string, string, int> sellStocks)
        {
            _sellStocks = sellStocks;

            InitializeComponent();
        }
    }
}
