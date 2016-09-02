using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VISTA.Inicio
{
    public partial class frmRECUPERAR_CLAVE : Form
    {
        CONTROLADORA.cPASSWORD cPASSWORD;
        public frmRECUPERAR_CLAVE()
        {
            InitializeComponent();
            cPASSWORD = CONTROLADORA.cPASSWORD.obtenerInstancia();
        }

        private void btnCANCELAR_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void btnRECUPERAR_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEMAIL.Text))
            {
                MessageBox.Show("Debe ingresar el email del usuario", "ATENCION!!");
                return;
            }
            if (!CONTROLADORA.funciones_compartidas.ValidarEmail(txtEMAIL.Text))
            {
                MessageBox.Show("El email ingresado no tiene el formato correcto", "ATENCION!!");
                return;
            }

            MODELO.USUARIO oUSUARIO = cPASSWORD.OBTENER_USUARIO(txtEMAIL.Text);
            if (oUSUARIO == null)
            {
                MessageBox.Show("No se ha podido encontrar la cuenta de usuario asociada al mail ingresado", "ATENCION!!");
                return;
            }
            if (oUSUARIO.ACTIVO == false)
            {
                MessageBox.Show("La cuenta de usuario asociada al mail ingresado se encuentra bloqueada, por favor comunicarse con el administrador del sistema", "ATENCION!!");
                return;
            }
            string clave_nueva = CONTROLADORA.funciones_compartidas.ClaveAleatoria();
            oUSUARIO.CLAVE = CONTROLADORA.funciones_compartidas.EncriparClave(clave_nueva);
            oUSUARIO.RESETEAR_CLAVE = true;
            cPASSWORD.MODIFICACION(oUSUARIO);
                if (CONTROLADORA.funciones_compartidas.EnviarEmail(oUSUARIO.EMAIL, "CAMBIO DE CONTRASEÑA", "Estimado " + oUSUARIO.NOMBRE + ":\n Por medio del presente le enviamos su nueva contraseña de acceso al sistema.\n La misma es: " + clave_nueva + ". \n El nombre de usuario para iniciar sesión es: " + oUSUARIO.NOMBRE_USUARIO +". \n Atte.\nAdministrador del Sistema"))
                {
                    MessageBox.Show("Se ha enviado la nueva contraseña por correo electrónico", "EMAIL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("NO se ha enviado la nueva contraseña por correo electrónico. Revise la configuración del sistema", "EMAIL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}
