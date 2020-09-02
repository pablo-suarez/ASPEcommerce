using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Domain
{
    class BillDTO
    {
        public int IdBill { get; set; }
        public int Number { get; set; }
        public int IdClient { get; set; }
        public System.DateTime Date { get; set; }
        public int IdPayWay { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Iva { get; set; }
        public decimal Discount { get; set; }
        public decimal Total { get; set; }
        public bool State { get; set; }

    }
}
