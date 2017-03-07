namespace Ticker501_MVC.Model.Interfaces
{
    public interface IStock
    {
       decimal InvestedBalance { get; set; }

       int NumberOfShares { get; set; }

    }
}
