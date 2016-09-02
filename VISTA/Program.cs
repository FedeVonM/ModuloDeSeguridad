using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace VISTA
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            CONTROLADORA.cINICIO cINICIO = CONTROLADORA.cINICIO.OBTENER_INSTANCIA();
            cINICIO.INICIA_USUARIOS();
            cINICIO.INICIA_PARAMETROS();

            Application.Run(new Inicio.MENU_PRINCIPAL());
        }
    }
}
