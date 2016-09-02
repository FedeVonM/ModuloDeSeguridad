using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.IO;

namespace CONTROLADORA
{
    public class cINICIO
    {
        MODELO.CATALOGO oCATALOGO;
        private static cINICIO instancia;

        public static cINICIO OBTENER_INSTANCIA()
        {
            if (instancia == null)
                instancia = new cINICIO();
            return instancia;
        }
        private cINICIO()
        {
            oCATALOGO = MODELO.CATALOGO.obtener_instancia();
        }

        public void INICIA_USUARIOS()
        {
            if (oCATALOGO.GRUPOS.Count() == 0)
            {
                MODELO.GRUPO oGRUPO = new MODELO.GRUPO();
                oGRUPO.DESCRIPCION = "SUPERUSUARIOS";
                oGRUPO.ACTIVO = true;
                oCATALOGO.GRUPOS.Add(oGRUPO);

                MODELO.USUARIO oUSUARIO = new MODELO.USUARIO();
                oUSUARIO.NOMBRE_USUARIO = "admin";
                oUSUARIO.NOMBRE = "Administrador";
                oUSUARIO.GRUPO.Add(oGRUPO);
                oUSUARIO.CLAVE = funciones_compartidas.EncriparClave("123123");
                oUSUARIO.EMAIL = "definir mail";
                oUSUARIO.TELEFONO = "definir telefono";
                oUSUARIO.ACTIVO = true;
                oUSUARIO.RESETEAR_CLAVE = false;
                oUSUARIO.IMAGEN = "272.png";
                oCATALOGO.USUARIOS.Add(oUSUARIO);

                oCATALOGO.SaveChanges();

            }
        }

        public void INICIA_PARAMETROS()
        {
            string NOMBRE_EQUIPO = Environment.MachineName;
            if (oCATALOGO.PARAMETROS.Count(p=>p.NOMBRE_EQUIPO == NOMBRE_EQUIPO) == 0)
            {
                String strAppDir = new Uri(Path.GetDirectoryName( Assembly.GetExecutingAssembly().GetName().CodeBase)).LocalPath;
                String strFullPathToMyFile = Path.Combine(strAppDir, "usuarios\\");                
                MODELO.PARAMETRO oPARAMETRO = new MODELO.PARAMETRO();
                oPARAMETRO.NOMBRE_EQUIPO = NOMBRE_EQUIPO;
                oPARAMETRO.ENVIO_MAILS = false;
                oPARAMETRO.DIRECTORIO_IMAGENES = strFullPathToMyFile;
                oPARAMETRO.MAIL_CLAVE = string.Empty;
                oPARAMETRO.MAIL_CUENTA = string.Empty;
                oPARAMETRO.MAIL_HOST = string.Empty;
                oPARAMETRO.MAIL_NOMBRE_REMITENTE = string.Empty;
                oPARAMETRO.MAIL_PORT = 0;
                oPARAMETRO.MAIL_SSL = false;
                oCATALOGO.PARAMETROS.Add(oPARAMETRO);
               
                try
                {
                    oCATALOGO.SaveChanges(); ;
                }
                catch (System.Data.Entity.Validation.DbEntityValidationException ex)
                {
                    // Retrieve the error messages as a list of strings.
                    var errorMessages = ex.EntityValidationErrors
                            .SelectMany(x => x.ValidationErrors)
                            .Select(x => x.ErrorMessage);

                    // Join the list to a single string.
                    var fullErrorMessage = string.Join("; ", errorMessages);

                    // Combine the original exception message with the new one.
                    var exceptionMessage = string.Concat(ex.Message, " The validation errors are: ", fullErrorMessage);

                    // Throw a new DbEntityValidationException with the improved exception message.
                    throw new System.Data.Entity.Validation.DbEntityValidationException(exceptionMessage, ex.EntityValidationErrors);
                }
            }
        }

        public void ACTUALIZA_MODULO(string nombre)
        {
            if (oCATALOGO.MODULOS.Count(m => m.DESCRIPCION == nombre) == 0)
            {
                MODELO.MODULO oMODULO = new MODELO.MODULO();
                oMODULO.DESCRIPCION = nombre;
                oCATALOGO.MODULOS.Add(oMODULO);
                oCATALOGO.SaveChanges();
            }
        }

        public void ACTUALIZA_FORMULARIOS(MODELO.formulario form)
        {
            if (oCATALOGO.FORMULARIOS.Count(frm => frm.CLASE == form.CLASE) == 0)
            {
                MODELO.SUBMODULO oSUBMODULO = oCATALOGO.SUBMODULOS.FirstOrDefault(smo => smo.DESCRIPCION == form.SUBMODULO);
                if (oSUBMODULO == null)
                {
                    MODELO.MODULO oMODULO = oCATALOGO.MODULOS.FirstOrDefault(mod => mod.DESCRIPCION == form.MODULO);
                    oSUBMODULO = new MODELO.SUBMODULO();
                    oSUBMODULO.DESCRIPCION = form.SUBMODULO;

                    oMODULO.SUBMODULO.Add(oSUBMODULO);
                }

                MODELO.FORMULARIO oFORMULARIO = new MODELO.FORMULARIO();
                oFORMULARIO.DESCRIPCION = form.DESCRIPCION;
                oFORMULARIO.CLASE = form.CLASE;
                oFORMULARIO.ACTIVO = true;
                oFORMULARIO.MENU = form.MENU;

                oSUBMODULO.FORMULARIO.Add(oFORMULARIO);

                oCATALOGO.SaveChanges();
            }

        }

        public void ACTUALIZA_ACCIONES(MODELO.accion accion)
        {
            if (oCATALOGO.ACCIONES.Count(a => (a.CONTROL == accion.CONTROL) && (a.FORMULARIO.CLASE == accion.FORMULARIO)) == 0)
            {
                MODELO.FORMULARIO oFORMULARIO = oCATALOGO.FORMULARIOS.FirstOrDefault(form => form.CLASE == accion.FORMULARIO);
                MODELO.ACCION oACCION = new MODELO.ACCION();
                oACCION.DESCRIPCION = accion.DESCRIPCION;
                oACCION.CONTROL = accion.CONTROL;

                oFORMULARIO.ACCION.Add(oACCION);

                oCATALOGO.SaveChanges();
            }
        }
    }
}
