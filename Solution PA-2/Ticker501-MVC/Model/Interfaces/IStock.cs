namespace Ticker501_MVC.Model.Interfaces
{
    public interface IStock
    {
       /// <summary>
       /// This gets and sets the invested balance for the stock.
       /// </summary>
       decimal InvestedBalance { get; set; }

       /// <summary>
       /// This gets and sets the number of shares for the stock.
       /// </summary>
       int NumberOfShares { get; set; }

       /// <summary>
       /// This gets the name of the stock.
       /// </summary>
       string Name { get; }
    }
}

