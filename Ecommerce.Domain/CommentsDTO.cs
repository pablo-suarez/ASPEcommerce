using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Domain
{
    class CommentsDTO
    {
        public int IdClient { get; set; }
        public string Dni { get; set; }
        public string Names { get; set; }
        public string LastNames { get; set; }
        public string Address { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public System.DateTime BirthDate { get; set; }
    }
}
