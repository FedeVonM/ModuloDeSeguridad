using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORA
{
    public class cPASSWORD
    {
        private static cPASSWORD instancia;
        private MODELO.CATALOGO oCATALOGO;
        public static cPASSWORD obtenerInstancia()
        {
            if (instancia == null)
                instancia = new cPASSWORD();

            return instancia;
        }
        private cPASSWORD()
        {
            oCATALOGO = MODELO.CATALOGO.obtener_instancia();
        }

        public void MODIFICACION(MODELO.USUARIO oUSUARIO)
        {
            oCATALOGO.Entry(oUSUARIO).State = System.Data.Entity.EntityState.Modified;
            oCATALOGO.SaveChanges();
        }

        public MODELO.USUARIO OBTENER_USUARIO(string EMAIL)
        {
            return oCATALOGO.USUARIOS.FirstOrDefault(u => u.EMAIL.ToLower() == EMAIL.ToLower());
        }

    }
}
