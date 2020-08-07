using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SNWebServices.Models
{
    public class Stock
    {
        public string StockCode { get; set; }
        public double Amount { get; set; }
        public string Status { get; set; }
    }
}