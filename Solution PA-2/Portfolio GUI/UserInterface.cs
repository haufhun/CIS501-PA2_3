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
    public partial class UserInterface : Form
    {
        private int _numOfPortolios = 0;
        public UserInterface()
        {
            InitializeComponent();
        
        }

        public UserInterface(EventHandler<EventArgs> handle)
        {
       
           // throw new NotImplementedException();
        }

        private void uxAccountTab_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void uxTotalInvestedLabel_Click(object sender, EventArgs e)
        {

        }

        private void uxTotalInvestedOutput_Click(object sender, EventArgs e)
        {

        }

        private void uxPortfolio1_ButtonClick(object sender, EventArgs e)
        {
            uxPortfolioName.Text = uxPortfolio1.Text;
            //uxPortfolio1.Text = "";
        }

        private void uxPortfolio2_ButtonClick(object sender, EventArgs e)
        {
            uxPortfolioName.Text = uxPortfolio2.Text;
        }

        private void uxPortfolio3_ButtonClick(object sender, EventArgs e)
        {
            uxPortfolioName.Text = uxPortfolio3.Text;
        }
        public void ShowMyBuyStocksForm()
        {
            //Form2 testDialog = new Form2();

            //// Show testDialog as a modal dialog and determine if DialogResult = OK.
            //if (testDialog.ShowDialog(this) == DialogResult.OK)
            //{
            //    // Read the contents of testDialog's TextBox.
            //    this.txtResult.Text = testDialog.TextBox1.Text;
            //}
            //else
            //{
            //    this.txtResult.Text = "Cancelled";
            //}
            //testDialog.Dispose();
        }

        public void AddPortfolio()
        {
            GetPortfolioNameForm PNameForm = new GetPortfolioNameForm();
            PNameForm.Show();

            switch (_numOfPortolios)
            {
                case 0:
                    uxPortfolio1.Visible = true;
                    _numOfPortolios++;
                    break;
                case 1:
                    uxPortfolio2.Visible = true;
                    _numOfPortolios++;
                    break;
                case 2:
                    uxPortfolio3.Visible = true;
                    uxAddPortfolio.Visible = false;
                    _numOfPortolios++;
                    break;
                default:
                    MessageBox.Show("You already have the maximum number of portfolios!");
                    break;
            }


        }

        private void uxAddPortfolio_Click(object sender, EventArgs e)
        {
            AddPortfolio();//For now

        }
    }
}
