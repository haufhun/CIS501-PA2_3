﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticker501_MVC.Model
{
    public interface IStock
    {
       decimal InvestedBalance { get; set; }

       int NumberOfShares { get; set; }

    }
}