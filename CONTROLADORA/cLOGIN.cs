using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORA
{
    public class cLOGIN
    {
        MODELO.CATALOGO oCATALOGO;
        private static cLOGIN instancia;

        public static cLOGIN OBTENER_INSTANCIA()
        {
            if (instancia == null)
                instancia = new cLOGIN();
            return instancia;
        }
        private cLOGIN()
        {
            oCATALOGO = MODELO.CATALOGO.obtener_instancia();
        }
        public MODELO.USUARIO VALIDAR_USUARIO(string usuario, string password)
        {
            MODELO.USUARIO oUSUARIO = oCATALOGO.USUARIOS.FirstOrDefault(U => U.NOMBRE_USUARIO == usuario);
            if (oUSUARIO == null)
            {
                throw new Exception ("No se ha encontrado el usuario ingresado");
            }
            if (oUSUARIO.CLAVE != funciones_compartidas.EncriparClave(password))
            {
                throw new Exception("La contraseña ingresada es incorrecta");
            }
            if (!oUSUARIO.ACTIVO)
            {
                throw new Exception("El usuario actual se encuentra inactivo en el sistema, consulte al administrador");
            }
            return oUSUARIO;
        }

    }
}
