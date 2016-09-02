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
    public partial class frmDATOS_USUARIO : Form
    {
        CONTROLADORA.cUSUARIOS cUSUARIOS;
        MODELO.USUARIO oUSUARIO;
        public frmDATOS_USUARIO(MODELO.USUARIO miUSUARIO)
        {
            InitializeComponent();
            cUSUARIOS = CONTROLADORA.cUSUARIOS.obtener_instancia();
            oUSUARIO = miUSUARIO;

            txtNOMBRE_USUARIO.Text = oUSUARIO.NOMBRE_USUARIO;
            txtNOMBRE.Text = oUSUARIO.NOMBRE;
            txtEMAIL.Text = oUSUARIO.EMAIL;
            txtTELEFONO.Text = oUSUARIO.TELEFONO;
            Image image = Image.FromFile(CONTROLADORA.funciones_compartidas.DIRECTORIO_IMAGENES() + oUSUARIO.IMAGEN);
            pbUSUARIO.Image = CONTROLADORA.funciones_compartidas.resizeImage(image, new Size(pbUSUARIO.Width, pbUSUARIO.Height));
            lblIMAGEN.Text = oUSUARIO.IMAGEN;
            lblDIR_IMAGEN.Text = CONTROLADORA.funciones_compartidas.DIRECTORIO_IMAGENES();

        }

        private void btnCANCELAR_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void btnCAMBIAR_IMAGEN_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Open Image";
            dlg.Filter = "Archivos de imagen|*.bmp;*.jpg;*.jpeg;*.png;*.tif;*.tiff";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                pbUSUARIO.Image = Image.FromFile(dlg.FileName);
                lblDIR_IMAGEN.Text = System.IO.Path.GetDirectoryName(dlg.FileName);
                lblIMAGEN.Text = System.IO.Path.GetFileName(dlg.FileName);
            }
            dlg.Dispose();
        }

        private void btnGUARDAR_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNOMBRE_USUARIO.Text))
            {
                MessageBox.Show("Debe ingresar el nombre de usuario para el acceso al sistema", "ATENCION!!");
                return;
            }

            if (cUSUARIOS.VALIDA_NOMBRE_USUARIO(txtNOMBRE_USUARIO.Text, oUSUARIO.CODIGO))
            {
                MessageBox.Show("El nombre de usuario para el acceso al sistema ya se encuentra asignado a otro usuario", "ATENCION!!");
                return;
            }
            if (string.IsNullOrEmpty(txtNOMBRE.Text))
            {
                MessageBox.Show("Debe ingresar el nombre del usuario", "ATENCION!!");
                return;
            }
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
            if (cUSUARIOS.VALIDA_EMAIL_USUARIO(txtEMAIL.Text, oUSUARIO.CODIGO))
            {
                MessageBox.Show("El email ingresado ya se encuentra asignado a otro usuario", "ATENCION!!");
                return;
            }
            if (string.IsNullOrEmpty(txtTELEFONO.Text))
            {
                MessageBox.Show("Debe ingresar el telefono del usuario", "ATENCION!!");
                return;
            }

            oUSUARIO.NOMBRE_USUARIO = txtNOMBRE_USUARIO.Text;
            oUSUARIO.NOMBRE = txtNOMBRE.Text;
            oUSUARIO.EMAIL = txtEMAIL.Text;
            oUSUARIO.TELEFONO = txtTELEFONO.Text;
            oUSUARIO.IMAGEN = lblIMAGEN.Text;
            CONTROLADORA.funciones_compartidas.copiar_archivo(lblDIR_IMAGEN.Text, lblIMAGEN.Text);
            cUSUARIOS.MODIFICAR_USUARIO(oUSUARIO);

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        public MODELO.USUARIO DATOS_ACTUALIZADOS
        {
            get { return oUSUARIO; }
        }
    }
}
