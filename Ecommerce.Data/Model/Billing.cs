//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ecommerce.Data.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Billing
    {
        public int IdBilling { get; set; }
        public int IdBill { get; set; }
        public string Dni { get; set; }
        public string Names { get; set; }
        public string LastNames { get; set; }
        public string Telephone { get; set; }
        public string Address { get; set; }
    
        public virtual Bill Bill { get; set; }
    }
}
