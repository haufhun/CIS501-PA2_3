using System;
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
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
