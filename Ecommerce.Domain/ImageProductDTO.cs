using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Domain
{
    class ImageProductDTO
    {
        public int IdImageProduct { get; set; }
        public int IdProduct { get; set; }
        public string Url { get; set; }
        public bool IsCover { get; set; }
    }
}
