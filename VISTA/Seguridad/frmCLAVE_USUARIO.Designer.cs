namespace VISTA.Seguridad
{
    partial class frmCLAVE_USUARIO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCLAVE_USUARIO));
            this.btnCANCELAR = new System.Windows.Forms.Button();
            this.btnGUARDAR = new System.Windows.Forms.Button();
            this.pCLAVE = new System.Windows.Forms.Panel();
            this.txtEMAIL = new System.Windows.Forms.TextBox();
            this.chkEMAIL = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNOMBRE_USUARIO = new System.Windows.Forms.TextBox();
            this.txtNOMBRE = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPASSWORD2 = new System.Windows.Forms.TextBox();
            this.chkRESETEAR_CLAVE = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPASSWORD = new System.Windows.Forms.TextBox();
            this.btnGENERAR_CLAVE = new System.Windows.Forms.Button();
            this.pCLAVE.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCANCELAR
            // 
            this.btnCANCELAR.Image = ((System.Drawing.Image)(resources.GetObject("btnCANCELAR.Image")));
            this.btnCANCELAR.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCANCELAR.Location = new System.Drawing.Point(421, 234);
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
            this.btnGUARDAR.Location = new System.Drawing.Point(308, 234);
            this.btnGUARDAR.Name = "btnGUARDAR";
            this.btnGUARDAR.Size = new System.Drawing.Size(107, 62);
            this.btnGUARDAR.TabIndex = 1;
            this.btnGUARDAR.Text = "Guardar";
            this.btnGUARDAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGUARDAR.UseVisualStyleBackColor = true;
            this.btnGUARDAR.Click += new System.EventHandler(this.btnGUARDAR_Click);
            // 
            // pCLAVE
            // 
            this.pCLAVE.Controls.Add(this.btnGENERAR_CLAVE);
            this.pCLAVE.Controls.Add(this.txtEMAIL);
            this.pCLAVE.Controls.Add(this.chkEMAIL);
            this.pCLAVE.Controls.Add(this.label2);
            this.pCLAVE.Controls.Add(this.txtNOMBRE_USUARIO);
            this.pCLAVE.Controls.Add(this.txtNOMBRE);
            this.pCLAVE.Controls.Add(this.label1);
            this.pCLAVE.Controls.Add(this.txtPASSWORD2);
            this.pCLAVE.Controls.Add(this.chkRESETEAR_CLAVE);
            this.pCLAVE.Controls.Add(this.label4);
            this.pCLAVE.Controls.Add(this.label11);
            this.pCLAVE.Controls.Add(this.label5);
            this.pCLAVE.Controls.Add(this.label7);
            this.pCLAVE.Controls.Add(this.txtPASSWORD);
            this.pCLAVE.Location = new System.Drawing.Point(12, 12);
            this.pCLAVE.Name = "pCLAVE";
            this.pCLAVE.Size = new System.Drawing.Size(510, 216);
            this.pCLAVE.TabIndex = 0;
            // 
            // txtEMAIL
            // 
            this.txtEMAIL.Location = new System.Drawing.Point(134, 169);
            this.txtEMAIL.Name = "txtEMAIL";
            this.txtEMAIL.ReadOnly = true;
            this.txtEMAIL.Size = new System.Drawing.Size(344, 20);
            this.txtEMAIL.TabIndex = 19;
            // 
            // chkEMAIL
            // 
            this.chkEMAIL.AutoSize = true;
            this.chkEMAIL.Location = new System.Drawing.Point(134, 146);
            this.chkEMAIL.Name = "chkEMAIL";
            this.chkEMAIL.Size = new System.Drawing.Size(201, 17);
            this.chkEMAIL.TabIndex = 18;
            this.chkEMAIL.Text = "Enviar contraseña al mail del usuario:";
            this.chkEMAIL.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Enviar email:";
            // 
            // txtNOMBRE_USUARIO
            // 
            this.txtNOMBRE_USUARIO.Location = new System.Drawing.Point(69, 33);
            this.txtNOMBRE_USUARIO.Name = "txtNOMBRE_USUARIO";
            this.txtNOMBRE_USUARIO.ReadOnly = true;
            this.txtNOMBRE_USUARIO.Size = new System.Drawing.Size(280, 20);
            this.txtNOMBRE_USUARIO.TabIndex = 16;
            // 
            // txtNOMBRE
            // 
            this.txtNOMBRE.Location = new System.Drawing.Point(184, 3);
            this.txtNOMBRE.Name = "txtNOMBRE";
            this.txtNOMBRE.ReadOnly = true;
            this.txtNOMBRE.Size = new System.Drawing.Size(294, 20);
            this.txtNOMBRE.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Cuenta:";
            // 
            // txtPASSWORD2
            // 
            this.txtPASSWORD2.Location = new System.Drawing.Point(134, 97);
            this.txtPASSWORD2.Name = "txtPASSWORD2";
            this.txtPASSWORD2.PasswordChar = '*';
            this.txtPASSWORD2.Size = new System.Drawing.Size(215, 20);
            this.txtPASSWORD2.TabIndex = 1;
            // 
            // chkRESETEAR_CLAVE
            // 
            this.chkRESETEAR_CLAVE.AutoSize = true;
            this.chkRESETEAR_CLAVE.Location = new System.Drawing.Point(134, 123);
            this.chkRESETEAR_CLAVE.Name = "chkRESETEAR_CLAVE";
            this.chkRESETEAR_CLAVE.Size = new System.Drawing.Size(200, 17);
            this.chkRESETEAR_CLAVE.TabIndex = 13;
            this.chkRESETEAR_CLAVE.Text = "Resetar contraseña en próximo inicio";
            this.chkRESETEAR_CLAVE.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Resetear contraseña del usuario:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 124);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "Cambiar clave:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Nueva contraseña:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Repetir contraseña:";
            // 
            // txtPASSWORD
            // 
            this.txtPASSWORD.Location = new System.Drawing.Point(134, 66);
            this.txtPASSWORD.Name = "txtPASSWORD";
            this.txtPASSWORD.PasswordChar = '*';
            this.txtPASSWORD.Size = new System.Drawing.Size(215, 20);
            this.txtPASSWORD.TabIndex = 0;
            // 
            // btnGENERAR_CLAVE
            // 
            this.btnGENERAR_CLAVE.Image = ((System.Drawing.Image)(resources.GetObject("btnGENERAR_CLAVE.Image")));
            this.btnGENERAR_CLAVE.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGENERAR_CLAVE.Location = new System.Drawing.Point(373, 66);
            this.btnGENERAR_CLAVE.Name = "btnGENERAR_CLAVE";
            this.btnGENERAR_CLAVE.Size = new System.Drawing.Size(105, 50);
            this.btnGENERAR_CLAVE.TabIndex = 20;
            this.btnGENERAR_CLAVE.Text = "Generar clave";
            this.btnGENERAR_CLAVE.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGENERAR_CLAVE.UseVisualStyleBackColor = true;
            this.btnGENERAR_CLAVE.Click += new System.EventHandler(this.btnGENERAR_CLAVE_Click);
            // 
            // frmCLAVE_USUARIO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 308);
            this.Controls.Add(this.btnCANCELAR);
            this.Controls.Add(this.btnGUARDAR);
            this.Controls.Add(this.pCLAVE);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCLAVE_USUARIO";
            this.Text = "::.. CAMBIAR CLAVE DE USUARIO";
            this.pCLAVE.ResumeLayout(false);
            this.pCLAVE.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCANCELAR;
        private System.Windows.Forms.Button btnGUARDAR;
        private System.Windows.Forms.Panel pCLAVE;
        private System.Windows.Forms.TextBox txtPASSWORD2;
        private System.Windows.Forms.CheckBox chkRESETEAR_CLAVE;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPASSWORD;
        private System.Windows.Forms.TextBox txtNOMBRE_USUARIO;
        private System.Windows.Forms.TextBox txtNOMBRE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEMAIL;
        private System.Windows.Forms.CheckBox chkEMAIL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGENERAR_CLAVE;
    }
}