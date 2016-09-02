using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public partial class CATALOGO
    {
        private static MODELO.CATALOGO instancia;
        public static MODELO.CATALOGO obtener_instancia()
        {
            if (instancia == null)
                instancia = new CATALOGO();

            return instancia;
        }
    }
}
