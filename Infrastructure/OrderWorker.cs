using MiniMarket.Models;

namespace MiniMarket.Infrastructure
{
    public class OrderWorker
    {
        public decimal Summary(Order order)
        {
            decimal summ = 0;
            if (order != null)
            {
                foreach (var item in order.Items)
                    summ += item.Count * item.Product.Price;
            }
            return summ;
        }
    }
}
