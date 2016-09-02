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
    [MODELO.formulario(CLASE = "frmGRUPOS_USUARIOS", DESCRIPCION = "Gestión de Grupos de Usuarios", MENU = true, MODULO = "Seguridad", SUBMODULO = "Gestión de Seguridad")]
    [MODELO.accion(CONTROL = "btnCONSULTAS", DESCRIPCION = "Consultar datos del grupo", FORMULARIO = "frmGRUPOS_USUARIOS")]
    [MODELO.accion(CONTROL = "btnBAJAS", DESCRIPCION = "Eliminar grupos de usuarios", FORMULARIO = "frmGRUPOS_USUARIOS")]
    [MODELO.accion(CONTROL = "btnMODIFICACIONES", DESCRIPCION = "Modificar datos del grupo", FORMULARIO = "frmGRUPOS_USUARIOS")]
    [MODELO.accion(CONTROL = "btnALTAS", DESCRIPCION = "Agregar grupos de usuarios", FORMULARIO = "frmGRUPOS_USUARIOS")]
    public partial class frmGRUPOS_USUARIOS : Form
    {
        CONTROLADORA.cGRUPOS cGRUPOS;
        MODELO.USUARIO miUSUARIO;
        private static frmGRUPOS_USUARIOS instancia;
        public static frmGRUPOS_USUARIOS obtener_instancia(MODELO.USUARIO oUSUARIO)
        {
            if (instancia == null)
                instancia = new frmGRUPOS_USUARIOS(oUSUARIO);
            if (instancia.IsDisposed)
                instancia = new frmGRUPOS_USUARIOS(oUSUARIO);

            return instancia;
        }
        private frmGRUPOS_USUARIOS(MODELO.USUARIO oUSUARIO)
        {
            miUSUARIO = oUSUARIO;
            InitializeComponent();
            btnCONSULTAS.Enabled = oUSUARIO.VALIDAR_ACCION("frmGRUPOS_USUARIOS", "btnCONSULTAS");
            btnBAJAS.Enabled = oUSUARIO.VALIDAR_ACCION("frmGRUPOS_USUARIOS", "btnBAJAS");
            btnMODIFICACIONES.Enabled = oUSUARIO.VALIDAR_ACCION("frmGRUPOS_USUARIOS", "btnMODIFICACIONES");
            btnALTAS.Enabled = oUSUARIO.VALIDAR_ACCION("frmGRUPOS_USUARIOS", "btnALTAS");

            cGRUPOS = CONTROLADORA.cGRUPOS.obtener_instancia();
            ARMA_GRILLA();
        }

        private void ARMA_GRILLA()
        {
            dgvDATA.DataSource = null;
            dgvDATA.DataSource = cGRUPOS.OBTENER_GRUPOS(txtDESCRIPCION.Text, chkINACTIVOS.Checked);
        }

        private void btnBUSCAR_Click(object sender, EventArgs e)
        {
            ARMA_GRILLA();
        }

        private void btnCERRAR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCONSULTAS_Click(object sender, EventArgs e)
        {
            if (dgvDATA.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un grupo de usuarios", "ATENCION!!");
                return;
            }
            frmGRUPO_USUARIO formGP = new frmGRUPO_USUARIO(cGRUPOS.OBTENER_GRUPO(Convert.ToInt32(dgvDATA.CurrentRow.Cells[0].Value)), "C");
            DialogResult dr = formGP.ShowDialog();
        }

        private void btnMODIFICACIONES_Click(object sender, EventArgs e)
        {
            if (dgvDATA.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un grupo de usuarios", "ATENCION!!");
                return;
            }
            frmGRUPO_USUARIO formGP = new frmGRUPO_USUARIO(cGRUPOS.OBTENER_GRUPO(Convert.ToInt32(dgvDATA.CurrentRow.Cells[0].Value)), "M");
            DialogResult dr = formGP.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
                ARMA_GRILLA();
        }

        private void btnBAJAS_Click(object sender, EventArgs e)
        {
            if (dgvDATA.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un grupo de usuarios", "ATENCION!!");
                return;
            }
            MODELO.GRUPO oGRUPO = cGRUPOS.OBTENER_GRUPO(Convert.ToInt32(dgvDATA.CurrentRow.Cells[0].Value));
            DialogResult confirma = System.Windows.Forms.DialogResult.No;
            if (oGRUPO.USUARIO.Count > 1)
            {
                confirma = MessageBox.Show("El grupo  " + oGRUPO.DESCRIPCION + " posee " + oGRUPO.USUARIO.Count + " usuarios asignados, por lo tanto no podrá ser eliminado pero si confirma la operación el estado del mismo será inactivo. ¿Confirma que desea desactivar el grupo?.", "ATENCION!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
            if (oGRUPO.USUARIO.Count == 1)
            {
                confirma = MessageBox.Show("El grupo  " + oGRUPO.DESCRIPCION + " posee " + oGRUPO.USUARIO.Count + " usuario asignado, por lo tanto no podrá ser eliminado pero si confirma la operación el estado del mismo será inactivo. ¿Confirma que desea desactivar el grupo?.", "ATENCION!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
            if (oGRUPO.USUARIO.Count == 0)
            {
                confirma = MessageBox.Show("El grupo  " + oGRUPO.DESCRIPCION + " no posee usuarios asignado, por lo tanto será eliminado. ¿Confirma que desea eliminar el grupo?.", "ATENCION!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
            if (confirma == System.Windows.Forms.DialogResult.Yes)
            {
                cGRUPOS.ELIMINAR_GRUPO(oGRUPO);
                ARMA_GRILLA();
            }
        }

        private void btnALTAS_Click(object sender, EventArgs e)
        {
            frmGRUPO_USUARIO formGP = new frmGRUPO_USUARIO(new MODELO.GRUPO(), "A");
            DialogResult dr = formGP.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
                ARMA_GRILLA();
        }
    }
}
