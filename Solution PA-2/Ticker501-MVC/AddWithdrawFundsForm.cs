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
    public partial class AddWithdrawFundsForm : Form
    {
        private decimal _amount;

        public decimal Amount
        {
            get
            {
                return _amount;
            }
            set
            {
                _amount = value;
            }
        }
        
        public AddWithdrawFundsForm()
        {
            InitializeComponent();
        }

        private void uxOK_Click(object sender, EventArgs e)
        {
            try
            {
                _amount = Convert.ToDecimal(uxAmountTxtBox.Text);
            }
            catch(FormatException)
            {
                MessageBox.Show("Please enter a decimal number or press exit to cancel");
            }
        }

        private void uxAmountTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (!(uxAmountTxtBox.Text == ""))
            {
                uxOK.Enabled = true;
            }
            else
            {
                uxOK.Enabled = false;
            }
        }
    }
}
