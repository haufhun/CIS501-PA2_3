using System;
using System.Windows.Forms;

namespace Ticker501_MVC.View
{
    public partial class GetPortfolioNameForm : Form
    {
        private AddPortfolioHandler _addPortfolio;

        public GetPortfolioNameForm(AddPortfolioHandler addPortfolio)
        {
            this._addPortfolio = addPortfolio;
            InitializeComponent();
        }

        private void uxOK_Click(object sender, EventArgs e)
        {
            _addPortfolio(uxPNameTxtBox.Text);
        }
    }
}
