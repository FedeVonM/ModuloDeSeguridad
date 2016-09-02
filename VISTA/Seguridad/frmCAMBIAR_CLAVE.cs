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
    [MODELO.formulario(CLASE = "frmCAMBIAR_CLAVE", DESCRIPCION = "Cambio de contraseña de acceso", MENU = true, MODULO = "Seguridad",SUBMODULO="Operaciones")]
    [MODELO.accion(CONTROL = "btnGUARDAR", DESCRIPCION = "Cambiar contraseña de acceso", FORMULARIO = "frmCAMBIAR_CLAVE")]
    public partial class frmCAMBIAR_CLAVE : Form
    {
        MODELO.USUARIO oUSUARIO;
        CONTROLADORA.cPASSWORD cPASSWORD;
        private static frmCAMBIAR_CLAVE instancia;
        public static frmCAMBIAR_CLAVE obtener_instancia(MODELO.USUARIO miUSUARIO)
        {
            if (instancia == null)
                instancia = new frmCAMBIAR_CLAVE(miUSUARIO);
            if (instancia.IsDisposed)
                instancia = new frmCAMBIAR_CLAVE(miUSUARIO);

            return instancia;
        }
        private frmCAMBIAR_CLAVE(MODELO.USUARIO miUSUARIO)
        {
            InitializeComponent();
            oUSUARIO = miUSUARIO;
            cPASSWORD = CONTROLADORA.cPASSWORD.obtenerInstancia();

            txtAnterior.Text = string.Empty;
            txtPASSWORD.Text = string.Empty;
            txtPASSWORD2.Text = string.Empty;
        }

        private void btnCANCELAR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGUARDAR_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAnterior.Text))
            {
                MessageBox.Show("Debe ingresar la contraseña actual", "ATENCION!!");
                return;
            }
            if (oUSUARIO.CLAVE != CONTROLADORA.funciones_compartidas.EncriparClave(txtAnterior.Text))
            {
                MessageBox.Show("La contraseña actual ingresada no coincide con la contraseña registrada", "ATENCION!!");
                return;
            }
            if (string.IsNullOrEmpty(txtPASSWORD.Text))
            {
                MessageBox.Show("La nueva contraseña debe contener al menos un caracter", "ATENCION!!");
                return;
            }
            if (txtAnterior.Text == txtPASSWORD.Text)
            {
                MessageBox.Show("La nueva contraseña debe ser distinta a la actual", "ATENCION!!");
                return;
            }
            if (txtPASSWORD.Text != txtPASSWORD2.Text)
            {
                MessageBox.Show("Las nuevas contraseñas deben coincidir", "ATENCION!!");
                return;
            }

            oUSUARIO.CLAVE = CONTROLADORA.funciones_compartidas.EncriparClave(txtPASSWORD.Text);
            oUSUARIO.RESETEAR_CLAVE = false;
            cPASSWORD.MODIFICACION(oUSUARIO);

            MessageBox.Show("Se ha establecido la nueva contraseña, la misma deberá ser usada en el próximo inicio de sesión", "CAMBIO DE CONTRASENA ACEPTADA");

            this.Close();
        }
    }
}
