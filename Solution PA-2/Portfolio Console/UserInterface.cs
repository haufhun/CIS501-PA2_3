using System;
using System.Collections.Generic;
using System.Globalization;
using Class_Library;

namespace Portfolio_Console
{
    /// <summary>
    /// The user interface class, displaying info and getting info from the user.
    /// </summary>
    public class UserInterface
    {
        /// <summary>
        /// Initializes a new object.
        /// </summary>
        public UserInterface() { }

        /// <summary>
        /// Displays an error message passed in.
        /// </summary>
        /// <param name="message">The desired message to be displayed.</param>
        public void DisplayErrorMessage(string message)
        {
            Console.Write("\n" + message + "\n");
        }

        /// <summary>
        /// Displays that the user has pressed an incorrect menu option.
        /// </summary>
        public void DisplayIncorrectOptionChosenMessage()
        {
            Console.WriteLine("\nIncorrect menu option chosen. Please try again.");
        }
        /// <summary>
        /// Displays that no portfolios have been created in the account yet.
        /// </summary>
        public void DisplayNoPortoliosCreatedMessage()
        {
            Console.WriteLine("\nYou must create a portfolio before you can select one!");
        }
        /// <summary>
        /// Tells the user to enter a number.
        /// </summary>
        public void DisplayIncorrectNumberInput()
        {
            Console.WriteLine("\nInvalid input, please enter a number\n");
        }
        /// <summary>
        /// Asks if the user wants to continue with a process.
        /// </summary>
        /// <returns>If the user wants to continue or not.</returns>
        public bool UserWantsToContinue()
        {
            Console.Write("Do you want to continue (Y/N)? ");
            var readLine = Console.ReadLine();

            while (readLine == null)
            {
                Console.WriteLine("No input received. Try again.");
                Console.Write("Do you want to continue (Y/N)? ");
                readLine = Console.ReadLine();
            }

            var toContinue = readLine.Trim().ToUpper()[0];
            Console.WriteLine();

            switch (toContinue)
            {
                case 'Y':
                    return true;
                default:
                    return false;
            }
        }
        /// <summary>
        /// Ask the user if they want to continue given a fee.
        /// </summary>
        /// <param name="fee">The amount of the fee of the operation.</param>
        /// <returns>If the user wants to continue or not.</returns>
        public bool UserWantsToContinue(decimal fee)
        {
            Console.Write("A " + fee.ToString("c", CultureInfo.CreateSpecificCulture("en-US"))
                          + " fee will be charged. Do you want to continue (Y/N)? ");
            var readLine = Console.ReadLine();

            while (readLine == null)
            {
                Console.WriteLine("No input received. Try again.");
                Console.Write("Do you want to continue (Y/N)? ");
                readLine = Console.ReadLine();
            }

            var toContinue = readLine.Trim().ToUpper()[0];
            Console.WriteLine();
            switch (toContinue)
            {
                case 'Y':
                    return true;
                default:
                    return false;
            }
        }
        /// <summary>
        /// Displays the user the account menu options.
        /// </summary>
        /// <param name="cash">The cash balance of the account.</param>
        /// <returns>The user's selection of menu options.</returns>
        public int AskForUserSelectionOfMainMenu(decimal cash)
        {
            Console.Clear();
            Console.Write("Investment Account\n"
                          + "Cash Available: " + cash.ToString("c") + "\n"
                          + "1) Add Funds\n"
                          + "2) Withdraw Funds\n"
                          + "3) Account Balance\n"
                          + "4) Cash and Positions Balance\n"
                          + "5) Gains/Losses Report\n"
                          + "6) Add New Portfolio\n"
                          + "7) Select a Portfolio\n"
                          + "8) Simulate\n"
                          + "9) Exit\n"
                          + "Please select an option: ");
          
               return Convert.ToInt32(Console.ReadLine());  
        }
        /// <summary>
        /// Displays to the user the portfolio menu options.
        /// </summary>
        /// <param name="portfolioName">The name of the portolio selected.</param>
        /// <param name="cash">THe account cash balance.</param>
        /// <returns>The number of the user's selected option.</returns>
        public int AskForUserSelectionOfPortfolio(string portfolioName, decimal cash)
        {
            Console.Clear();
            Console.Write("\nPortfolio: " + portfolioName + "\n"
                          + "Cash Available: " + cash.ToString("C") + "\n"
                          + "1) Buy Stock\n"
                          + "2) Sell Stock\n"
                          + "3) Portfolio Balance\n"
                          + "4) Positions Balance\n"
                          + "5) Gains/Losses Report\n"
                          + "6) Delete Portfolio\n"
                          + "7) Back to Account\n"
                          + "Please select an option: ");
           
                return Convert.ToInt32(Console.ReadLine());
        }
        /// <summary>
        /// Asks for the user to input the money they would like to deposit.
        /// </summary>
        /// <returns>A string  of the amount of money to be handled by controller.</returns>
        public string AskForFundsToAdd()
        {
            Console.Write("\nEnter the amount of money you would like to deposit: ");
            return Console.ReadLine();
        }
        /// <summary>
        /// Tells the user the amount of money entered was smaller than the transaction fee.
        /// </summary>
        public void DisplayDepositTooSmall()
        {
            Console.WriteLine("\nThe amount of money you would like to enter is smaller than the transaction fee, so no money will be placed in your account.\n");
        }
        /// <summary>
        /// Asks for the user to input the money they would like to withdraw.
        /// </summary>
        /// <returns>A string of the amount of money to be handled by controller.</returns>
        public string AskForFundsToWithdraw()
        {
            Console.Write("\nEnter the amount of money you would like to withdraw: ");
            return Console.ReadLine();
        }
        /// <summary>
        /// Asks the user for the number of shares.
        /// </summary>
        /// <returns>The number of shares the user wants.</returns>
        public string AskForNumberOfShares()
        {
            Console.Write("\nEnter the number of shares: ");
            return Console.ReadLine();
        }
        /// <summary>
        /// Asks the user for the stock name.
        /// </summary>
        /// <returns>The name of the stock the user wants.</returns>
        public string AskForStockName()
        {
            Console.Write("\nEnter Ticker Name of the stock: ");
            var ticker = Console.ReadLine().Trim().ToUpper();
            return ticker;
        }
        /// <summary>
        /// This method lists the Ticker information
        /// </summary>
        public void DisplayListOfTickers()
        {
            Console.WriteLine("\t-----------------------List of Tickers--------------------------");
            foreach (var i in DataBase.PriceAndTickerName.Values)
            {
                Console.WriteLine("\t" + i.Item1 + "\t" + i.Item2.PadRight(45) + i.Item3.ToString("c").PadLeft(10));
            }
            Console.Write("\t----------------------------------------------------------------");
        }
        /// <summary>
        /// Asks the user for the name of the portfolio desired.
        /// </summary>
        /// <returns>The portfolio name the user wants.</returns>
        public string AskForPortfolioName()
        {
            Console.Write("\nEnter the name of the portfolio: ");
            return Console.ReadLine();
        }
        /// <summary>
        /// Displays to the user the portfolios in a numerical order, and returns the number
        /// that the user selects.
        /// </summary>
        /// <param name="names">A list of all the portfolio names.</param>
        /// <returns>An string of the number corresponding to the desired portfolio.</returns>
        public string DisplayPortfoliosAndAskForPortfolioNumber(List<string> names)
        {
            Console.WriteLine();
            for (var i = 0; i < names.Count; i++)
                Console.WriteLine((i + 1) + ") " + names[i]);
            Console.Write("Enter the number of the portfolio desired: ");
            return Console.ReadLine();
        }

