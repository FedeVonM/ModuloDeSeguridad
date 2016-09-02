namespace VISTA.Inicio
{
    partial class frmRECUPERAR_CLAVE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRECUPERAR_CLAVE));
            this.label1 = new System.Windows.Forms.Label();
            this.txtEMAIL = new System.Windows.Forms.TextBox();
            this.btnRECUPERAR = new System.Windows.Forms.Button();
            this.btnCANCELAR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dirección de correo electrónico:";
            // 
            // txtEMAIL
            // 
            this.txtEMAIL.Location = new System.Drawing.Point(185, 24);
            this.txtEMAIL.Name = "txtEMAIL";
            this.txtEMAIL.Size = new System.Drawing.Size(318, 20);
            this.txtEMAIL.TabIndex = 1;
            // 
            // btnRECUPERAR
            // 
            this.btnRECUPERAR.Image = ((System.Drawing.Image)(resources.GetObject("btnRECUPERAR.Image")));
            this.btnRECUPERAR.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRECUPERAR.Location = new System.Drawing.Point(278, 89);
            this.btnRECUPERAR.Name = "btnRECUPERAR";
            this.btnRECUPERAR.Size = new System.Drawing.Size(112, 71);
            this.btnRECUPERAR.TabIndex = 2;
            this.btnRECUPERAR.Text = "Recuperar Clave";
            this.btnRECUPERAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRECUPERAR.UseVisualStyleBackColor = true;
            this.btnRECUPERAR.Click += new System.EventHandler(this.btnRECUPERAR_Click);
            // 
            // btnCANCELAR
            // 
            this.btnCANCELAR.Image = ((System.Drawing.Image)(resources.GetObject("btnCANCELAR.Image")));
            this.btnCANCELAR.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCANCELAR.Location = new System.Drawing.Point(398, 89);
            this.btnCANCELAR.Name = "btnCANCELAR";
            this.btnCANCELAR.Size = new System.Drawing.Size(105, 71);
            this.btnCANCELAR.TabIndex = 5;
            this.btnCANCELAR.Text = "Cancelar";
            this.btnCANCELAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCANCELAR.UseVisualStyleBackColor = true;
            this.btnCANCELAR.Click += new System.EventHandler(this.btnCANCELAR_Click);
            // 
            // frmRECUPERAR_CLAVE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 172);
            this.Controls.Add(this.btnCANCELAR);
            this.Controls.Add(this.btnRECUPERAR);
            this.Controls.Add(this.txtEMAIL);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmRECUPERAR_CLAVE";
            this.Text = "::.. RECUPERAR DATOS DE USUARIO Y CONTRASEÑA DE ACCESO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEMAIL;
        private System.Windows.Forms.Button btnRECUPERAR;
        private System.Windows.Forms.Button btnCANCELAR;
    }
}