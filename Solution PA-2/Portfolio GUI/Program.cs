using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Class_Library;

namespace Portfolio_GUI
{
    // defines the type of method that observes model updates
    public delegate void Observer();


    //defines the type of method that handles a deposit cash input event 
    public delegate void DepositCashHandler(decimal cash); 
    // defines the type of method that handles a withdraw cash input event
    public delegate void WithdrawCashHandler(decimal cash);
    // defines the type of method that handles a buy stock input event 
    public delegate void BuyStocksHandler(string portfolioName, string tickerName, int numberOfShares);
    // defines the type of method that handles a sell stock input event
    public delegate void SellStocksHandler(string portfolioName, string tickerName, int numberOfShares);
    // defines the type of method that handles a add portfolio input event 
    public delegate void AddPortfolioHandler(string portfolioName);
    // defines the type of method that handles a delete portfolio input event
    public delegate void DeletePortfolioHandler(string portfolioName);
    // defines the type of method that handles a simulate input event
    public delegate void SimulateHandler(int volatility);
    // defines the type of method that handles a read file input event
    public delegate void ReadFileHandler(OpenFileDialog openFile);

    /// <summary>
    /// Runs the program.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var account = new Account();
            var controller = new GuiController(account);
            var getPrtNameForm = new uxGetPortfolioNameForm();
            var buyStockForm = new uxBuyStocksForm();
            var sellStockForm = new uxSellStockForm();

            var mainForm = new uxUserInterface(account,getPrtNameForm, buyStockForm, sellStockForm, controller.ReadTickerFile, controller.Simulate, controller.DeletePortfolio, controller.AddPortfolio, controller.SellStocks, controller.BuyStocks, controller.DepositFunds, controller.WithdrawFunds);

            controller.Register(mainForm.DisplayHomeStockInfo);
            controller.Register(mainForm.DisplayAccount);

            // c.Register(mainForm.);

            Application.Run(mainForm);
            
                                                        //Deck d = new Deck();
                                                        //Hand h = new Hand();
                                                        //GameController c = new GameController(d, h);
                                                        //OutcomeForm outcome = new OutcomeForm(h);
                                                        //outcome.Show();

                                                        //MainForm mainform = new MainForm(c.handle2, h);
                                                        //c.register(mainform.showCards);
                                                        //c.register(outcome.checkScore);

                                                        //Application.Run(mainform);  // Run  mainform  to receive the input events that
                                                        ////   trigger computation.
                                                        //MessageBox.Show("Click to exit.", "Exit");
        }
    }
}
