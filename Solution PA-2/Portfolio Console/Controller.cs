using System;
using System.Collections.Generic;
using System.IO;
using Class_Library;

namespace Portfolio_Console
{
    /// <summary>
    /// Controlls the program interaction between the console user interface and the account.
    /// </summary>
    public class Controller
    {
        /// <summary>
        /// The account.
        /// </summary>
        private Account _account;
        /// <summary>
        /// The user interface.
        /// </summary>
        private UserInterface _userInterface;
        /// <summary>
        /// A boolean to determine to continue the program or not.
        /// </summary>
        private bool _continueProgram;

        /// <summary>
        /// Initializes the account, user interface and the continue program, and also reads info from the file to create the database.
        /// </summary>
        public Controller(Account a, UserInterface ui)
        {
            this._account = a;
            this._userInterface = ui;
            _continueProgram = true;
        }

        /// <summary>
        /// Runs the program.
        /// </summary>
        public void RunProgram()
        {
            do
            {
                RunAccountMenu();
            } while (_continueProgram);
        }

        /// <summary>
        /// The account menu, which decides what action to take.
        /// </summary>
        private void RunAccountMenu()
        {
            var response = _userInterface.AskForUserSelectionOfMainMenu(_account.CashBalance);

            switch (response)
            {
                case 1:
                    {
                        Deposit();
                    }
                    break;
                case 2:
                    {
                        Withdraw();
                    }
                    break;
                case 3:
                    {
                        AccountBalance();
                    }
                    break;
                case 4:
                    {
                        CashAndPositionsBalance();
                    }
                    break;
                case 5:
                    {
                        GainsAndLossesReport();
                    }
                    break;
                case 6:
                    {
                        AddPortfolio();
                    }
                    break;
                case 7:
                    {
                        SelectPortfolio();
                    }
                    break;
                case 8:
                    {
                        Simulate();
                    }
                    break;
                case 9:
                    {
                        EndProgram();
                    }
                    break;
                default:
                    {
                        _userInterface.DisplayIncorrectOptionChosenMessage();
                        _userInterface.WaitForUserToPressEnter();
                    }
                    break;
            }
        }

