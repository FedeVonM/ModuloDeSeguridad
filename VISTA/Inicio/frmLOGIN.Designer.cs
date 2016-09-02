namespace VISTA.Inicio
{
    partial class frmLOGIN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLOGIN));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUSUARIO = new System.Windows.Forms.TextBox();
            this.txtPASSWORD = new System.Windows.Forms.TextBox();
            this.btnINGRESAR = new System.Windows.Forms.Button();
            this.btnCANCELAR = new System.Windows.Forms.Button();
            this.lblMENSAJE_LOGIN = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblERROR_RECUPERAR = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(172, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "ACCESO AL SISTEMA :: VALIDACION DE USUARIO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(145, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre de Usuario:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(145, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Contraseña de acceso:";
            // 
            // txtUSUARIO
            // 
            this.txtUSUARIO.Location = new System.Drawing.Point(270, 56);
            this.txtUSUARIO.Name = "txtUSUARIO";
            this.txtUSUARIO.Size = new System.Drawing.Size(227, 20);
            this.txtUSUARIO.TabIndex = 3;
            // 
            // txtPASSWORD
            // 
            this.txtPASSWORD.Location = new System.Drawing.Point(270, 85);
            this.txtPASSWORD.Name = "txtPASSWORD";
            this.txtPASSWORD.PasswordChar = '*';
            this.txtPASSWORD.Size = new System.Drawing.Size(227, 20);
            this.txtPASSWORD.TabIndex = 4;
            // 
            // btnINGRESAR
            // 
            this.btnINGRESAR.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnINGRESAR.Image = ((System.Drawing.Image)(resources.GetObject("btnINGRESAR.Image")));
            this.btnINGRESAR.Location = new System.Drawing.Point(255, 168);
            this.btnINGRESAR.Name = "btnINGRESAR";
            this.btnINGRESAR.Size = new System.Drawing.Size(114, 79);
            this.btnINGRESAR.TabIndex = 5;
            this.btnINGRESAR.Text = "Ingresar";
            this.btnINGRESAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnINGRESAR.UseVisualStyleBackColor = true;
            this.btnINGRESAR.Click += new System.EventHandler(this.btnINGRESAR_Click);
            // 
            // btnCANCELAR
            // 
            this.btnCANCELAR.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnCANCELAR.Image = ((System.Drawing.Image)(resources.GetObject("btnCANCELAR.Image")));
            this.btnCANCELAR.Location = new System.Drawing.Point(383, 168);
            this.btnCANCELAR.Name = "btnCANCELAR";
            this.btnCANCELAR.Size = new System.Drawing.Size(114, 79);
            this.btnCANCELAR.TabIndex = 6;
            this.btnCANCELAR.Text = "Cancelar";
            this.btnCANCELAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCANCELAR.UseVisualStyleBackColor = true;
            this.btnCANCELAR.Click += new System.EventHandler(this.btnCANCELAR_Click);
            // 
            // lblMENSAJE_LOGIN
            // 
            this.lblMENSAJE_LOGIN.AutoSize = true;
            this.lblMENSAJE_LOGIN.ForeColor = System.Drawing.Color.DarkRed;
            this.lblMENSAJE_LOGIN.Location = new System.Drawing.Point(145, 121);
            this.lblMENSAJE_LOGIN.Name = "lblMENSAJE_LOGIN";
            this.lblMENSAJE_LOGIN.Size = new System.Drawing.Size(0, 13);
            this.lblMENSAJE_LOGIN.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(12, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(208, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Olvide mi Nombre de Usuario / contraseña";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblERROR_RECUPERAR
            // 
            this.lblERROR_RECUPERAR.ForeColor = System.Drawing.Color.DarkRed;
            this.lblERROR_RECUPERAR.Location = new System.Drawing.Point(15, 151);
            this.lblERROR_RECUPERAR.Name = "lblERROR_RECUPERAR";
            this.lblERROR_RECUPERAR.Size = new System.Drawing.Size(234, 83);
            this.lblERROR_RECUPERAR.TabIndex = 9;
            // 
            // frmLOGIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(516, 259);
            this.Controls.Add(this.lblERROR_RECUPERAR);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblMENSAJE_LOGIN);
            this.Controls.Add(this.btnCANCELAR);
            this.Controls.Add(this.btnINGRESAR);
            this.Controls.Add(this.txtPASSWORD);
            this.Controls.Add(this.txtUSUARIO);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLOGIN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLOGIN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUSUARIO;
        private System.Windows.Forms.TextBox txtPASSWORD;
        private System.Windows.Forms.Button btnINGRESAR;
        private System.Windows.Forms.Button btnCANCELAR;
        private System.Windows.Forms.Label lblMENSAJE_LOGIN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblERROR_RECUPERAR;
    }
}