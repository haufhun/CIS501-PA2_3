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
    public partial class uxGetPortfolioNameForm : Form
    {
        private List<string> _portfolioNames = new List<string>();
        public uxGetPortfolioNameForm()
        {
            InitializeComponent();
        }

        public string PortfolioName => uxPNameTxtBox.Text;

        private void uxPNameTxtBox_TextChanged(object sender, EventArgs e)
        {
            uxOK.Enabled = (sender as TextBox).Text.Length > 0;
        }
    }
}
