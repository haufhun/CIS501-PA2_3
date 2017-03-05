﻿using System;
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
    public partial class BuyStocksForm : Form
    {
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
