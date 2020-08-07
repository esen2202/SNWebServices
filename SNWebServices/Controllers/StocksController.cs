using SNWebServices.Helpers;
using SNWebServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Web.Http;

namespace SNWebServices.Controllers
{
    public class StocksController : ApiController
    {
        public IHttpActionResult getStocks()
        {
            List<Stock> stocks = new List<Stock>
            {
                new Stock{StockCode="abc",Amount=32,Status="durum"},
                new Stock{StockCode="yeni",Amount=2,Status="durum"},
                new Stock{StockCode="as",Amount=0,Status="durum"},
                new Stock{StockCode="gg",Amount=45,Status="durum"},
                new Stock{StockCode="abwec",Amount=5,Status="durum"},
            };

            Process<List<Stock>> result = new Process<List<Stock>>()
            {
                Action = "getStocks",
                Controller = "Stocks",
                Error = false,
                Message = "",
                Result = stocks.ToList()
            };

            return Ok(result);
        }

    }
}
