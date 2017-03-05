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
        public AddWithdrawFundsForm(int formType)
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
    }

}
