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
    
    public partial class Opiniones
    {
        public long Id_Calificacion { get; set; }
        public short Puntaje { get; set; }
        public string Descripcion { get; set; }
        public long Id_Usuario { get; set; }
    
        public virtual Usuario Usuario { get; set; }
    }
}