//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Web.data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Estado_Pedido
    {
        public long Id_Pedido { get; set; }
        public string Id_Estado { get; set; }
        public System.DateTime Fecha_Hora { get; set; }
    
        public virtual Estado Estado { get; set; }
        public virtual Pedido Pedido { get; set; }
    }
}
