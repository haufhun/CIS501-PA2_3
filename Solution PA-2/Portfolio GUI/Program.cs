using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Class_Library;

namespace Portfolio_GUI
{
    // defines the type of method that observes model updates:
    public delegate void Observer();
    //defines the type of method that handles an input event (button press):
    public delegate void AccountInputHandler(object sender, EventArgs e); //for deposit & withdraw cash
    // defines the type of method that handles an input event (button press):
    public delegate void PortfolioInputHandler(object sender, EventArgs e); //for buy stocks, sell stocks & delete portfolio

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

            var mainForm = new UserInterface();

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
