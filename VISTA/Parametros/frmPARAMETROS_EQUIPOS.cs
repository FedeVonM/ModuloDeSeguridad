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
    [MODELO.formulario(CLASE = "frmPARAMETROS_EQUIPOS", DESCRIPCION = "Gestión de parámetros del sistema por equipo", MENU = true, MODULO = "Parametros", SUBMODULO = "Sistema")]
    [MODELO.accion(CONTROL = "btnCONSULTAS", DESCRIPCION = "Consultar parámetros del equipo", FORMULARIO = "frmPARAMETROS_EQUIPOS")]
    [MODELO.accion(CONTROL = "btnMODIFICACIONES", DESCRIPCION = "Modificar parámetros del equipo", FORMULARIO = "frmPARAMETROS_EQUIPOS")]
    public partial class frmPARAMETROS_EQUIPOS : Form
    {
        CONTROLADORA.cPARAMETROS cPARAMETROS;
        private static frmPARAMETROS_EQUIPOS instancia;
        public static frmPARAMETROS_EQUIPOS obtener_instancia(MODELO.USUARIO oUSUARIO)
        {
            if (instancia == null)
                instancia = new frmPARAMETROS_EQUIPOS(oUSUARIO);
            if (instancia.IsDisposed)
                instancia = new frmPARAMETROS_EQUIPOS(oUSUARIO);

            return instancia;
        }
        public frmPARAMETROS_EQUIPOS(MODELO.USUARIO oUSUARIO)
        {
            InitializeComponent();
            btnCONSULTAS.Enabled = oUSUARIO.VALIDAR_ACCION("frmPARAMETROS_EQUIPOS", "btnCONSULTAS");
            btnMODIFICACIONES.Enabled = oUSUARIO.VALIDAR_ACCION("frmPARAMETROS_EQUIPOS", "btnMODIFICACIONES");
            
            cPARAMETROS = CONTROLADORA.cPARAMETROS.obtener_instancia();
            ARMA_GRILLA();
        }

        private void ARMA_GRILLA()
        {
            dgvDATA.DataSource = null;
            dgvDATA.DataSource = cPARAMETROS.OBTENER_PARAMETROS(txtNOMBRE_EQUIPO.Text);
          
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBUSCAR_Click(object sender, EventArgs e)
        {
            ARMA_GRILLA();
        }

        private void btnCONSULTAS_Click(object sender, EventArgs e)
        {
            if (dgvDATA.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un parámetro", "ATENCION!!");
                return;
            }
            frmPARAMETROS_EQUIPO formPARAMETRO = new frmPARAMETROS_EQUIPO(cPARAMETROS.OBTENER_PARAMETRO(Convert.ToInt32(dgvDATA.CurrentRow.Cells[0].Value)), "C");
            DialogResult dr = formPARAMETRO.ShowDialog();
        }

        private void btnMODIFICACIONES_Click(object sender, EventArgs e)
        {
            if (dgvDATA.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un parámetro", "ATENCION!!");
                return;
            }
            frmPARAMETROS_EQUIPO formPARAMETRO = new frmPARAMETROS_EQUIPO(cPARAMETROS.OBTENER_PARAMETRO(Convert.ToInt32(dgvDATA.CurrentRow.Cells[0].Value)), "M");
            DialogResult dr = formPARAMETRO.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
                ARMA_GRILLA();
        }
    }
}
