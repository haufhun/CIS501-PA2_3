using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticker501_MVC
{
    public class Account
    {
        /// <summary>
        /// The trade fee for buying/selling stocks.
        /// </summary>
        public const decimal TRADE_FEE = 9.99m;
        /// <summary>
        /// The transfer fee for depositing/withdrawing money.
        /// </summary>
        public const decimal TRANSFER_FEE = 4.99m;

        private decimal _cashBalance;

        private int _totalNumberofShares;

        public decimal CashBalance
        {
            get { return _cashBalance;}
            set { _cashBalance = value; }
        }

        public int TotalNumberOfShares
        {
            get { return _totalNumberofShares; }
            set { _totalNumberofShares = value; }
        }
    }
}
