using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VISTA.Parametros
{
    public partial class frmPARAMETROS_EQUIPO : Form
    {
        MODELO.PARAMETRO oPARAMETRO;
        string oACCION;
        CONTROLADORA.cPARAMETROS cPARAMETROS;
        public frmPARAMETROS_EQUIPO(MODELO.PARAMETRO miPARAMETRO, string miACCION)
        {
            InitializeComponent();
            oPARAMETRO = miPARAMETRO;
            oACCION = miACCION;
            cPARAMETROS = CONTROLADORA.cPARAMETROS.obtener_instancia();

            txtEQUIPO.Text = oPARAMETRO.NOMBRE_EQUIPO;
            txtDIRECTORIO_IMAGENES.Text = oPARAMETRO.DIRECTORIO_IMAGENES;
            chkENVIO_MAILS.Checked = oPARAMETRO.ENVIO_MAILS;
            gbPARAMETROS_MAIL.Enabled = oPARAMETRO.ENVIO_MAILS;
            txtMAIL_HOST.Text = oPARAMETRO.MAIL_HOST;
            txtMAIL_PORT.Text = oPARAMETRO.MAIL_PORT.ToString();
            txtMAIL_CUENTA.Text = oPARAMETRO.MAIL_CUENTA;
            txtMAIL_CLAVE.Text = oPARAMETRO.MAIL_CLAVE;
            txtMAIL_REMITENTE.Text = oPARAMETRO.MAIL_NOMBRE_REMITENTE;
            chkSSL.Checked = oPARAMETRO.MAIL_SSL;

            if (miACCION == "C")
            {
                btnGUARDAR.Enabled = false;
                btnCANCELAR.Text = "Cerrar";
                pDATOS.Enabled = false;
            }
        }

        private void btnBUSCAR_DIRECTORIO_Click(object sender, EventArgs e)
        {
            string startupPath = Application.StartupPath;
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                dialog.Description = "Open a folder which contains the xml output";
                dialog.ShowNewFolderButton = true;
                dialog.RootFolder = Environment.SpecialFolder.MyComputer;
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    txtDIRECTORIO_IMAGENES.Text = dialog.SelectedPath;
                }
            }
        }

        private void btnGUARDAR_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDIRECTORIO_IMAGENES.Text))
            {
                MessageBox.Show("Debe seleccionar el directorio donde se encuentran las imágenes de los usuarios", "ATENCION!!");
                return;
            }
            if (chkENVIO_MAILS.Checked)
            {
                if (string.IsNullOrEmpty(txtMAIL_HOST.Text))
                {
                    MessageBox.Show("Debe ingresar el nombre del servidor SMTP a utilizar para el envío de mails", "ATENCION!!");
                    return;
                }
                if (string.IsNullOrEmpty(txtMAIL_PORT.Text))
                {
                    MessageBox.Show("Debe ingresar el número del puerto del servidor SMTP a utilizar para el envío de mails", "ATENCION!!");
                    return;
                }
                if (string.IsNullOrEmpty(txtMAIL_CUENTA.Text))
                {
                    MessageBox.Show("Debe ingresar el nombre de la cuenta de correo a utilizar para el envío de mails", "ATENCION!!");
                    return;
                }
                if (string.IsNullOrEmpty(txtMAIL_CLAVE.Text))
                {
                    MessageBox.Show("Debe ingresar la clave de la cuenta de correo a utilizar para el envío de mails", "ATENCION!!");
                    return;
                }
                if (string.IsNullOrEmpty(txtMAIL_REMITENTE.Text))
                {
                    MessageBox.Show("Debe ingresar del remitente a utilizar para el envío de mails", "ATENCION!!");
                    return;
                }
            }
            oPARAMETRO.DIRECTORIO_IMAGENES = txtDIRECTORIO_IMAGENES.Text;
            oPARAMETRO.ENVIO_MAILS = chkENVIO_MAILS.Checked;
            oPARAMETRO.MAIL_HOST = txtMAIL_HOST.Text;
            oPARAMETRO.MAIL_PORT = Convert.ToInt32(txtMAIL_PORT.Text);
            oPARAMETRO.MAIL_CUENTA = txtMAIL_CUENTA.Text;
            oPARAMETRO.MAIL_CLAVE = txtMAIL_CLAVE.Text;
            oPARAMETRO.MAIL_NOMBRE_REMITENTE = txtMAIL_REMITENTE.Text;
            oPARAMETRO.MAIL_SSL = chkSSL.Checked;
            cPARAMETROS.MODIFICAR_PARAMETRO(oPARAMETRO);
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void chkENVIO_MAILS_CheckedChanged(object sender, EventArgs e)
        {
                gbPARAMETROS_MAIL.Enabled = chkENVIO_MAILS.Checked;
        }

        private void btnCANCELAR_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }
}
