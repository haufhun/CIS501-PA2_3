using Ticker501_MVC.Model.Interfaces;

namespace Ticker501_MVC.Model
{
    public class Stock : IStock
    {
        public decimal InvestedBalance { get; set; }
        public int NumberOfShares { get; set; }
        public string Name { get; }

        public Stock(string name)
        {
            this.Name = name;
            NumberOfShares = 0;
            InvestedBalance = 0m;
        }
    }
}
