using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Domain
{
    class CategoryProductDTO
    {
        public int IdCategoryProduct { get; set; }
        public int IdProduct { get; set; }
        public int IdCategory { get; set; }
    }
}
