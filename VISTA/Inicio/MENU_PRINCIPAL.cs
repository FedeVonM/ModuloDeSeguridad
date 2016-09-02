using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace VISTA.Inicio
{
    public partial class MENU_PRINCIPAL : Form
    {
        MODELO.USUARIO oUSUARIO_ACTUAL;
        CONTROLADORA.cINICIO cINICIO;
        private Form miFORM;
        public MENU_PRINCIPAL()
        {
            InitializeComponent();

            cINICIO = CONTROLADORA.cINICIO.OBTENER_INSTANCIA();
            var namespaces = (from type in Assembly.GetExecutingAssembly().GetTypes()
                              where !string.IsNullOrEmpty(type.Namespace) && type.Namespace.IndexOf('.') > 0
                              let dotIndex = type.Namespace.IndexOf('.') + 1
                              let topLevel = dotIndex < 0 ? type.Namespace
                                   : type.Namespace.Substring(dotIndex, (type.Namespace.Length - dotIndex))
                              orderby topLevel
                              select topLevel).Distinct();

           foreach (var nsp in namespaces)
            {
                if (nsp != "Inicio" && nsp != "Properties")
                {
                    cINICIO.ACTUALIZA_MODULO(nsp);
                }
            }

           foreach (System.Type type in Assembly.GetExecutingAssembly().GetTypes())
           {
               //pregunto si es de tipo Formulario
               if (type.IsSubclassOf(typeof(Form)))
               {
                   object[] attrs = type.GetCustomAttributes(typeof(MODELO.formulario), true);

                   foreach (MODELO.formulario a in attrs)
                   {
                       //MessageBox.Show(a.DESCRIPCION + ", " + a.CLASE);
                       cINICIO.ACTUALIZA_FORMULARIOS(a);
                   }

                   object[] acciones = type.GetCustomAttributes(typeof(MODELO.accion), true);

                   foreach (MODELO.accion ac in acciones)
                   {
                       //MessageBox.Show(ac.FORMULARIO + " - " + ac.CONTROL + " - " + ac.DESCRIPCION);
                       cINICIO.ACTUALIZA_ACCIONES(ac);
                   }                   
               }
           }
            
        }

        private void MENU_PRINCIPAL_Load(object sender, EventArgs e)
        {
            ARMA_LOGIN();
        }

        private void ARMA_LOGIN()
        {
            frmLOGIN formLOGIN = new frmLOGIN();
            DialogResult drLOGIN = formLOGIN.ShowDialog();
            if (drLOGIN == System.Windows.Forms.DialogResult.Cancel)
            {
                MessageBox.Show("La aplicación se cerrará debido a que no se ha podido validar el usuario de la misma", "ATENCION!!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                Application.Exit();
                return;
            }
            else
            {
                oUSUARIO_ACTUAL = formLOGIN.USUARIO_ACTUAL;
                lblNOMBRE.Text = oUSUARIO_ACTUAL.NOMBRE;
                lblCUENTA.Text = oUSUARIO_ACTUAL.NOMBRE_USUARIO;
                lblEMAIL.Text = oUSUARIO_ACTUAL.EMAIL;
                Image image = Image.FromFile(CONTROLADORA.funciones_compartidas.DIRECTORIO_IMAGENES() + oUSUARIO_ACTUAL.IMAGEN);
                pbUSUARIO.Image = CONTROLADORA.funciones_compartidas.resizeImage(image, new Size(pbUSUARIO.Width, pbUSUARIO.Height));

                if (oUSUARIO_ACTUAL.RESETEAR_CLAVE)
                {
                    CAMBIAR_CLAVE();
                }
                ARMA_MODULOS();
            }
        }

        private void ARMA_MODULOS()
        {
            tvOPERACIONES.Nodes.Clear();
            foreach (MODELO.MODULO oMODULO in oUSUARIO_ACTUAL.OBTENER_MODULOS())
            {
                TreeNode tn = new TreeNode();
                tn.Text = oMODULO.DESCRIPCION;
                tn.Tag = "0";
                tvOPERACIONES.Nodes.Add(tn);
                ARMA_SUB_MODULOS(tn, oMODULO);
            }
            tvOPERACIONES.NodeMouseClick += new TreeNodeMouseClickEventHandler(this.ITEM_CLICK);
        }

        private void ARMA_SUB_MODULOS(TreeNode nodo, MODELO.MODULO oMODULO)
        {
            foreach (MODELO.SUBMODULO oSUBMODULO in oUSUARIO_ACTUAL.OBTENER_SUBMODULOS(oMODULO))
            {
                TreeNode stn = new TreeNode(oSUBMODULO.DESCRIPCION);
                stn.Tag = "0";
                nodo.Nodes.Add(stn);
                ARMA_FORMULARIOS(stn, oSUBMODULO);
            }
        }

        private void ARMA_FORMULARIOS(TreeNode nodo, MODELO.SUBMODULO oSUBMODULO)
        {
            foreach (MODELO.FORMULARIO oFORM in oUSUARIO_ACTUAL.OBTENER_FORMULARIOS(oSUBMODULO))
            {
                TreeNode stn = new TreeNode(oFORM.DESCRIPCION);
                stn.Tag = oFORM.CLASE;                
                nodo.Nodes.Add(stn);
            }
        }

        private void ITEM_CLICK(object sender, TreeNodeMouseClickEventArgs e)
        {
            // al hacer click en algún objeto ToolStripMenuItem
            // se dispara este evento
            // el atributo sender me permite identificar que opción
            // del menú generó el evento
            //TreeView tv = (TreeView)sender;
            TreeNode seleccion = e.Node;
            // si el atributo tag es distinto de 0 es porque tiene definido 
            // el nombre dle formulario
            if ((string)seleccion.Tag != "0")
            {
                // le pido al compilador que me recupere todos los elementos del
                // asembly (proyecto VISTA)
                // comienzo a recorrer cada elemento devuelto
                foreach (System.Type type in Assembly.GetExecutingAssembly().GetTypes())
                {
                    //pregunto si es de tipo Formulario
                    if (type.IsSubclassOf(typeof(Form)))
                    {
                        // verifico si el nombre del formulario es igual al
                        // atributo tag que tiene el nombre del formulario
                        // a abrir
                        if (type.Name.ToString() == (string)seleccion.Tag)
                        {
                            try
                            {
                                //si corresponde creo una instancia de ese objeto
                                Type t = type as Type;
                                // aplicando reflection invoco el metodo getINSTANCIA del formulario
                                miFORM = (Form)t.InvokeMember("obtener_instancia", BindingFlags.Default | BindingFlags.Static | BindingFlags.Public | BindingFlags.InvokeMethod | BindingFlags.InvokeMethod, null, null, new object[] { this.oUSUARIO_ACTUAL }) as System.Windows.Forms.Form;
                                //ejecuto el método show del formulario para que lo muestre
                                miFORM.Show();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                    }
                }
            }
        }

        private void cmdEXIT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMISDATOS_Click(object sender, EventArgs e)
        {
            frmDATOS_USUARIO formDU = new frmDATOS_USUARIO(oUSUARIO_ACTUAL);
            DialogResult dr = formDU.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                oUSUARIO_ACTUAL = formDU.DATOS_ACTUALIZADOS;
                lblNOMBRE.Text = oUSUARIO_ACTUAL.NOMBRE;
                lblCUENTA.Text = oUSUARIO_ACTUAL.NOMBRE_USUARIO;
                lblEMAIL.Text = oUSUARIO_ACTUAL.EMAIL;
                Image image = Image.FromFile(CONTROLADORA.funciones_compartidas.DIRECTORIO_IMAGENES() + oUSUARIO_ACTUAL.IMAGEN);
                pbUSUARIO.Image = CONTROLADORA.funciones_compartidas.resizeImage(image, new Size(pbUSUARIO.Width, pbUSUARIO.Height));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CAMBIAR_CLAVE();
        }

        private void CAMBIAR_CLAVE()
        {
            Seguridad.frmCAMBIAR_CLAVE formCAMBIAR_CLAVE = Seguridad.frmCAMBIAR_CLAVE.obtener_instancia(oUSUARIO_ACTUAL);
            DialogResult dr = formCAMBIAR_CLAVE.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                MessageBox.Show("La contraseña ha sido cambiada exitosamente, la misma será válida a partir del próximo inicio de sesión", "Cambio de contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCERRAR_SESION_Click(object sender, EventArgs e)
        {

            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                if (Application.OpenForms[i].Name != "MENU_PRINCIPAL")
                    Application.OpenForms[i].Close();
            }
            ARMA_LOGIN();
        }     
    }
}
