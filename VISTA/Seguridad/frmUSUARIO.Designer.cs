namespace VISTA.Seguridad
{
    partial class frmUSUARIO
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUSUARIO));
            this.label8 = new System.Windows.Forms.Label();
            this.txtEMAIL = new System.Windows.Forms.TextBox();
            this.chkEstado = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCODIGO = new System.Windows.Forms.TextBox();
            this.chkGRUPOS = new System.Windows.Forms.CheckedListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabGRUPOS = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pDATOS = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTELEFONO = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNOMBRE_USUARIO = new System.Windows.Forms.TextBox();
            this.txtNOMBRE = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnCANCELAR = new System.Windows.Forms.Button();
            this.btnGUARDAR = new System.Windows.Forms.Button();
            this.tabDATOS = new System.Windows.Forms.TabControl();
            this.pbUSUARIO = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblIMAGEN = new System.Windows.Forms.Label();
            this.lblDIR_IMAGEN = new System.Windows.Forms.Label();
            this.btnCAMBIAR_IMAGEN = new System.Windows.Forms.Button();
            this.tabGRUPOS.SuspendLayout();
            this.pDATOS.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabDATOS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUSUARIO)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Email:";
            // 
            // txtEMAIL
            // 
            this.txtEMAIL.Location = new System.Drawing.Point(102, 105);
            this.txtEMAIL.Name = "txtEMAIL";
            this.txtEMAIL.Size = new System.Drawing.Size(365, 20);
            this.txtEMAIL.TabIndex = 10;
            // 
            // chkEstado
            // 
            this.chkEstado.AutoSize = true;
            this.chkEstado.Location = new System.Drawing.Point(102, 164);
            this.chkEstado.Name = "chkEstado";
            this.chkEstado.Size = new System.Drawing.Size(56, 17);
            this.chkEstado.TabIndex = 6;
            this.chkEstado.Text = "Activo";
            this.chkEstado.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Estado:";
            // 
            // txtCODIGO
            // 
            this.txtCODIGO.Location = new System.Drawing.Point(102, 22);
            this.txtCODIGO.Name = "txtCODIGO";
            this.txtCODIGO.ReadOnly = true;
            this.txtCODIGO.Size = new System.Drawing.Size(145, 20);
            this.txtCODIGO.TabIndex = 7;
            // 
            // chkGRUPOS
            // 
            this.chkGRUPOS.FormattingEnabled = true;
            this.chkGRUPOS.Location = new System.Drawing.Point(30, 19);
            this.chkGRUPOS.Name = "chkGRUPOS";
            this.chkGRUPOS.Size = new System.Drawing.Size(383, 304);
            this.chkGRUPOS.TabIndex = 7;
            this.chkGRUPOS.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.chkGRUPOS_ItemCheck);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Grupos:";
            // 
            // tabGRUPOS
            // 
            this.tabGRUPOS.Controls.Add(this.chkGRUPOS);
            this.tabGRUPOS.Controls.Add(this.label6);
            this.tabGRUPOS.Location = new System.Drawing.Point(4, 22);
            this.tabGRUPOS.Name = "tabGRUPOS";
            this.tabGRUPOS.Padding = new System.Windows.Forms.Padding(3);
            this.tabGRUPOS.Size = new System.Drawing.Size(539, 326);
            this.tabGRUPOS.TabIndex = 2;
            this.tabGRUPOS.Text = "Grupos";
            this.tabGRUPOS.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // pDATOS
            // 
            this.pDATOS.Controls.Add(this.btnCAMBIAR_IMAGEN);
            this.pDATOS.Controls.Add(this.lblDIR_IMAGEN);
            this.pDATOS.Controls.Add(this.lblIMAGEN);
            this.pDATOS.Controls.Add(this.label4);
            this.pDATOS.Controls.Add(this.pbUSUARIO);
            this.pDATOS.Controls.Add(this.label10);
            this.pDATOS.Controls.Add(this.txtTELEFONO);
            this.pDATOS.Controls.Add(this.label9);
            this.pDATOS.Controls.Add(this.txtNOMBRE_USUARIO);
            this.pDATOS.Controls.Add(this.label8);
            this.pDATOS.Controls.Add(this.txtEMAIL);
            this.pDATOS.Controls.Add(this.chkEstado);
            this.pDATOS.Controls.Add(this.label3);
            this.pDATOS.Controls.Add(this.txtCODIGO);
            this.pDATOS.Controls.Add(this.label1);
            this.pDATOS.Controls.Add(this.label2);
            this.pDATOS.Controls.Add(this.txtNOMBRE);
            this.pDATOS.Location = new System.Drawing.Point(6, 6);
            this.pDATOS.Name = "pDATOS";
            this.pDATOS.Size = new System.Drawing.Size(518, 314);
            this.pDATOS.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 134);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Teléfono:";
            // 
            // txtTELEFONO
            // 
            this.txtTELEFONO.Location = new System.Drawing.Point(102, 131);
            this.txtTELEFONO.Name = "txtTELEFONO";
            this.txtTELEFONO.Size = new System.Drawing.Size(365, 20);
            this.txtTELEFONO.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Usuario:";
            // 
            // txtNOMBRE_USUARIO
            // 
            this.txtNOMBRE_USUARIO.Location = new System.Drawing.Point(102, 48);
            this.txtNOMBRE_USUARIO.Name = "txtNOMBRE_USUARIO";
            this.txtNOMBRE_USUARIO.Size = new System.Drawing.Size(365, 20);
            this.txtNOMBRE_USUARIO.TabIndex = 8;
            // 
            // txtNOMBRE
            // 
            this.txtNOMBRE.Location = new System.Drawing.Point(102, 74);
            this.txtNOMBRE.Name = "txtNOMBRE";
            this.txtNOMBRE.Size = new System.Drawing.Size(365, 20);
            this.txtNOMBRE.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pDATOS);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(539, 326);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Datos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnCANCELAR
            // 
            this.btnCANCELAR.Image = ((System.Drawing.Image)(resources.GetObject("btnCANCELAR.Image")));
            this.btnCANCELAR.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCANCELAR.Location = new System.Drawing.Point(454, 370);
            this.btnCANCELAR.Name = "btnCANCELAR";
            this.btnCANCELAR.Size = new System.Drawing.Size(101, 62);
            this.btnCANCELAR.TabIndex = 2;
            this.btnCANCELAR.Text = "Cancelar";
            this.btnCANCELAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCANCELAR.UseVisualStyleBackColor = true;
            this.btnCANCELAR.Click += new System.EventHandler(this.btnCANCELAR_Click);
            // 
            // btnGUARDAR
            // 
            this.btnGUARDAR.Image = ((System.Drawing.Image)(resources.GetObject("btnGUARDAR.Image")));
            this.btnGUARDAR.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGUARDAR.Location = new System.Drawing.Point(341, 370);
            this.btnGUARDAR.Name = "btnGUARDAR";
            this.btnGUARDAR.Size = new System.Drawing.Size(107, 62);
            this.btnGUARDAR.TabIndex = 1;
            this.btnGUARDAR.Text = "Guardar";
            this.btnGUARDAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGUARDAR.UseVisualStyleBackColor = true;
            this.btnGUARDAR.Click += new System.EventHandler(this.btnGUARDAR_Click);
            // 
            // tabDATOS
            // 
            this.tabDATOS.Controls.Add(this.tabPage1);
            this.tabDATOS.Controls.Add(this.tabGRUPOS);
            this.tabDATOS.Location = new System.Drawing.Point(12, 12);
            this.tabDATOS.Name = "tabDATOS";
            this.tabDATOS.SelectedIndex = 0;
            this.tabDATOS.Size = new System.Drawing.Size(547, 352);
            this.tabDATOS.TabIndex = 0;
            // 
            // pbUSUARIO
            // 
            this.pbUSUARIO.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbUSUARIO.InitialImage")));
            this.pbUSUARIO.Location = new System.Drawing.Point(102, 187);
            this.pbUSUARIO.Name = "pbUSUARIO";
            this.pbUSUARIO.Size = new System.Drawing.Size(149, 109);
            this.pbUSUARIO.TabIndex = 13;
            this.pbUSUARIO.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Imagen:";
            // 
            // lblIMAGEN
            // 
            this.lblIMAGEN.AutoSize = true;
            this.lblIMAGEN.Location = new System.Drawing.Point(257, 187);
            this.lblIMAGEN.Name = "lblIMAGEN";
            this.lblIMAGEN.Size = new System.Drawing.Size(0, 13);
            this.lblIMAGEN.TabIndex = 15;
            this.lblIMAGEN.Visible = false;
            // 
            // lblDIR_IMAGEN
            // 
            this.lblDIR_IMAGEN.AutoSize = true;
            this.lblDIR_IMAGEN.Location = new System.Drawing.Point(257, 221);
            this.lblDIR_IMAGEN.Name = "lblDIR_IMAGEN";
            this.lblDIR_IMAGEN.Size = new System.Drawing.Size(0, 13);
            this.lblDIR_IMAGEN.TabIndex = 16;
            this.lblDIR_IMAGEN.Visible = false;
            // 
            // btnCAMBIAR_IMAGEN
            // 
            this.btnCAMBIAR_IMAGEN.Location = new System.Drawing.Point(268, 251);
            this.btnCAMBIAR_IMAGEN.Name = "btnCAMBIAR_IMAGEN";
            this.btnCAMBIAR_IMAGEN.Size = new System.Drawing.Size(92, 44);
            this.btnCAMBIAR_IMAGEN.TabIndex = 12;
            this.btnCAMBIAR_IMAGEN.Text = "Cambiar imagen";
            this.btnCAMBIAR_IMAGEN.UseVisualStyleBackColor = true;
            this.btnCAMBIAR_IMAGEN.Click += new System.EventHandler(this.btnCAMBIAR_IMAGEN_Click);
            // 
            // frmUSUARIO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 439);
            this.Controls.Add(this.btnCANCELAR);
            this.Controls.Add(this.btnGUARDAR);
            this.Controls.Add(this.tabDATOS);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmUSUARIO";
            this.Text = "::.. GESTION DE USUARIO";
            this.Load += new System.EventHandler(this.frmUSUARIO_Load);
            this.tabGRUPOS.ResumeLayout(false);
            this.tabGRUPOS.PerformLayout();
            this.pDATOS.ResumeLayout(false);
            this.pDATOS.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabDATOS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbUSUARIO)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEMAIL;
        private System.Windows.Forms.CheckBox chkEstado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCODIGO;
        private System.Windows.Forms.CheckedListBox chkGRUPOS;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tabGRUPOS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pDATOS;
        private System.Windows.Forms.TextBox txtNOMBRE;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnCANCELAR;
        private System.Windows.Forms.Button btnGUARDAR;
        private System.Windows.Forms.TabControl tabDATOS;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTELEFONO;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNOMBRE_USUARIO;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pbUSUARIO;
        private System.Windows.Forms.Label lblIMAGEN;
        private System.Windows.Forms.Label lblDIR_IMAGEN;
        private System.Windows.Forms.Button btnCAMBIAR_IMAGEN;
    }
}