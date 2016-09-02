using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORA
{
    public class cUSUARIOS
    {
        private static cUSUARIOS instancia;
        public static cUSUARIOS obtener_instancia()
        {
            if (instancia == null)
                instancia = new cUSUARIOS();
            return instancia;
        }

        MODELO.CATALOGO oCATALOGO;
        private cUSUARIOS()
        {
            oCATALOGO = MODELO.CATALOGO.obtener_instancia();
        }

        public System.Collections.IEnumerable OBTENER_USUARIOS(string nombre, MODELO.GRUPO grupo, bool inactivos)
        {
            var usuarios = from usuario in oCATALOGO.USUARIOS.ToList()
                           where usuario.NOMBRE.Contains(nombre) && (grupo != null ? usuario.GRUPO.Contains(grupo) : true)
                           select new {ID = usuario.CODIGO,USUARIO= usuario.NOMBRE_USUARIO, NOMBRE = usuario.NOMBRE, GRUPOS = usuario.GRUPOS_USUARIO, ACTIVO=usuario.ACTIVO};
            if (!inactivos)
                usuarios = usuarios.Where(usu => usu.ACTIVO == true);

            return usuarios.ToList();
        }
        
        public MODELO.USUARIO OBTENER_USUARIO (int codigo)
        {
            return oCATALOGO.USUARIOS.Find(codigo);
        }

        public bool VALIDA_NOMBRE_USUARIO(string nombre_usuario, int codigo_usuario)
        {
            MODELO.USUARIO oUSUARIO = oCATALOGO.USUARIOS.FirstOrDefault(u => (u.NOMBRE_USUARIO == nombre_usuario) && (u.CODIGO != codigo_usuario));
            if (oUSUARIO == null)
                return false;
            else
                return true;
        }

        public bool VALIDA_EMAIL_USUARIO(string email, int codigo_usuario)
        {
            MODELO.USUARIO oUSUARIO = oCATALOGO.USUARIOS.FirstOrDefault(u => (u.EMAIL == email) && (u.CODIGO != codigo_usuario));
            if (oUSUARIO == null)
                return false;
            else
                return true;
        }

        public void AGREGAR_USUARIO(MODELO.USUARIO oUSUARIO)
        {
            oCATALOGO.USUARIOS.Add(oUSUARIO);
            oCATALOGO.SaveChanges();
        }

        public void MODIFICAR_USUARIO(MODELO.USUARIO oUSUARIO)
        {
            oCATALOGO.Entry(oUSUARIO).State = System.Data.Entity.EntityState.Modified;
            oCATALOGO.SaveChanges();
        }

        public void ELIMINAR_USUARIO(MODELO.USUARIO oUSUARIO)
        {
            oUSUARIO.ACTIVO = false;
            oCATALOGO.Entry(oUSUARIO).State = System.Data.Entity.EntityState.Modified;
            oCATALOGO.SaveChanges();
        }

        public void CANCELAR_CAMBIOS(MODELO.USUARIO oUSUARIO)
        {
            oCATALOGO.Entry(oUSUARIO).State = System.Data.Entity.EntityState.Detached;
        }

        public List<MODELO.GRUPO> OBTENER_GRUPOS()
        {
            var grupos = from grupo in oCATALOGO.GRUPOS
                         where grupo.ACTIVO == true
                         select grupo;

            return grupos.ToList();
        }
        
        }
}
