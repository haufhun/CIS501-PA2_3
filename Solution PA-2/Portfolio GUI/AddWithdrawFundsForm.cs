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
    public partial class uxAddWithdrawFundsForm : Form
    {
        /// <summary>
        /// Cotructor for form
        /// </summary>
        /// <param name="formType">1 for Add funds form anything else for Withdraw funds form</param>
        public uxAddWithdrawFundsForm(int formType)
        {
            InitializeComponent();

            DisplayCorrectForm(formType);
        }

        private void DisplayCorrectForm(int formType)
        {
            Text = "Add Funds Form";
            switch (formType)
            {
                case 1:
                    uxInfoLabel.Text = "How much cash would you like to add?";
                    Text = "Add Funds Form";
                    break;
                default:
                    uxInfoLabel.Text = "How much cash would you like to withdraw?";
                    Text = "Withdraw Funds Form";
                    break;
            }
        }

        public decimal Amount => Convert.ToDecimal(uxAmountTxtBox.Text);

        private void uxAmountTxtBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void uxAmountTxtBox_TextChanged(object sender, EventArgs e)
        {
            var text = (sender as TextBox).Text;
            if (text.Length > 0)
            {
                if (Convert.ToDecimal(text) > Account.TRANSFER_FEE)
                {
                    uxOK.Enabled = true;
                }
            }
            else
            {
                uxOK.Enabled = false;
            }
        }
    }
}
