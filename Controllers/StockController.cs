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
        public FileContentResult GetStockImage(int Id)
        {
            using (StockContext context = new StockContext())
            {
                var stock = context.Stocks.FirstOrDefault(x => x.Id == Id);
                if (stock != null)
                    return File(stock.Image, stock.MIMEType);
            }
            return null;
        }
    }
}