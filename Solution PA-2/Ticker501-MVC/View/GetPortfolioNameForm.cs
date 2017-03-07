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
