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
    public partial class frmLOGIN : Form
    {
        CONTROLADORA.cLOGIN cLOGIN;
        MODELO.USUARIO oUSUARIO;
        public MODELO.USUARIO USUARIO_ACTUAL
        {
            get { return oUSUARIO; }
        }
        public frmLOGIN()
        {
            InitializeComponent();
            cLOGIN = CONTROLADORA.cLOGIN.OBTENER_INSTANCIA();
            if (CONTROLADORA.funciones_compartidas.VERIFICA_ENVIO_MAIL())
            {
                label4.Enabled = true;
                lblERROR_RECUPERAR.Text = "";
            }
            else
            {
                label4.Enabled = false;
                lblERROR_RECUPERAR.Text = "No es posible recuperar la contraseña, debido a que no es posible enviar mails de confirmación en el equipo. Revise los parámetros";
            }
        }

        private void btnCANCELAR_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void btnINGRESAR_Click(object sender, EventArgs e)
        {
            lblMENSAJE_LOGIN.Text = "";
            if (string.IsNullOrEmpty(txtUSUARIO.Text))
            {
                lblMENSAJE_LOGIN.Text = "Debe ingresar el nombre de usuario";
                return;
            }
            if (string.IsNullOrEmpty(txtPASSWORD.Text))
            {
                lblMENSAJE_LOGIN.Text = "Debe ingresar la contraseña del usuario";
                return;
            }
            try
            {
                oUSUARIO = cLOGIN.VALIDAR_USUARIO(txtUSUARIO.Text, txtPASSWORD.Text);
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            catch (Exception ex)
            {
                lblMENSAJE_LOGIN.Text = ex.Message;
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {
            frmRECUPERAR_CLAVE formRECUPERAR_CLAVE = new frmRECUPERAR_CLAVE();
            DialogResult dr = formRECUPERAR_CLAVE.ShowDialog();
        }

    }
}
