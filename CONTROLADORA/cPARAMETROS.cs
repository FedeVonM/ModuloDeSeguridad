using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORA
{
    public class cPARAMETROS
    {
        private static cPARAMETROS instancia;
        public static cPARAMETROS obtener_instancia()
        {
            if (instancia == null)
                instancia = new cPARAMETROS();
            return instancia;
        }

        MODELO.CATALOGO oCATALOGO;
        private cPARAMETROS()
        {
            oCATALOGO = MODELO.CATALOGO.obtener_instancia();
        }

        public System.Collections.IEnumerable OBTENER_PARAMETROS(string EQUIPO)
        {
            var parametros = from parametro in oCATALOGO.PARAMETROS
                             where parametro.NOMBRE_EQUIPO.Contains(EQUIPO)
                             select new { ID = parametro.ID, EQUIPO = parametro.NOMBRE_EQUIPO, IMAGENES= parametro.DIRECTORIO_IMAGENES, EMAIL=parametro.ENVIO_MAILS};
            return parametros.ToList();
        }

        public MODELO.PARAMETRO OBTENER_PARAMETRO(int CODIGO)
        {
            return oCATALOGO.PARAMETROS.Find(CODIGO);
        }

        public void MODIFICAR_PARAMETRO(MODELO.PARAMETRO oPARAMETRO)
        {
            oCATALOGO.Entry(oPARAMETRO).State = System.Data.Entity.EntityState.Modified;
            oCATALOGO.SaveChanges();
        }
    }
}
