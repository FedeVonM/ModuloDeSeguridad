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
    [MODELO.formulario(CLASE = "frmUSUARIOS", DESCRIPCION = "Gestión de Usarios del sistema", MENU = true, MODULO = "Seguridad", SUBMODULO = "Gestión de Seguridad")]
    [MODELO.accion(CONTROL = "btnCONSULTAS", DESCRIPCION = "Consultar datos del usuario", FORMULARIO = "frmUSUARIOS")]
    [MODELO.accion(CONTROL = "btnBAJAS", DESCRIPCION = "Eliminar usuarios del sistema", FORMULARIO = "frmUSUARIOS")]
    [MODELO.accion(CONTROL = "btnMODIFICACIONES", DESCRIPCION = "Modificar datos del usuario", FORMULARIO = "frmUSUARIOS")]
    [MODELO.accion(CONTROL = "btnALTAS", DESCRIPCION = "Agregar usuarios del sistema", FORMULARIO = "frmUSUARIOS")]
    [MODELO.accion(CONTROL = "btnRESETEAR_CLAVE", DESCRIPCION = "resetear contraseñas de usuarios", FORMULARIO = "frmUSUARIOS")]    
    public partial class frmUSUARIOS : Form
    {
        CONTROLADORA.cUSUARIOS cUSUARIOS;
        MODELO.GRUPO oGRUPO;
        private static frmUSUARIOS instancia;
        public static frmUSUARIOS obtener_instancia(MODELO.USUARIO oUSUARIO)
        {
            if (instancia == null)
                instancia = new frmUSUARIOS(oUSUARIO);
            if (instancia.IsDisposed)
                instancia = new frmUSUARIOS(oUSUARIO);

            return instancia;
        }
        private frmUSUARIOS(MODELO.USUARIO oUSUARIO)
        {
            InitializeComponent();
            btnCONSULTAS.Enabled = oUSUARIO.VALIDAR_ACCION("frmUSUARIOS", "btnCONSULTAS");
            btnBAJAS.Enabled = oUSUARIO.VALIDAR_ACCION("frmUSUARIOS", "btnBAJAS");
            btnMODIFICACIONES.Enabled = oUSUARIO.VALIDAR_ACCION("frmUSUARIOS", "btnMODIFICACIONES");
            btnALTAS.Enabled = oUSUARIO.VALIDAR_ACCION("frmUSUARIOS", "btnALTAS");
            btnRESETEAR_CLAVE.Enabled = oUSUARIO.VALIDAR_ACCION("frmUSUARIOS", "btnRESETEAR_CLAVE");
            cUSUARIOS = CONTROLADORA.cUSUARIOS.obtener_instancia();

            ARMA_GRILLA();

            cmbGRUPO.DataSource = cUSUARIOS.OBTENER_GRUPOS();
            cmbGRUPO.DisplayMember = "DESCRIPCION";
        }

        private void ARMA_GRILLA()
        {
            if (rbTODOS.Checked)
                oGRUPO = null;
            else
                oGRUPO = (MODELO.GRUPO) cmbGRUPO.SelectedItem;

            dgvDATA.DataSource = null;
            dgvDATA.DataSource = cUSUARIOS.OBTENER_USUARIOS(txtDESCRIPCION.Text, oGRUPO, chkINACTIVOS.Checked);
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rbTODOS_CheckedChanged(object sender, EventArgs e)
        {
            cmbGRUPO.Enabled = false;
        }

        private void rbSELECCION_CheckedChanged(object sender, EventArgs e)
        {
            cmbGRUPO.Enabled = true;
        }

        private void btnBUSCAR_Click(object sender, EventArgs e)
        {
            ARMA_GRILLA();
        }

        private void btnCONSULTAS_Click(object sender, EventArgs e)
        {
            if (dgvDATA.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un usuario de la lista", "ATENCION!!");
                return;
            }
            frmUSUARIO formUSUARIO = new frmUSUARIO(cUSUARIOS.OBTENER_USUARIO(Convert.ToInt32(dgvDATA.CurrentRow.Cells[0].Value)), "C");
            DialogResult dr = formUSUARIO.ShowDialog();
        }

        private void btnMODIFICACIONES_Click(object sender, EventArgs e)
        {
            if (dgvDATA.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un usuario de la lista", "ATENCION!!");
                return;
            }
            frmUSUARIO formUSUARIO = new frmUSUARIO(cUSUARIOS.OBTENER_USUARIO(Convert.ToInt32(dgvDATA.CurrentRow.Cells[0].Value)), "M");
            DialogResult dr = formUSUARIO.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
                ARMA_GRILLA();

        }

        private void btnBAJAS_Click(object sender, EventArgs e)
        {
            if (dgvDATA.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un usuario de la lista", "ATENCION!!");
                return;
            }
            MODELO.USUARIO oUSUARIO = cUSUARIOS.OBTENER_USUARIO(Convert.ToInt32(dgvDATA.CurrentRow.Cells[0].Value));
            if (oUSUARIO.ACTIVO == false)
            {
                MessageBox.Show("El usuario seleccionado ya ha sido inhabilitado en el sistema, para reactivar la cuenta deberá seleccionar la opción de modificar datos", "ATENCION!!");
                return;
            }
            DialogResult dr = MessageBox.Show("¿Confirma que desea anular la cuenta del usuario " + oUSUARIO.NOMBRE + "?", "ELIMINAR USUARIO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == System.Windows.Forms.DialogResult.Yes)
            {
                oUSUARIO.ACTIVO = false;
                cUSUARIOS.ELIMINAR_USUARIO(oUSUARIO);
                ARMA_GRILLA();
            }
                
        }

        private void btnALTAS_Click(object sender, EventArgs e)
        {
            frmUSUARIO formUSUARIO = new frmUSUARIO(new MODELO.USUARIO(), "A");
            DialogResult dr = formUSUARIO.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
                ARMA_GRILLA();
        }

        private void btnRESETEAR_CLAVE_Click(object sender, EventArgs e)
        {
            if (dgvDATA.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un usuario de la lista", "ATENCION!!");
                return;
            }

            frmCLAVE_USUARIO formCAMBIAR_CLAVE = new frmCLAVE_USUARIO(cUSUARIOS.OBTENER_USUARIO(Convert.ToInt32(dgvDATA.CurrentRow.Cells[0].Value)));
            DialogResult dr = formCAMBIAR_CLAVE.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
                MessageBox.Show("Se ha cambiado la clave.", "CAMBIO DE CLAVE",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
