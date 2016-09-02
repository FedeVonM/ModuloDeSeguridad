using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORA
{
    public class cGRUPOS
    {
        private static cGRUPOS instancia;
        public static cGRUPOS obtener_instancia()
        {
            if (instancia == null)
                instancia = new cGRUPOS();
            return instancia;
        }

        MODELO.CATALOGO oCATALOGO;
        private cGRUPOS()
        {
            oCATALOGO = MODELO.CATALOGO.obtener_instancia();
        }

        public System.Collections.IEnumerable OBTENER_GRUPOS(string DESCRIPCION, bool INACTIVOS)
        {
            var grupos = from grupo in oCATALOGO.GRUPOS.ToList()
                         where grupo.DESCRIPCION.Contains(DESCRIPCION)
                         select new { GRUPO = grupo.CODIGO, DESCRIPCION = grupo.DESCRIPCION, USUARIOS = grupo.USUARIO.Count, ACTIVO = grupo.ACTIVO };
            if (INACTIVOS == false)
            {
                grupos = grupos.Where(gr => gr.ACTIVO == true);
            }

            return grupos.ToList();
        }

        public MODELO.GRUPO OBTENER_GRUPO(Int32 CODIGO)
        {
            return oCATALOGO.GRUPOS.Find(CODIGO);
        }

        public void AGREGAR_GRUPO(MODELO.GRUPO oGRUPO)
        {
            oCATALOGO.GRUPOS.Add(oGRUPO);
            oCATALOGO.SaveChanges();
        }
        public void MODIFICAR_GRUPO(MODELO.GRUPO oGRUPO)
        {
            oCATALOGO.Entry(oGRUPO).State = System.Data.Entity.EntityState.Modified;
            oCATALOGO.SaveChanges();
        }
        public void CANCELAR_CAMBIOS(MODELO.GRUPO oGRUPO)
        {
            oCATALOGO.Entry(oGRUPO).State = System.Data.Entity.EntityState.Detached;
        }
        public void ELIMINAR_GRUPO(MODELO.GRUPO oGRUPO)
        {
            if (oGRUPO.USUARIO.Count > 0)
            {
                oGRUPO.ACTIVO = false;
                oCATALOGO.Entry(oGRUPO).State = System.Data.Entity.EntityState.Modified;
            }
            else
            {
                oCATALOGO.GRUPOS.Remove(oGRUPO);
            }
            oCATALOGO.SaveChanges();
        }

        public List<MODELO.USUARIO> OBTENER_USUARIOS()
        {
            return oCATALOGO.USUARIOS.ToList();
        }

        public List<MODELO.MODULO> OBTENER_MODULOS()
        {
            return oCATALOGO.MODULOS.ToList();
        }
    }
}
