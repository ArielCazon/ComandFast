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
    
    public partial class Usuario
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Usuario()
        {
            this.Opiniones = new HashSet<Opiniones>();
            this.Usuario_Pedido = new HashSet<Usuario_Pedido>();
        }
    
        public long Id_Usuario { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public System.DateTime Fecha_Nac { get; set; }
        public string Login_Usuario { get; set; }
        public string Pass { get; set; }
        public int Id_Tipo_Usuario { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Opiniones> Opiniones { get; set; }
        public virtual Tipo_Usuario Tipo_Usuario { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Usuario_Pedido> Usuario_Pedido { get; set; }
    }
}
