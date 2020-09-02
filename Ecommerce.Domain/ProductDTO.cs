using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Domain
{
    public class ProductDTO
    {
        public int IdProduct { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public short Stock { get; set; }
        public string Description { get; set; }
        public string Reference { get; set; }   
    }
}
