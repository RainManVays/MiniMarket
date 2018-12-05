using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MiniMarket.Context;

namespace MiniMarket.Controllers
{
    public class StockController : Controller
    {
        StockContext _stockContext;
        public StockController(StockContext stockContext)
        {
            _stockContext = stockContext;
        }

        public FileContentResult GetStockImage(int Id)
        {
                var stock = _stockContext.Stocks.FirstOrDefault(x => x.Id == Id);
                if (stock != null)
                    return File(stock.Image, stock.MIMEType);
            return null;
        }
    }
}