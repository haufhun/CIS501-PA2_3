using System;
using System.Windows.Forms;

namespace Ticker501_MVC.View
{
    public partial class GetPortfolioNameForm : Form
    {
        /// <summary>
        /// The handler to the add portfolio method in the controller.
        /// </summary>
        private AddPortfolioHandler _addPortfolio;

        /// <summary>
        /// Contructor initializes a new form with a handler.
        /// </summary>
        /// <param name="addPortfolio">The handler to the add portfolio action.</param>
        public GetPortfolioNameForm(AddPortfolioHandler addPortfolio)
        {
            this._addPortfolio = addPortfolio;
            InitializeComponent();
        }
        /// <summary>
        /// Enables the OK button if there is any text inside the text box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxPNameTxtBox_TextChanged(object sender, EventArgs e)
        {
            uxOK.Enabled = uxPNameTxtBox.Text.Length > 0 && uxPNameTxtBox.Text.Length < 15;
        }
        /// <summary>
        /// The user clicks OK, call the handler, clear and then Hide the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxOK_Click(object sender, EventArgs e)
        {
            _addPortfolio(uxPNameTxtBox.Text);
            uxPNameTxtBox.Clear();

            //Need a handler for this?
            Hide();
        }
        /// <summary>
        /// The user clicks Cancel, clear and then Hide the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxCancel_Click(object sender, EventArgs e)
        {
            //clear
            uxPNameTxtBox.Clear();

            //Need a handler for this?
            Hide();
        }

        
    }
}
