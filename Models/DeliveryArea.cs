using MiniMarket.Context;
using System.Linq;

namespace MiniMarket.Models
{
    public class DeliveryArea
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public byte[] Image { get; set; }
        public string MIMEType { get; set; }

        public string GetAreaNameFromId(int id, DeliveryAreaContext deliveryAreaContext)
        {
            var area = deliveryAreaContext.DeliveryAreas.FirstOrDefault(x => x.Id == id);
            return area?.Name;
        }
    }
}
