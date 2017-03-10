using Ticker501_MVC.Model.Interfaces;

namespace Ticker501_MVC.Model
{
    public class Stock : IStock
    {
        /// <summary>
        /// This gets and sets the invested balance public variable.
        /// </summary>
        public decimal InvestedBalance { get; set; }
        /// <summary>
        /// This gets and sets the number of shares public variable.
        /// </summary>
        public int NumberOfShares { get; set; }
        /// <summary>
        /// This gets the name for the stock.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// This method initializes the values for the Stock information.
        /// </summary>
        /// <param name="name">The name of the Stock.</param>
        public Stock(string name)
        {
            this.Name = name;
            NumberOfShares = 0;
            InvestedBalance = 0m;
        }
    }
}
