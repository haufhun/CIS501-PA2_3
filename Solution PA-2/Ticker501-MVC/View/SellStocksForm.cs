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
    public partial class SellStocksForm : Form
    {
        /// <summary>
        /// Defines the type of method that handles a sell stock input event
        /// </summary>
        private Action<string, string, int> sellStocks;

        public SellStocksForm()
        {
            InitializeComponent();
        }

        public SellStocksForm(Action<string, string, int> sellStocks)
        {
            this.sellStocks = sellStocks;
        }
    }
}
