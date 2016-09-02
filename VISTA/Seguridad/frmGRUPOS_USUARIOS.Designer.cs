namespace VISTA.Seguridad
{
    partial class frmGRUPOS_USUARIOS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGRUPOS_USUARIOS));
            this.dgvDATA = new System.Windows.Forms.DataGridView();
            this.btnCONSULTAS = new System.Windows.Forms.Button();
            this.btnBAJAS = new System.Windows.Forms.Button();
            this.btnMODIFICACIONES = new System.Windows.Forms.Button();
            this.btnALTAS = new System.Windows.Forms.Button();
            this.btnCERRAR = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDESCRIPCION = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkINACTIVOS = new System.Windows.Forms.CheckBox();
            this.btnBUSCAR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDATA)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDATA
            // 
            this.dgvDATA.AllowUserToAddRows = false;
            this.dgvDATA.AllowUserToDeleteRows = false;
            this.dgvDATA.AllowUserToOrderColumns = true;
            this.dgvDATA.AllowUserToResizeRows = false;
            this.dgvDATA.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDATA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDATA.Location = new System.Drawing.Point(12, 105);
            this.dgvDATA.Name = "dgvDATA";
            this.dgvDATA.ReadOnly = true;
            this.dgvDATA.Size = new System.Drawing.Size(827, 331);
            this.dgvDATA.TabIndex = 2;
            // 
            // btnCONSULTAS
            // 
            this.btnCONSULTAS.Image = ((System.Drawing.Image)(resources.GetObject("btnCONSULTAS.Image")));
            this.btnCONSULTAS.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCONSULTAS.Location = new System.Drawing.Point(305, 442);
            this.btnCONSULTAS.Name = "btnCONSULTAS";
            this.btnCONSULTAS.Size = new System.Drawing.Size(91, 60);
            this.btnCONSULTAS.TabIndex = 14;
            this.btnCONSULTAS.Text = "&Ver Detalle";
            this.btnCONSULTAS.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCONSULTAS.UseVisualStyleBackColor = true;
            this.btnCONSULTAS.Click += new System.EventHandler(this.btnCONSULTAS_Click);
            // 
            // btnBAJAS
            // 
            this.btnBAJAS.Image = ((System.Drawing.Image)(resources.GetObject("btnBAJAS.Image")));
            this.btnBAJAS.Location = new System.Drawing.Point(111, 442);
            this.btnBAJAS.Name = "btnBAJAS";
            this.btnBAJAS.Size = new System.Drawing.Size(91, 60);
            this.btnBAJAS.TabIndex = 12;
            this.btnBAJAS.Text = "&Eliminar";
            this.btnBAJAS.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBAJAS.UseVisualStyleBackColor = true;
            this.btnBAJAS.Click += new System.EventHandler(this.btnBAJAS_Click);
            // 
            // btnMODIFICACIONES
            // 
            this.btnMODIFICACIONES.Image = ((System.Drawing.Image)(resources.GetObject("btnMODIFICACIONES.Image")));
            this.btnMODIFICACIONES.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMODIFICACIONES.Location = new System.Drawing.Point(208, 442);
            this.btnMODIFICACIONES.Name = "btnMODIFICACIONES";
            this.btnMODIFICACIONES.Size = new System.Drawing.Size(91, 60);
            this.btnMODIFICACIONES.TabIndex = 13;
            this.btnMODIFICACIONES.Text = "&Modificar";
            this.btnMODIFICACIONES.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMODIFICACIONES.UseVisualStyleBackColor = true;
            this.btnMODIFICACIONES.Click += new System.EventHandler(this.btnMODIFICACIONES_Click);
            // 
            // btnALTAS
            // 
            this.btnALTAS.Image = ((System.Drawing.Image)(resources.GetObject("btnALTAS.Image")));
            this.btnALTAS.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnALTAS.Location = new System.Drawing.Point(12, 442);
            this.btnALTAS.Name = "btnALTAS";
            this.btnALTAS.Size = new System.Drawing.Size(93, 60);
            this.btnALTAS.TabIndex = 11;
            this.btnALTAS.Text = "&Agregar";
            this.btnALTAS.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnALTAS.UseVisualStyleBackColor = true;
            this.btnALTAS.Click += new System.EventHandler(this.btnALTAS_Click);
            // 
            // btnCERRAR
            // 
            this.btnCERRAR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCERRAR.Image = ((System.Drawing.Image)(resources.GetObject("btnCERRAR.Image")));
            this.btnCERRAR.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCERRAR.Location = new System.Drawing.Point(745, 442);
            this.btnCERRAR.Name = "btnCERRAR";
            this.btnCERRAR.Size = new System.Drawing.Size(94, 60);
            this.btnCERRAR.TabIndex = 15;
            this.btnCERRAR.Text = "&Cerrar";
            this.btnCERRAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCERRAR.UseVisualStyleBackColor = true;
            this.btnCERRAR.Click += new System.EventHandler(this.btnCERRAR_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Descripción:";
            // 
            // txtDESCRIPCION
            // 
            this.txtDESCRIPCION.Location = new System.Drawing.Point(93, 29);
            this.txtDESCRIPCION.Name = "txtDESCRIPCION";
            this.txtDESCRIPCION.Size = new System.Drawing.Size(415, 20);
            this.txtDESCRIPCION.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Inactivos:";
            // 
            // chkINACTIVOS
            // 
            this.chkINACTIVOS.AutoSize = true;
            this.chkINACTIVOS.Location = new System.Drawing.Point(93, 65);
            this.chkINACTIVOS.Name = "chkINACTIVOS";
            this.chkINACTIVOS.Size = new System.Drawing.Size(141, 17);
            this.chkINACTIVOS.TabIndex = 19;
            this.chkINACTIVOS.Text = "Mostrar grupos inactivos";
            this.chkINACTIVOS.UseVisualStyleBackColor = true;
            // 
            // btnBUSCAR
            // 
            this.btnBUSCAR.Image = ((System.Drawing.Image)(resources.GetObject("btnBUSCAR.Image")));
            this.btnBUSCAR.Location = new System.Drawing.Point(679, 13);
            this.btnBUSCAR.Name = "btnBUSCAR";
            this.btnBUSCAR.Size = new System.Drawing.Size(160, 70);
            this.btnBUSCAR.TabIndex = 20;
            this.btnBUSCAR.Text = "Buscar";
            this.btnBUSCAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBUSCAR.UseVisualStyleBackColor = true;
            this.btnBUSCAR.Click += new System.EventHandler(this.btnBUSCAR_Click);
            // 
            // frmGRUPOS_USUARIOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 514);
            this.Controls.Add(this.btnBUSCAR);
            this.Controls.Add(this.chkINACTIVOS);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDESCRIPCION);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCONSULTAS);
            this.Controls.Add(this.btnBAJAS);
            this.Controls.Add(this.btnMODIFICACIONES);
            this.Controls.Add(this.btnALTAS);
            this.Controls.Add(this.btnCERRAR);
            this.Controls.Add(this.dgvDATA);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmGRUPOS_USUARIOS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "::.. GESTION DE GRUPOS DE USUARIOS";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDATA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDATA;        
        private System.Windows.Forms.Button btnCONSULTAS;
        
        private System.Windows.Forms.Button btnBAJAS;
        private System.Windows.Forms.Button btnMODIFICACIONES;        
        private System.Windows.Forms.Button btnALTAS;
        private System.Windows.Forms.Button btnCERRAR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDESCRIPCION;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkINACTIVOS;
        private System.Windows.Forms.Button btnBUSCAR;
    }
}