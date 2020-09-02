using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Domain
{
    class QualificationDTO
    {
        public int IdQualification { get; set; }
        public int IdClient { get; set; }
        public int IdProduct { get; set; }
        public decimal Score { get; set; }

    }
}
