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
    
    public partial class ACCION
    {
        public ACCION()
        {
            this.GRUPO = new HashSet<GRUPO>();
        }
    
        public int CODIGO { get; set; }
        public string DESCRIPCION { get; set; }
        public string CONTROL { get; set; }
    
        public virtual FORMULARIO FORMULARIO { get; set; }
        public virtual ICollection<GRUPO> GRUPO { get; set; }
    }
}
