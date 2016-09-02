using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    [System.AttributeUsage(System.AttributeTargets.Class |
                  System.AttributeTargets.Struct,
                  AllowMultiple = true)  // multiuse attribute
]
    public class accion : System.Attribute
    {
        public string DESCRIPCION { get; set; }
        public string CONTROL { get; set; }
        public string FORMULARIO { get; set; }
    }

    public class formulario : System.Attribute
    {
        public string DESCRIPCION { get; set; }
        public string CLASE { get; set; }
        public string MODULO { get; set; }
        public string SUBMODULO { get; set; }
        public bool MENU { get; set; }
    }


}
