//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MODELO
{
    using System;
    using System.Collections.Generic;
    
    public partial class GRUPO
    {
        public GRUPO()
        {
            this.USUARIO = new HashSet<USUARIO>();
            this.ACCION = new HashSet<ACCION>();
        }
    
        public int CODIGO { get; set; }
        public string DESCRIPCION { get; set; }
        public bool ACTIVO { get; set; }
    
        public virtual ICollection<USUARIO> USUARIO { get; set; }
        public virtual ICollection<ACCION> ACCION { get; set; }
    }
}