        /// <summary>
        /// Displays the account balance.
        /// </summary>
        /// <param name="balance">A tuple of cash balance, invested balance, and total.</param>
        public void DisplayAccountBalance(Tuple<decimal, decimal, decimal> balance)
        {
            Console.WriteLine("\nCash balance: " + balance.Item1.ToString("c", CultureInfo.CreateSpecificCulture("en-US"))
                  + "\nInvested balance: " + balance.Item2.ToString("c", CultureInfo.CreateSpecificCulture("en-US"))
                  + "\nTOTAL Account Balance: " +
                  balance.Item3.ToString("c", CultureInfo.CreateSpecificCulture("en-US"))+"\n");
        }
        /// <summary>
        /// Displays the gains/losses report.
        /// </summary>
        /// <param name="output">THe amount of money gained or lost.</param>
        public void DisplayGainsAndLossesReport(decimal output)
        {
            if (output >= 0)
                Console.Write("\nYou have GAINED " + output.ToString("c", CultureInfo.CreateSpecificCulture("en-US")));
            else
                Console.Write("\nYou have LOST " + output.ToString("c", CultureInfo.CreateSpecificCulture("en-US")));
            Console.WriteLine("\n");
        }
        /// <summary>
        /// Displays the cash and positions balance of the account.
        /// </summary>
        /// <param name="cash">The total value of all the stocks at current market price if sold right now.</param>
        /// <param name="list">A list of the info about the stocks.</param>
        public void DisplayCashAndPositionsBalance(decimal cash, List<Tuple<string, string, decimal, int, decimal, double>> list)
        {
            Console.WriteLine("\nNet worth of all your stocks at the current prices: " + cash.ToString("c"));
            DisplayPositionsBalance(list);
        }
        /// <summary>
        /// Displays the position information.
        /// </summary>
        /// <param name="list">A list of the positions info, such as amount invested, percent, ticker name and full name.</param>
        public void DisplayPositionsBalance(List<Tuple<string, string, decimal, int, decimal, double>> list)
        {
            Console.WriteLine("\nPositions balance:");
            Console.WriteLine("Ticker".PadRight(10) + "Full".PadRight(30) + "Current Price".PadRight(20).PadLeft(10) + "#".PadRight(20).PadLeft(10) + "Value".PadRight(20).PadLeft(10) + "(Percent)".PadLeft(10));
            if (list.Count > 0)
            {
                foreach (var t in list)
                {
                    Console.WriteLine(t.Item1.PadRight(10) + t.Item2.PadRight(30) + t.Item3.ToString("C").PadRight(20).PadLeft(10) + t.Item4 + "".PadRight(20).PadLeft(10) + t.Item5.ToString("c").PadRight(20).PadLeft(10) + "(" + t.Item6.ToString("P") + ")");

                }
            }
            else
            {
                Console.WriteLine("You currently have no stocks in your account!\n");
            }
        }
        /// <summary>
        /// Displays the portfolio balance, which is the total net worth of the portfolio and the percent of the account it is.
        /// </summary>
        /// <param name="portfolioBalanceTuple">A tuple of the portfolio balance informatio.</param>
        public void DisplayPortfolioBalance(Tuple<string, decimal, decimal> portfolioBalanceTuple)
        {
            Console.WriteLine("\n" + portfolioBalanceTuple.Item1
                            + "\nTotal investment: " + portfolioBalanceTuple.Item2.ToString("c", CultureInfo.CreateSpecificCulture("en-US"))
                            + "\nPercentage of Account: " + portfolioBalanceTuple.Item3.ToString("P"));
        }