        /// <summary>
        /// Ends the program.
        /// </summary>
        private void EndProgram()
        {
            Console.Write("Goodbye!");
            _continueProgram = false;
        }
        /// <summary>
        /// Prints the gains/losses report of the account.
        /// </summary>
        private void GainsAndLossesReport()
        {
            _userInterface.DisplayGainsAndLossesReport(_account.GetGainsAndLossesReport());
            _userInterface.WaitForUserToPressEnter();
        }
        /// <summary>
        /// Deposits money into the account cash.
        /// </summary>
        private void Deposit()
        {
            decimal cash = 0;
            try
            {
                cash = Convert.ToDecimal(_userInterface.AskForFundsToAdd());
                if(cash < Account.TRANSFER_FEE)
                {
                    _userInterface.DisplayDepositTooSmall();
                    _userInterface.WaitForUserToPressEnter();
                    return;
                }
            }
            catch(FormatException)
            {
                _userInterface.DisplayIncorrectNumberInput();
                _userInterface.WaitForUserToPressEnter();
                return;
            }
            try
            {
                if (_userInterface.UserWantsToContinue(Account.TRANSFER_FEE))
                {

                    try
                    {
                        _account.AddFundsToCashFund(cash);
                        _userInterface.DisplayFundsWereAdded(cash - Account.TRANSFER_FEE);
                    }
                    catch (InsufficientAccountBalanceFundsException ex)
                    {
                        _userInterface.DisplayErrorMessage(ex.ToString());
                    }
                }

            }
            catch (IndexOutOfRangeException ex)
            {
                _userInterface.DisplayErrorMessage(ex.ToString());
            }
            _userInterface.WaitForUserToPressEnter();
        }
        /// <summary>
        /// Withdraws money from the account cash. If there is not enough money in cash, the user is 
        /// directed to sell stocks to withdraw the correct amount of money.
        /// </summary>
        private void Withdraw()
        {
            if (_account.CashBalance <= 0)
            {
                _userInterface.DisplayErrorMessage("Non-sufficient funds in your account! Please deposit money first.");
                _userInterface.WaitForUserToPressEnter();
                return;
            }
            decimal withdrawl = 0;

            bool validInput = false;
            while (!validInput)
            {
                validInput = true;
                try
                {
                    withdrawl = Convert.ToDecimal(_userInterface.AskForFundsToWithdraw());
                    if (withdrawl > _account.CashBalance + _account.InvestedBalance || withdrawl > _account.CashBalance - Account.TRANSFER_FEE)
                    {
                        _userInterface.DisplayErrorMessage("\nYou do not have sufficient funds in your account. Please try again.");
                        validInput = false;
                    }
                }
                catch (FormatException)
                {
                    _userInterface.DisplayIncorrectNumberInput();
                    validInput = false;
                }
            }

            try
            {
                if (_userInterface.UserWantsToContinue(Account.TRANSFER_FEE))
                {
                    while (withdrawl > _account.CashBalance)
                    {
                        _userInterface.DisplayErrorMessage(
                            "\nYou do not have sufficient funds in your accout. You must sell some of your stocks.");
                        if (_userInterface.UserWantsToContinue())
                        {
                            if (_account.NumberOfPortfolios == 0)
                            {
                                _userInterface.DisplayNoPortoliosCreatedMessage();
                            }
                            else
                            {
                                var names = _account.GetListOfPortfolioNames();
                                var num = HandlePortfolioSelection(names);
                                SellStock(names[num - 1]);
                            }
                        }
                    }
                    _account.WithdrawFunds(withdrawl); //=Account.TRANSFER_FEE);
                    // _userInterface.DisplayFundsWereWithdrawn(withdrawl - Account.TRANSFER_FEE);
                    _userInterface.DisplayFundsWereWithdrawn(withdrawl);
                }
            }
            catch (InsufficientAccountBalanceFundsException ex)
            {
                _userInterface.DisplayErrorMessage(ex.ToString());
            }
            catch (IndexOutOfRangeException ex)
            {
                _userInterface.DisplayErrorMessage(ex.ToString());
            }
            _userInterface.WaitForUserToPressEnter();
        }
        /// <summary>
        /// Receives a number from the user interface of which portfolio to select, then returns the
        /// index of that portfolio if the input is correct.
        /// </summary>
        /// <param name="names">The list containing the names of the portfolios</param>
        /// <returns>The index of the portfolio the user would like to select.</returns>
        private int HandlePortfolioSelection(List<string> names)
        {
            bool valid = false;
            int num = 0;
            while (!valid)
            {
                    try
                    {
                        num = Convert.ToInt32(_userInterface.DisplayPortfoliosAndAskForPortfolioNumber(names));
                        if (names[num-1] == null)
                        {
                            _userInterface.DisplayErrorMessage(
                                "A portfolio at that spot does not exist. Enter a number that is displayed.");
                        }
                        else
                        {
                            valid = true;
                        }
                    }
                    catch (FormatException)
                    {
                        _userInterface.DisplayIncorrectNumberInput();
                    }
            }
            return num;
        }
        /// <summary>
        /// Displays the account balance.
        /// </summary>
        private void AccountBalance()
        {
            _userInterface.DisplayAccountBalance(_account.GetAccountBalance());
            _userInterface.WaitForUserToPressEnter();
        }
        /// <summary>
        /// Displays the total value of all the stocks in the account plus info about each position (stock).
        /// </summary>
        private void CashAndPositionsBalance()
        {
            var list = new List<Tuple<decimal, double, string, string>>();
            var cash = _account.GetCashBalance();
            _account.GetPositionsBalance(list);
            _userInterface.DisplayCashAndPositionsBalance(cash, list);
            _userInterface.WaitForUserToPressEnter();
        }
        /// <summary>
        /// Adds a portfolio.
        /// </summary>
        private void AddPortfolio()
        {
            if (_account.NumberOfPortfolios >= 3)
            {
                _userInterface.DisplayErrorMessage("You have already created the max amount of portfolios!");
                _userInterface.WaitForUserToPressEnter();
            }
            else
            {
                var name = _userInterface.AskForPortfolioName();
                _account.AddPortfolio(name);
                _userInterface.WaitForUserToPressEnter();
                RunPortfolioMenu(name);
            }
        }
        /// <summary>
        /// Simulates stock market activity, either high, medium or low volatility based on user choice.
        /// </summary>
        private void Simulate()
        {
            string volatility = _userInterface.AskForMarketVolatility();
            while (volatility != "1" && volatility != "2" && volatility != "3")
            {
                _userInterface.DisplayErrorMessage("\nIncorrect input. Try again. ");
                volatility = _userInterface.AskForMarketVolatility();
            }
            int volValue = Convert.ToInt32(volatility);
            try
            {
                if (_userInterface.UserWantsToContinue())
                {
                    switch (volValue)
                    {
                        case 1:
                        {
                            Simulator.SimulateHighVolatility();
                            _userInterface.DisplayMarketVolatilitySuccess(1);

                        }
                            break;
                        case 2:
                        {
                            Simulator.SimulateMediumVolatility();
                            _userInterface.DisplayMarketVolatilitySuccess(2);
                        }
                            break;
                        case 3:
                        {
                            Simulator.SimulateLowVolatility();
                            _userInterface.DisplayMarketVolatilitySuccess(3);
                        }
                            break;
                        default:
                        {
                            _userInterface.DisplayIncorrectOptionChosenMessage();
                        }
                            break;
                    }
                }
            }
            catch (IndexOutOfRangeException ex)
            {
                _userInterface.DisplayErrorMessage(ex.ToString());
            }
            _userInterface.WaitForUserToPressEnter();
        }
        /// <summary>
        /// Provides a list of portfolios to choose and allows user to select one.
        /// </summary>
        private void SelectPortfolio()
        {
            if (_account.NumberOfPortfolios == 0)
            {
                _userInterface.DisplayNoPortoliosCreatedMessage();
                _userInterface.WaitForUserToPressEnter();
            }
            else
            {
                var names = _account.GetListOfPortfolioNames();
                int num = HandlePortfolioSelection(names);
                _userInterface.WaitForUserToPressEnter();
                RunPortfolioMenu(names[num - 1]);
            }
        }
        /// <summary>
        /// The portfolio menu, displaying all the menu options for the portolio.
        /// </summary>
        /// <param name="portfolioName">The portfolio name.</param>
        private void RunPortfolioMenu(string portfolioName)
        {
            var portfolioIsSelected = true;
            do
            {
                //var portfolio = _account.SelectPortfolio(portfolioName);
                var portolioChoice = _userInterface.AskForUserSelectionOfPortfolio(portfolioName, _account.CashBalance);
                switch (portolioChoice)
                {
                    case 1:
                        {
                            BuyStock(portfolioName);
                        }
                        break;
                    case 2:
                        {
                            SellStock(portfolioName);
                        }
                        break;
                    case 3:
                        {
                            PortfolioBalance(portfolioName);
                        }
                        break;
                    case 4:
                        {
                            PositionsBalance(portfolioName);
                        }
                        break;
                    case 5:
                        {
                            PortfolioGainsAndLossesReport(portfolioName);
                        }
                        break;
                    case 6:
                        {
                            portfolioIsSelected = DeletePortfolio(portfolioName);
                        }
                        break;
                    case 7:
                        {
                            Console.WriteLine();
                            portfolioIsSelected = false;
                        }
                        break;
                    default:
                        {
                            _userInterface.WaitForUserToPressEnter();
                        }
                        break;
                }
            } while (portfolioIsSelected);
        }
        /// <summary>
        /// Deletes the portfolio, selling all stocks within.
        /// </summary>
        /// <param name="portfolioName">The portfolio name.</param>
        /// <returns>False indicating to exit the portfolio menu.</returns>
        private bool DeletePortfolio(string portfolioName)
        {
            var totalValue = _account.SelectPortfolio(portfolioName).GetCurrentValueOfAllStocks();
            _userInterface.DisplayPortolioValue(totalValue);
            try
            {
                if (!_userInterface.UserWantsToContinue()) return true;
            }
            catch (IndexOutOfRangeException ex)
            {
                _userInterface.DisplayErrorMessage(ex.ToString());
            }
            _account.DeletePortfolio(portfolioName);
            _userInterface.DisplayPortfolioWasDeleted(portfolioName, totalValue);
            _userInterface.WaitForUserToPressEnter();
            return false;
        }
        /// <summary>
        /// Displays the gains/losses report.
        /// </summary>
        /// <param name="portfolioName"></param>
        private void PortfolioGainsAndLossesReport(string portfolioName)
        {
            _userInterface.DisplayGainsAndLossesReport(_account.SelectPortfolio(portfolioName).GetGainsAndLossesReport());
            _userInterface.WaitForUserToPressEnter();
        }
        /// <summary>
        /// Displays the position balance of each stock in the portfolio.
        /// </summary>
        /// <param name="portfolioName"></param>
        private void PositionsBalance(string portfolioName)
        {
            var list = new List<Tuple<decimal, double, string, string>>();
            _account.SelectPortfolio(portfolioName).GetPositionsBalance(list);
            _userInterface.DisplayPositionsBalance(list);
            _userInterface.WaitForUserToPressEnter();
        }
        /// <summary>
        /// Displays the amount invested in the portfolio and the percent of the account the portfolio is.
        /// </summary>
        /// <param name="portfolioName">The name of the portfolio.</param>
        private void PortfolioBalance(string portfolioName)
        {
            _userInterface.DisplayPortfolioBalance(_account.GetPortfolioBalance(portfolioName));
            _userInterface.WaitForUserToPressEnter();
        }
        /// <summary>
        /// Buys a stock of a portfolio.
        /// </summary>
        /// <param name="portfolioName">The portfolio name.</param>
        private void BuyStock(string portfolioName)
        {
            if (_account.CashBalance > 0)
            {
                try
                {
                    string tickerName = UserStockName();
                    _userInterface.DisplayStockInfo(tickerName, DataBase.PriceAndTickerName[tickerName].Item2, 
                            DataBase.PriceAndTickerName[tickerName].Item3);
                    
                    int inputOption = _userInterface.AskForWayOfPurchasingStocks();
                    if (inputOption == 1)
                    {
                        int shares = UserNumberOfShares();
                        try
                        {
                            if (_userInterface.UserWantsToContinue(Account.TRADE_FEE))
                                _account.BuyStock(portfolioName, tickerName, shares);
                        }
                        catch (IndexOutOfRangeException ex)
                        {
                            _userInterface.DisplayErrorMessage(ex.ToString());
                        }
                        _userInterface.DisplayStockWasPurchased(shares, DataBase.PriceAndTickerName[tickerName].Item3, tickerName);
                    }
                    else if (inputOption == 2)
                    {
                        decimal dollars=0;
                        bool valid = false;
                        while (!valid)
                        {
                            try
                            {
                                dollars = Convert.ToDecimal(_userInterface.AskForDollars());
                                valid = true;
                            }
                            catch (FormatException)
                            {
                                _userInterface.DisplayIncorrectNumberInput();
                            }
                        }
                        int shares = (int)(dollars / DataBase.PriceAndTickerName[tickerName].Item3);
                        try
                        {
                            if (_userInterface.UserWantsToContinue(Account.TRADE_FEE))
                                _account.BuyStock(portfolioName, tickerName, shares);
                        }
                        catch (IndexOutOfRangeException ex)
                        {
                            _userInterface.DisplayErrorMessage(ex.ToString());
                        }
                        catch (DivideByZeroException)
                        {
                            Console.WriteLine("The price entered exceeds the price of one stock. Cannot continue transaction...");
                        }
                        _userInterface.DisplayStockWasPurchased(shares, DataBase.PriceAndTickerName[tickerName].Item3, tickerName);
                    }
                    else
                    {
                        _userInterface.DisplayIncorrectOptionChosenMessage();
                    }
                }
                catch (InsufficientAccountBalanceFundsException)
                {
                    Console.WriteLine("\nInsufficient funds in your account. Deposit more money before continuing!");
                }
            }
            else
            {
                Console.WriteLine("\nYou have no money in your account!\n");
            }
            _userInterface.WaitForUserToPressEnter();
        }
        /// <summary>
        /// Asks the user for the name of the stock.
        /// </summary>
        /// <returns>The name of the stock.</returns>
        private string UserStockName()
        {
            bool valid = false;
            string tickerName = "";
            while (!valid)
            {
                tickerName = _userInterface.AskForStockName();
                if (!DataBase.PriceAndTickerName.ContainsKey(tickerName))
                {
                    _userInterface.DisplayErrorMessage("This stock does not exist. Please enter a stock from the ticker file.");
                }
                else
                {
                    valid = true;
                }
            }
            return tickerName;
        }
        /// <summary>
        /// Gets the number of shares the user would like to select and handles any error.
        /// </summary>
        /// <returns>The number of shares</returns>
        private int UserNumberOfShares()
        {
            bool valid = false;
            int shares = 0;
            while (!valid)
            {
                try
                {
                    shares = Convert.ToInt32(_userInterface.AskForNumberOfShares());
                    if (shares <= 0)
                    {
                        _userInterface.DisplayIncorrectOptionChosenMessage();
                    }
                    else { valid = true; }
                }
                catch (FormatException)
                {
                    _userInterface.DisplayIncorrectNumberInput();
                }
            }
            return shares;
        }
        /// <summary>
        /// Sells a stock of a portfolio.
        /// </summary>
        /// <param name="portfolioName">The portfolio name.</param>
        private void SellStock(string portfolioName)
        {
            if (_account.InvestedBalance > 0)
            {
                var tickerName = UserStockName();

                while (!_account.SelectPortfolio(portfolioName).ContainsStock(tickerName))
                {
                    _userInterface.DisplayIncorrectOptionChosenMessage();
                    tickerName = _userInterface.AskForStockName();
                }

                var shares = UserNumberOfShares();
                if (_userInterface.UserWantsToContinue(Account.TRADE_FEE))
                {
                    _account.SellNumberOfStocks(portfolioName, tickerName, shares);
                    _userInterface.DisplayStockWasSold(shares, DataBase.PriceAndTickerName[tickerName].Item3, tickerName);
                }
            }
            else
            {
                Console.WriteLine("\nYou have no stocks! ");
            }
            _userInterface.WaitForUserToPressEnter();
        }
    }
}