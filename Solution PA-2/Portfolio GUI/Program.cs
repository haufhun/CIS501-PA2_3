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
    public delegate void DepositCashHandler(object sender, EventArgs e); 
    // defines the type of method that handles a withdraw cash input event
    public delegate void WithdrawCashHandler(object sender, EventArgs e);
    // defines the type of method that handles a buy stock input event 
    public delegate void BuyStocksHandler(object sender, EventArgs e);
    // defines the type of method that handles a sell stock input event
    public delegate void SellStocksHandler(object sender, EventArgs e);
    // defines the type of method that handles a add portfolio input event 
    public delegate void AddPortfolioHandler(object sender, EventArgs e);
    // defines the type of method that handles a delete portfolio input event
    public delegate void DeletePortfolioHandler(object sender, EventArgs e);
    // defines the type of method that handles a simulate input event
    public delegate void SimulateHandler(object sender, EventArgs e);
    // defines the type of method that handles a read file input event
    public delegate void ReadFileHandler(object sender, EventArgs e); 

    /// <summary>
    /// Runs the program.
    /// </summary>
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var a = new Account();
            

            var c = new GuiController(a);

            var mainForm = new UserInterface(a);

            //c.Register()

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
