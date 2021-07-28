using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONChallenge
{
    public class PurchaseItem
    {
        public string OrderId { get; set; }
        public CustomerInfo Customer { get; set; }
        public List<Items> LineItems { get; set; }
        public DateTime PurchaseDate { get; set; }
    }
}
