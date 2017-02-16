using System;
using System.Collections.Generic;
using System.IO;

namespace Class_Library
{
    /// <summary>
    /// The database class holding the price and ticker information.
    /// </summary>
    public static class DataBase
    {
        /// <summary>
        /// Dictionary holding the price and ticker name info.
        /// </summary>
        private static Dictionary<string, Tuple<string, string, decimal>> _priceAndTickerName = new Dictionary<string, Tuple<string, string, decimal>>();

        /// <summary>
        /// Public property allowing the get of the price and ticker info dictioanry.
        /// </summary>
        public static Dictionary<string, Tuple<string, string, decimal>> PriceAndTickerName => _priceAndTickerName;

        /// <summary>
        /// Gets info from a file, given a streamreader.
        /// </summary>
        /// <param name="input">A stream allowing the reading of the database file.</param>
        public static void GetInfoFromFile(StreamReader input)
        {
            using (input)
            {
                while (!input.EndOfStream)
                {
                    var split = GetLineFromFile(input);
                    if (split != null)
                        AddToDatabase(split[0], split[1], Convert.ToDecimal(split[2]));
                }
            }
        }
        /// <summary>
        /// Gets a line from the file and validates it is correct.
        /// </summary>
        /// <param name="input">The stream to read from.</param>
        /// <returns>The string of the sanitzed data.</returns>
        private static string[] GetLineFromFile(StreamReader input)
        {
            var inputLine = input.ReadLine();

            if (inputLine.Trim().Length <= 5) return null;
            var split = inputLine.Split('-');
            SanitizeData(split);
            return split;
        }

        /// <summary>
        /// Sanitizes data from the file to what is desired.
        /// </summary>
        /// <param name="split">The list of the strings split from the file.</param>
        private static void SanitizeData(IList<string> split)
        {
            split[0] = split[0].Trim().ToUpper();
            split[2] = split[2].Substring(1);
        }
        /// <summary>
        /// Add a given ticker to the database.
        /// </summary>
        /// <param name="tickerName">The ticker name.</param>
        /// <param name="fullName">The full name of the stock.</param>
        /// <param name="sharePrice">The current price of the stock.</param>
        private static void AddToDatabase(string tickerName, string fullName, decimal sharePrice)
        {
            if (!PriceAndTickerName.ContainsKey(tickerName))
                PriceAndTickerName.Add(tickerName, new Tuple<string, string, decimal>(tickerName, fullName, sharePrice));
            else
                PriceAndTickerName[tickerName] = new Tuple<string, string, decimal>(tickerName, fullName, sharePrice);
        }

        /// <summary>
        /// Sets the database to a new dictionary that is updated after a simulation.
        /// </summary>
        /// <param name="newDb">The dictionary holding the new values of the stock prices.</param>
        public static void SetNewDictionary(Dictionary<string, Tuple<string, string, decimal>> newDb)
        {
            _priceAndTickerName = newDb;
        }
    }
}