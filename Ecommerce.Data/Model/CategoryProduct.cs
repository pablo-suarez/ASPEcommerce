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
    
    public partial class CategoryProduct
    {
        public int IdCategoryProduct { get; set; }
        public int IdProduct { get; set; }
        public int IdCategory { get; set; }
    
        public virtual Category Category { get; set; }
        public virtual Product Product { get; set; }
    }
}
