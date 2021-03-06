﻿using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Ticker501_MVC.Model;

namespace Ticker501_MVC.View
{
    public partial class AddWithdrawFundsForm : Form
    {

        /// <summary>
        ///  Either a DepositCashHandler or a WithdrawCashHandler
        /// </summary>
        private Action<decimal> _addOrWithdrawFunds;

        /// <summary>
        /// Consturctor fo rForm
        /// </summary>
        /// <param name="formType">1 for add funds form 2 for withdraw funds form</param>
        /// <param name="addWithdrawFunds">the delegate to be used</param>
        public AddWithdrawFundsForm(int formType, Action<decimal> addWithdrawFunds)
        {
            _addOrWithdrawFunds = addWithdrawFunds;

            InitializeComponent();

            DisplayCorrectForm(formType);
        }

        /// <summary>
        /// updates the label to display the correct information.
        /// </summary>
        /// <param name="formType">'1' is for add funds form and '2' is for withdraw funds form. </param>
        private void DisplayCorrectForm(int formType)
        {
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

        /// <summary>
        /// Makes sure they can only input a valid decimal in txtbox
        /// </summary>
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
        /// <summary>
        /// Makes sure what they are depositing is above the transfer fee value.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxAmountTxtBox_TextChanged(object sender, EventArgs e)
        {
            var text = (sender as TextBox).Text;

            decimal temp;
            if (decimal.TryParse(text, out temp))
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

        /// <summary>
        /// OK button click handler.. calls the correct delegate  int he controller
        /// </summary>
        private void uxOK_Click(object sender, EventArgs e)
        {
            _addOrWithdrawFunds(Convert.ToDecimal(uxAmountTxtBox.Text));
            //Clear
            uxAmountTxtBox.Text = "";

            Hide();
        }

        /// <summary>
        /// The user clicks the cancel button... do no action, just hide the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxCancel_Click(object sender, EventArgs e)
        {
            //clear
            uxAmountTxtBox.Text = "";

            Hide();
        }
    }
}
