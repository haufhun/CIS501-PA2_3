﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Portfolio_GUI
{
    public partial class uxBuyStocksForm : Form
    {
        public uxBuyStocksForm()
        {
            InitializeComponent();
            
        }

        private void uxBuyStockBttn_Click(object sender, EventArgs e)
        {
            if (uxBuyStockListInfo.SelectedItems.Count > 0)
            {
                
            }
            else
            {
                MessageBox.Show("Please select a stock!");
            }
        }

    }
}
