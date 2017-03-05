using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ticker501_MVC
{
    // defines the type of method that observes model updates
    public delegate void Observer();
    //public delegate void PortfolioObserver();
    public delegate void AddPortfolioObserver(string portfolioName);
    public delegate void DisplayErrorMessageObserver(string errorMessage);

    //defines the type of method that handles a deposit cash input event 
    public delegate void DepositCashHandler(decimal cash);
    // defines the type of method that handles a withdraw cash input event
    public delegate void WithdrawCashHandler(decimal cash);
    // defines the type of method that handles a buy stock input event 
    public delegate void BuyStocksHandler(string portfolioName, string tickerName, int numberOfShares);
    // defines the type of method that handles a sell stock input event
    public delegate void SellStocksHandler(string portfolioName, string tickerName, int numberOfShares);
    // defines the type of method that handles a add portfolio input event 
    public delegate void AddPortfolioHandler(string portfolioName, AddPortfolioObserver addPrtMethod);
    // defines the type of method that handles a delete portfolio input event
    public delegate void DeletePortfolioHandler(string portfolioName);
    // defines the type of method that handles a simulate input event
    public delegate void SimulateHandler(int volatility);
    // defines the type of method that handles a read file input event
    public delegate bool ReadFileHandler(OpenFileDialog openFile);

    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
