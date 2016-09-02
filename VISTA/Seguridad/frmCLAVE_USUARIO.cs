using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VISTA.Seguridad
{
    public partial class frmCLAVE_USUARIO : Form
    {
        MODELO.USUARIO oUSUARIO;
        CONTROLADORA.cUSUARIOS cUSUARIOS;
        public frmCLAVE_USUARIO(MODELO.USUARIO miUSUARIO)
        {
            InitializeComponent();
            cUSUARIOS = CONTROLADORA.cUSUARIOS.obtener_instancia();
            oUSUARIO = miUSUARIO;

            txtNOMBRE.Text = oUSUARIO.NOMBRE;
            txtNOMBRE_USUARIO.Text = oUSUARIO.NOMBRE_USUARIO;
            chkRESETEAR_CLAVE.Checked = oUSUARIO.RESETEAR_CLAVE;
            txtEMAIL.Text = oUSUARIO.EMAIL;
            chkEMAIL.Enabled = CONTROLADORA.funciones_compartidas.VERIFICA_ENVIO_MAIL();
            btnGENERAR_CLAVE.Enabled = CONTROLADORA.funciones_compartidas.VERIFICA_ENVIO_MAIL();
        }

        private void btnCANCELAR_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void btnGUARDAR_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPASSWORD.Text))
            {
                MessageBox.Show("Debe ingresar la nueva contraseña del usuario", "ATENCION!!");
                return;
            }
            if (txtPASSWORD.Text != txtPASSWORD2.Text)
            {
                MessageBox.Show("Las contraseñas ingresadas no coinciden", "ATENCION!!");
                return;
            }
            oUSUARIO.CLAVE = CONTROLADORA.funciones_compartidas.EncriparClave(txtPASSWORD.Text);
            oUSUARIO.RESETEAR_CLAVE = chkRESETEAR_CLAVE.Checked;
            cUSUARIOS.MODIFICAR_USUARIO(oUSUARIO);
            if (chkEMAIL.Checked)
            {
                if (CONTROLADORA.funciones_compartidas.EnviarEmail(txtEMAIL.Text, "CAMBIO DE CONTRASEÑA", "Estimado " + oUSUARIO.NOMBRE + ":\n Por medio del presente le enviamos su nueva contraseña de acceso al sistema.\n La misma es: " + txtPASSWORD.Text + ". \n Atte.\nAdministrador del Sistema"))
                {
                    MessageBox.Show("Se ha enviado la nueva contraseña por correo electrónico", "EMAIL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("NO se ha enviado la nueva contraseña por correo electrónico. Revise la configuración del sistema", "EMAIL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void btnGENERAR_CLAVE_Click(object sender, EventArgs e)
        {
            txtPASSWORD.Text = CONTROLADORA.funciones_compartidas.ClaveAleatoria();
            txtPASSWORD2.Text = txtPASSWORD.Text;
            chkEMAIL.Checked = true;
            chkEMAIL.Enabled = false;
        }
    }
}
