using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Domain
{
    class BillDetailDTO
    {
        public int IdBillDetails { get; set; }
        public int IdBill { get; set; }
        public int IdProduct { get; set; }
        public int Quantity { get; set; }
        public decimal SinglePrice { get; set; }

    }
}
