namespace Class_Library
{
    /// <summary>
    /// A structure that contains the number of shares and the price they were bought at.s
    /// </summary>
    public class Stock
    {
        public readonly string TickerName;
        /// <summary>
        /// Private field that holds the amount that has been invested in this stock.
        /// </summary>
        private decimal _totalInvested;
        /// <summary>
        /// The total number of shares.
        /// </summary>
        private int _totalNumberOfShares;

        /// <summary>
        /// Returns the total balance of the amount in the stock
        /// </summary>
        public decimal TotalInvested => _totalInvested;
        /// <summary>
        /// The total number of shares.
        /// </summary>
        public int TotalNumberOfShares => _totalNumberOfShares;

        /// <summary>
        /// Initializes a new Stock object, adds the value to the TotalInvested field, and adds
        /// buyPrice and numberOfShares to the dictionary.
        /// </summary>
        /// <param name="tickerName">The name of the ticker.</param>
        /// <param name="buyPrice">The price the stock was boughten at.</param>
        /// <param name="numberOfShares">The number of shares that were bought at that price.</param>
        public Stock(string tickerName, decimal buyPrice, int numberOfShares)
        {
            TickerName = tickerName;
            AddMoreShares(buyPrice, numberOfShares);
        }
        /// <summary>
        /// Adds more shares at the price they were boughten at to the dictionary, 
        /// of if they are the same buy price, adds more shares to that price.
        /// </summary>
        /// <param name="buyPrice">The price the shares were bought at.</param>
        /// <param name="numberOfShares">The number of shares bought.</param>
        public void AddMoreShares(decimal buyPrice, int numberOfShares)
        {
            _totalNumberOfShares += numberOfShares;
            _totalInvested += numberOfShares * buyPrice;
        }
        /// <summary>
        /// Sells a certain number of shares of this stock.
        /// </summary>
        /// <param name="numberOfShares">The number of shares.</param>
        /// <returns>The invested value of the shares being sold.</returns>
        public decimal SellNumberOfShares(int numberOfShares)
        {
            if (numberOfShares > _totalNumberOfShares)
                numberOfShares = _totalNumberOfShares;

            var price = numberOfShares * DataBase.PriceAndTickerName[TickerName].Item3;
            _totalInvested -= price;
            _totalNumberOfShares -= numberOfShares;

            return price;
        }
        /// <summary>
        /// Gets the current market value of this stock for all the shares.
        /// </summary>
        /// <returns>The current market value of this stock.</returns>
        public decimal GetCurrentMarketValue()
        {
            return _totalNumberOfShares * DataBase.PriceAndTickerName[TickerName].Item3;
        }
    }
}