        /// <summary>
        /// Displays how much money was added to cash.
        /// </summary>
        /// <param name="cash">The amount of money deposited.</param>
        public void DisplayFundsWereAdded(decimal cash)
        {
            Console.WriteLine((cash).ToString("c", CultureInfo.CreateSpecificCulture("en-US")) +
                              " was depostied into your account\n");
        }
        /// <summary>
        /// Displays how much money was withdrawn from cash.
        /// </summary>
        /// <param name="withdrawl">THe amount of money withdrawn.</param>
        public void DisplayFundsWereWithdrawn(decimal withdrawl)
        {
            Console.WriteLine((withdrawl).ToString("c", CultureInfo.CreateSpecificCulture("en-US")) +
                              " was withdrawn from your account\n");
        }
        /// <summary>
        /// Asks the user to input the desired market volatility, and returns their choice.
        /// </summary>
        /// <returns>A string describing the market volatility, 1 for high and 3 for low.</returns>
        public string AskForMarketVolatility()
        {
            Console.Write("\n1) high-volatility\n"
                        + "2) medium-volatility\n"
                        + "3) low-volatility\n"
                        + "Select the volatility of the market: ");
            return Console.ReadLine();
        }
        /// <summary>
        /// Asks the user how they would like to purchase stocks.
        /// </summary>
        /// <returns>An int describing if 1) they want to go by shares or 
        /// 2) they want to input a dollar amount.</returns>
        public int AskForWayOfPurchasingStocks()
        {
            Console.Write("Input Method\n"
                       + "1) Number of stocks\n"
                       + "2) Dollar amount\n"
                       + "(Note: Ticker501 will round dollar amount down to the next whole number of stocks)\n"
                       + "Select a method of buying: "); ;
            var readLine = Console.ReadLine();
            while (readLine != "1" && readLine != "2")
            {
                Console.WriteLine("\nIncorrect input. Try again. ");
                Console.Write("Input Method\n"
                       + "1) Number of stocks\n"
                       + "2) Dollar amount\n"
                       + "(Note: Ticker501 will round dollar amount down to the next whole number of stocks)\n"
                       + "Select a method of buying: ");
                readLine = Console.ReadLine();
            }
            return Convert.ToInt32(readLine);
        }
        /// <summary>
        /// Asks the user to input the dollar amount they would like to purchase.
        /// </summary>
        /// <returns>The price they would like to purchase as a string.</returns>
        public string AskForDollars()
        {
            Console.Write("Enter the $ amount you would like to purchase: ");
            return Console.ReadLine();
        }
        /// <summary>
        /// Displays to the user that a stock was purchased.
        /// </summary>
        /// <param name="shares">The number of shares.</param>
        /// <param name="cash">The price of the shares.</param>
        /// <param name="tickerName">The stock ticker name.</param>
        public void DisplayStockWasPurchased(int shares, decimal cash, string tickerName)
        {
            decimal altogether = Convert.ToDecimal(9.99);
            altogether += shares * cash;
            Console.WriteLine(shares + " shares of " + tickerName + " stock were bought for "
                            + (altogether ).ToString("c"));
        }
        /// <summary>
        /// Displays to the user that shares were sold.
        /// </summary>
        /// <param name="shares">The number of shares.</param>
        /// <param name="cash">The price of the shares.</param>
        /// <param name="tickerName">The stock ticker name.</param>
        public void DisplayStockWasSold(int shares, decimal cash, string tickerName)
        {
            Console.WriteLine(shares + " shares of " + tickerName + " stock were sold for "
                                        + (cash * shares).ToString("c"));
        }
        /// <summary>
        /// Waits for user to press enter before continuing.
        /// </summary>
        public void WaitForUserToPressEnter()
        {
            Console.Write("Press enter to continue...");
            Console.ReadLine();
        }
        /// <summary>
        /// Displays that the simulation of the market was a success.
        /// </summary>
        /// <param name="volatility">Tells which type of volatility was selected, high for 1 or 3 for low.</param>
        public void DisplayMarketVolatilitySuccess(int volatility)
        {
            if (volatility == 1)
                Console.WriteLine("Simulated high market volatility. ");
            else if (volatility == 2)
                Console.WriteLine("Simulated medium market volatility. ");
            else if (volatility == 3)
                Console.WriteLine("Simualated low market volatiltiy. ");
            else
                Console.WriteLine("Error with simulation. ");
        }
        /// <summary>
        /// Displays the stock information, such as ticker name, full name, and price.
        /// </summary>
        /// <param name="tickerName">THe ticker name.</param>
        public void DisplayStockInfo(string tickerName, string fullName, decimal price)
        {
            Console.WriteLine("\n" + tickerName + " - " + fullName + " - " + price.ToString("c") + "\n");
        }
        /// <summary>
        /// Displays the total market value of a portfolio.
        /// </summary>
        /// <param name="totalValue">The total market value.</param>
        public void DisplayPortolioValue(decimal totalValue)
        {
            Console.WriteLine("\nThis portfolio is currently worth " + totalValue.ToString("c") + "\n");
        }
        /// <summary>
        /// Displays to the user that the portfolio was deleted and the total value of that portfolio.
        /// </summary>
        /// <param name="portfolioName">The portfolio name.</param>
        /// <param name="totalValue">The total value of the portfolio.</param>
        public void DisplayPortfolioWasDeleted(string portfolioName, decimal totalValue)
        {
            Console.WriteLine("\nPortfolio " + portfolioName + " was deleted and cashed out a total of " + totalValue.ToString("c"));
        }
    }
}
