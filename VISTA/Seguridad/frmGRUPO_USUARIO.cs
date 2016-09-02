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
    [MODELO.formulario(CLASE = "frmGRUPO_USUARIO", DESCRIPCION = "Gestión de datos del grupo", MENU = false, MODULO = "Seguridad", SUBMODULO = "Gestión de Seguridad")]
    public partial class frmGRUPO_USUARIO : Form
    {
        MODELO.GRUPO oGRUPO;
        CONTROLADORA.cGRUPOS cGRUPOS;
        string ACCION;
        bool chekearU;
        bool chekearN;
        public frmGRUPO_USUARIO(MODELO.GRUPO miGRUPO, string miACCION)
        {
            InitializeComponent();

            cGRUPOS = CONTROLADORA.cGRUPOS.obtener_instancia();
            ACCION = miACCION;
            oGRUPO = miGRUPO;
            if (ACCION != "A")
            {
                txtCODIGO.Text = oGRUPO.CODIGO.ToString();
                txtDESCRIPCION.Text = oGRUPO.DESCRIPCION;
                chkEstado.Checked = oGRUPO.ACTIVO;
                if (ACCION == "C")
                {
                    chkUSUARIOS.Enabled = false;
                    pDATOS.Enabled = false;
                    btnGUARDAR.Enabled = false;
                    btnCANCELAR.Text = "Cerrar";
                }

            }
        }

        private void frmGRUPO_USUARIO_Load(object sender, EventArgs e)
        {
            chkUSUARIOS.DataSource = null;
            chkUSUARIOS.DataSource = cGRUPOS.OBTENER_USUARIOS();
            chkUSUARIOS.DisplayMember = "NOMBRE";
            chekearU = false;
            for (int i = 0; i < chkUSUARIOS.Items.Count; i++)
            {
                MODELO.USUARIO oUsuario = (MODELO.USUARIO)chkUSUARIOS.Items[i];
                foreach (MODELO.USUARIO miUsuario in oGRUPO.USUARIO.ToList())
                {
                    if (miUsuario.CODIGO == oUsuario.CODIGO)
                    {
                        chkUSUARIOS.SetItemChecked(i, true);
                    }
                }
            }
            chekearU = true;

            chekearN = false;
            foreach (MODELO.MODULO oMODULO in cGRUPOS.OBTENER_MODULOS())
            {
                TreeNode tnM = new TreeNode();
                tnM.Text = oMODULO.DESCRIPCION;
                tnM.Tag = null;
                foreach (MODELO.SUBMODULO oSM in oMODULO.SUBMODULO)
                {
                    TreeNode tnS = new TreeNode();
                    tnS.Text = oSM.DESCRIPCION;
                    tnS.Tag = null;                    
                    tnM.Nodes.Add(tnS);
                    foreach(MODELO.FORMULARIO oFORM in oSM.FORMULARIO)
                    {
                        if (oFORM.ACCION.Count() > 0)
                        {
                            TreeNode tnf = new TreeNode();
                            tnf.Text = oFORM.DESCRIPCION;
                            tnf.Tag = null;
                            tnS.Nodes.Add(tnf);
                            foreach (MODELO.ACCION oACCION in oFORM.ACCION)
                            {
                                TreeNode tnA = new TreeNode();
                                tnA.Text = oACCION.DESCRIPCION;
                                tnA.Tag = oACCION;
                                if (oGRUPO.ACCION.Count(acc => acc.CODIGO == oACCION.CODIGO) > 0)
                                    tnA.Checked = true;
                                else
                                    tnA.Checked = false;

                                tnf.Nodes.Add(tnA);
                                HasCheckedChildNodes(tnf);
                            }
                        }
                    }
                }
                tvACCIONES.Nodes.Add(tnM);


            }
            chekearN = true;
        }

        private void btnCANCELAR_Click(object sender, EventArgs e)
        {
            cGRUPOS.CANCELAR_CAMBIOS(oGRUPO);
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void btnGUARDAR_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDESCRIPCION.Text))
            {
                MessageBox.Show("Debe asignar un nombre al grupo", "ATENCION!!");
                return;
            }

            oGRUPO.DESCRIPCION = txtDESCRIPCION.Text;
            oGRUPO.ACTIVO = chkEstado.Checked;

            if (ACCION == "A")
                cGRUPOS.AGREGAR_GRUPO(oGRUPO);
            else
                cGRUPOS.MODIFICAR_GRUPO(oGRUPO);

            this.DialogResult = DialogResult.OK;
        }

        private void chkUSUARIOS_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (chekearU == false) return;

            MODELO.USUARIO oUSUARIO = (MODELO.USUARIO)chkUSUARIOS.SelectedItem;
            if (e.NewValue == CheckState.Checked)
            {
                oGRUPO.USUARIO.Add(oUSUARIO);
            }
            else
            {
                oGRUPO.USUARIO.Remove(oUSUARIO);
            }
        }

        private void tvACCIONES_AfterCheck(object sender, TreeViewEventArgs e)
        {
            if (chekearN == false)
                return;

            TreeNode seleccion = e.Node;
            if (seleccion.Nodes.Count > 0)
            {
                    checkChildNodes(seleccion, seleccion.Checked);
            }
            else
            {
                if (seleccion.Tag != null)
                {
                    MODELO.ACCION oACCION = (MODELO.ACCION)seleccion.Tag;
                    if (seleccion.Checked)
                    {
                        oGRUPO.ACCION.Add(oACCION);
                    }
                    else
                    {
                        oGRUPO.ACCION.Remove(oACCION);
                    }
                }
            }
            chekearN = false;
            if (seleccion.Parent != null)
            {
                HasCheckedChildNodes(seleccion.Parent);
            }
            chekearN = true;

        }

        private void checkChildNodes(TreeNode node, bool nodeChecked)
        {
            chekearN = false;
            foreach (TreeNode tnS in node.Nodes)
            {                
                if (tnS.Nodes.Count > 0)
                {
                    tnS.Checked = nodeChecked;
                    checkChildNodes(tnS, nodeChecked);
                }
                else
                {
                    if (tnS.Checked != node.Checked)
                    {
                        tnS.Checked = node.Checked;                    
                        if (tnS.Tag != null)
                        {
                            MODELO.ACCION oACCION = (MODELO.ACCION)tnS.Tag;
                            if (tnS.Checked)
                            {
                                oGRUPO.ACCION.Add(oACCION);
                            }
                            else
                            {
                                oGRUPO.ACCION.Remove(oACCION);
                            }
                        }
                    }
                }
            }
            chekearN = true;
        }

        private void HasCheckedChildNodes(TreeNode node)
        {
            chekearN = false;
            bool marca = true;
            if (node.Nodes.Count > 0)
            {
                foreach (TreeNode childNode in node.Nodes)
                {
                    if (!childNode.Checked)
                        marca = false;
                }
                node.Checked = marca;
                if (node.Parent != null)
                    HasCheckedChildNodes(node.Parent);
            }
            chekearN = true;
        }

        private void tvACCIONES_BeforeCheck(object sender, TreeViewCancelEventArgs e)
        {
            if (ACCION == "C") e.Cancel = true;
        }

    }
}
