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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void uxAddFunds_Click(object sender, EventArgs e)
        {
            AddWithdrawFundsForm form = new AddWithdrawFundsForm();
            DialogResult dr = form.ShowDialog();
            if(dr == DialogResult.OK)
            {
                //Add the funds of form.Amount to account
            }
            else
            {
                MessageBox.Show("No funds were added.");
            }
        }
    }
}
