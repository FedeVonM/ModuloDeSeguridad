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
    public partial class frmUSUARIO : Form
    {
        MODELO.USUARIO oUSUARIO;
        CONTROLADORA.cUSUARIOS cUSUARIOS;
        string ACCION;
        bool checkearA;
        public frmUSUARIO(MODELO.USUARIO miUSUARIO, string miACCION)
        {
            InitializeComponent();
            cUSUARIOS = CONTROLADORA.cUSUARIOS.obtener_instancia();
            oUSUARIO = miUSUARIO;
            ACCION = miACCION;
            if (ACCION != "A")
            {
                txtCODIGO.Text = oUSUARIO.CODIGO.ToString();
                txtNOMBRE_USUARIO.Text = oUSUARIO.NOMBRE_USUARIO;
                txtNOMBRE.Text = oUSUARIO.NOMBRE;
                txtEMAIL.Text = oUSUARIO.EMAIL;
                txtTELEFONO.Text = oUSUARIO.TELEFONO;
                chkEstado.Checked = oUSUARIO.ACTIVO;
                Image image = Image.FromFile(CONTROLADORA.funciones_compartidas.DIRECTORIO_IMAGENES() + oUSUARIO.IMAGEN);
                pbUSUARIO.Image = CONTROLADORA.funciones_compartidas.resizeImage(image, new Size(pbUSUARIO.Width, pbUSUARIO.Height));
                lblIMAGEN.Text = oUSUARIO.IMAGEN;
                lblDIR_IMAGEN.Text = CONTROLADORA.funciones_compartidas.DIRECTORIO_IMAGENES(); 

                if (ACCION == "C")
                {
                    btnCANCELAR.Text = "Cerrar";
                    btnGUARDAR.Enabled = false;
                    chkGRUPOS.Enabled = false;
                    pDATOS.Enabled = false;
                }
            }

        }

        private void btnCANCELAR_Click(object sender, EventArgs e)
        {
            cUSUARIOS.CANCELAR_CAMBIOS(oUSUARIO);
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void frmUSUARIO_Load(object sender, EventArgs e)
        {
            chkGRUPOS.DataSource = null;
            chkGRUPOS.DataSource = cUSUARIOS.OBTENER_GRUPOS();
            chkGRUPOS.DisplayMember = "DESCRIPCION";

            checkearA = false;
            for (int i = 0; i < chkGRUPOS.Items.Count; i++)
            {
                MODELO.GRUPO oGrupo = (MODELO.GRUPO)chkGRUPOS.Items[i];
                foreach (MODELO.GRUPO miGrupo in oUSUARIO.GRUPO)
                {
                    if (miGrupo.CODIGO == oGrupo.CODIGO)
                    {
                        chkGRUPOS.SetItemChecked(i, true);
                    }
                }
            }
            checkearA = true;
        }

        private void btnGUARDAR_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNOMBRE_USUARIO.Text))
            {
                MessageBox.Show("Debe ingresar el nombre de usuario para el acceso al sistema", "ATENCION!!");
                return;
            }
            int codigo_usuario;
            if (!int.TryParse(txtCODIGO.Text, out codigo_usuario))
                codigo_usuario = 0;

            if (cUSUARIOS.VALIDA_NOMBRE_USUARIO(txtNOMBRE_USUARIO.Text,codigo_usuario))
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
            if (!CONTROLADORA.funciones_compartidas.ValidarEmail (txtEMAIL.Text))
            {
                MessageBox.Show("El email ingresado no tiene el formato correcto", "ATENCION!!");
                return;
            }
            if (cUSUARIOS.VALIDA_EMAIL_USUARIO(txtEMAIL.Text, codigo_usuario))
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
            oUSUARIO.ACTIVO = chkEstado.Checked;
            oUSUARIO.IMAGEN = lblIMAGEN.Text;
            CONTROLADORA.funciones_compartidas.copiar_archivo(lblDIR_IMAGEN.Text, lblIMAGEN.Text);

            if (ACCION == "A")
            {
                oUSUARIO.CLAVE = CONTROLADORA.funciones_compartidas.EncriparClave(txtNOMBRE_USUARIO.Text);
                oUSUARIO.RESETEAR_CLAVE = true;
                cUSUARIOS.AGREGAR_USUARIO(oUSUARIO);
            }
            else
            {
                cUSUARIOS.MODIFICAR_USUARIO(oUSUARIO);
            }

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void chkGRUPOS_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (checkearA == false) return;

            MODELO.GRUPO oGrupo = (MODELO.GRUPO)chkGRUPOS.SelectedItem;
            if (e.NewValue == CheckState.Checked)
            {
                oUSUARIO.GRUPO.Add(oGrupo);
            }
            else
            {
                oUSUARIO.GRUPO.Remove(oGrupo);
            }
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
    }
}
