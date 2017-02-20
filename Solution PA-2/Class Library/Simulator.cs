using System;
using System.Collections.Generic;

namespace Class_Library
{
    /// <summary>
    /// A simulator class that simulates a stock market by incrementing/decrementing the price of all stocks in the database.
    /// </summary>
    public static class Simulator
    {
        /// <summary>
        /// A random variable used to create random numbers.
        /// </summary>
        private static readonly Random RandomPercent = new Random();

        /// <summary>
        /// Simulates high volatility by allowing a 3 to 15 percent increment/decrement of the current price.
        /// </summary>
        public static void SimulateHighVolatility()
        {
            var newDb = new Dictionary<string, Tuple<string, string, decimal>>();
            foreach (var t in DataBase.PriceAndTickerName.Values)
            {
                var randomPercent = RandomPercent.Next(-15, 15);
                while (randomPercent > -3 && randomPercent < 3)
                    randomPercent = RandomPercent.Next(-15, 15);
                decimal change = t.Item3 * randomPercent * .01m;
                newDb.Add(t.Item1, new Tuple<string, string, decimal>(t.Item1, t.Item2, t.Item3 - change));
            }
            DataBase.SetNewDictionary(newDb);
        }
        /// <summary>
        /// Simulates high volatility by allowing a 2 to 8 percent increment/decrement of the current price.
        /// </summary>
        public static void SimulateMediumVolatility()
        {
            var newDb = new Dictionary<string, Tuple<string, string, decimal>>();
            foreach (var t in DataBase.PriceAndTickerName.Values)
            {
                var randomPercent = RandomPercent.Next(-8, 8);
                while (randomPercent > -2 && randomPercent < 2)
                    randomPercent = RandomPercent.Next(-8, 8);
                decimal change = t.Item3 * randomPercent * .01m;
                newDb.Add(t.Item1, new Tuple<string, string, decimal>(t.Item1, t.Item2, t.Item3- change));
            }
            DataBase.SetNewDictionary(newDb);
        }
        /// <summary>
        /// Simulates high volatility by allowing a 1 to 4 percent increment/decrement of the current price.
        /// </summary>
        public static void SimulateLowVolatility()
        {
            var newDb = new Dictionary<string, Tuple<string, string, decimal>>();
            foreach (var t in DataBase.PriceAndTickerName.Values)
            {
                var randomPercent = RandomPercent.Next(-4, 4);
                while (randomPercent == 0)
                    randomPercent = RandomPercent.Next(-4, 4);
                decimal change = t.Item3 * randomPercent * .01m;
                newDb.Add(t.Item1, new Tuple<string, string, decimal>(t.Item1, t.Item2, t.Item3 - change));
            }
            DataBase.SetNewDictionary(newDb);
        }
    }
}
