namespace VISTA.Seguridad
{
    partial class frmUSUARIOS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUSUARIOS));
            this.btnCONSULTAS = new System.Windows.Forms.Button();
            this.btnBAJAS = new System.Windows.Forms.Button();
            this.btnMODIFICACIONES = new System.Windows.Forms.Button();
            this.btnALTAS = new System.Windows.Forms.Button();
            this.btnCERRAR = new System.Windows.Forms.Button();
            this.dgvDATA = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btnBUSCAR = new System.Windows.Forms.Button();
            this.chkINACTIVOS = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDESCRIPCION = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rbTODOS = new System.Windows.Forms.RadioButton();
            this.rbSELECCION = new System.Windows.Forms.RadioButton();
            this.cmbGRUPO = new System.Windows.Forms.ComboBox();
            this.btnRESETEAR_CLAVE = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDATA)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCONSULTAS
            // 
            this.btnCONSULTAS.Image = ((System.Drawing.Image)(resources.GetObject("btnCONSULTAS.Image")));
            this.btnCONSULTAS.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCONSULTAS.Location = new System.Drawing.Point(394, 403);
            this.btnCONSULTAS.Name = "btnCONSULTAS";
            this.btnCONSULTAS.Size = new System.Drawing.Size(91, 60);
            this.btnCONSULTAS.TabIndex = 20;
            this.btnCONSULTAS.Text = "&Ver Detalle";
            this.btnCONSULTAS.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCONSULTAS.UseVisualStyleBackColor = true;
            this.btnCONSULTAS.Click += new System.EventHandler(this.btnCONSULTAS_Click);
            // 
            // btnBAJAS
            // 
            this.btnBAJAS.Image = ((System.Drawing.Image)(resources.GetObject("btnBAJAS.Image")));
            this.btnBAJAS.Location = new System.Drawing.Point(103, 403);
            this.btnBAJAS.Name = "btnBAJAS";
            this.btnBAJAS.Size = new System.Drawing.Size(91, 60);
            this.btnBAJAS.TabIndex = 18;
            this.btnBAJAS.Text = "&Eliminar";
            this.btnBAJAS.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBAJAS.UseVisualStyleBackColor = true;
            this.btnBAJAS.Click += new System.EventHandler(this.btnBAJAS_Click);
            // 
            // btnMODIFICACIONES
            // 
            this.btnMODIFICACIONES.Image = ((System.Drawing.Image)(resources.GetObject("btnMODIFICACIONES.Image")));
            this.btnMODIFICACIONES.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMODIFICACIONES.Location = new System.Drawing.Point(200, 403);
            this.btnMODIFICACIONES.Name = "btnMODIFICACIONES";
            this.btnMODIFICACIONES.Size = new System.Drawing.Size(91, 60);
            this.btnMODIFICACIONES.TabIndex = 19;
            this.btnMODIFICACIONES.Text = "&Modificar";
            this.btnMODIFICACIONES.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMODIFICACIONES.UseVisualStyleBackColor = true;
            this.btnMODIFICACIONES.Click += new System.EventHandler(this.btnMODIFICACIONES_Click);
            // 
            // btnALTAS
            // 
            this.btnALTAS.Image = ((System.Drawing.Image)(resources.GetObject("btnALTAS.Image")));
            this.btnALTAS.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnALTAS.Location = new System.Drawing.Point(4, 403);
            this.btnALTAS.Name = "btnALTAS";
            this.btnALTAS.Size = new System.Drawing.Size(93, 60);
            this.btnALTAS.TabIndex = 17;
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
            this.btnCERRAR.Location = new System.Drawing.Point(843, 403);
            this.btnCERRAR.Name = "btnCERRAR";
            this.btnCERRAR.Size = new System.Drawing.Size(94, 60);
            this.btnCERRAR.TabIndex = 21;
            this.btnCERRAR.Text = "&Cerrar";
            this.btnCERRAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCERRAR.UseVisualStyleBackColor = true;
            // 
            // dgvDATA
            // 
            this.dgvDATA.AllowUserToAddRows = false;
            this.dgvDATA.AllowUserToDeleteRows = false;
            this.dgvDATA.AllowUserToOrderColumns = true;
            this.dgvDATA.AllowUserToResizeRows = false;
            this.dgvDATA.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDATA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDATA.Location = new System.Drawing.Point(4, 134);
            this.dgvDATA.Name = "dgvDATA";
            this.dgvDATA.ReadOnly = true;
            this.dgvDATA.Size = new System.Drawing.Size(827, 263);
            this.dgvDATA.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(737, 403);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 60);
            this.button1.TabIndex = 22;
            this.button1.Text = "&Cerrar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBUSCAR
            // 
            this.btnBUSCAR.Image = ((System.Drawing.Image)(resources.GetObject("btnBUSCAR.Image")));
            this.btnBUSCAR.Location = new System.Drawing.Point(665, 32);
            this.btnBUSCAR.Name = "btnBUSCAR";
            this.btnBUSCAR.Size = new System.Drawing.Size(160, 70);
            this.btnBUSCAR.TabIndex = 23;
            this.btnBUSCAR.Text = "Buscar";
            this.btnBUSCAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBUSCAR.UseVisualStyleBackColor = true;
            this.btnBUSCAR.Click += new System.EventHandler(this.btnBUSCAR_Click);
            // 
            // chkINACTIVOS
            // 
            this.chkINACTIVOS.AutoSize = true;
            this.chkINACTIVOS.Location = new System.Drawing.Point(103, 95);
            this.chkINACTIVOS.Name = "chkINACTIVOS";
            this.chkINACTIVOS.Size = new System.Drawing.Size(148, 17);
            this.chkINACTIVOS.TabIndex = 27;
            this.chkINACTIVOS.Text = "Mostrar usuarios inactivos";
            this.chkINACTIVOS.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Inactivos:";
            // 
            // txtDESCRIPCION
            // 
            this.txtDESCRIPCION.Location = new System.Drawing.Point(103, 29);
            this.txtDESCRIPCION.Name = "txtDESCRIPCION";
            this.txtDESCRIPCION.Size = new System.Drawing.Size(476, 20);
            this.txtDESCRIPCION.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Grupo:";
            // 
            // rbTODOS
            // 
            this.rbTODOS.AutoSize = true;
            this.rbTODOS.Checked = true;
            this.rbTODOS.Location = new System.Drawing.Point(103, 66);
            this.rbTODOS.Name = "rbTODOS";
            this.rbTODOS.Size = new System.Drawing.Size(106, 17);
            this.rbTODOS.TabIndex = 29;
            this.rbTODOS.TabStop = true;
            this.rbTODOS.Text = "Todos los grupos";
            this.rbTODOS.UseVisualStyleBackColor = true;
            this.rbTODOS.CheckedChanged += new System.EventHandler(this.rbTODOS_CheckedChanged);
            // 
            // rbSELECCION
            // 
            this.rbSELECCION.AutoSize = true;
            this.rbSELECCION.Location = new System.Drawing.Point(254, 66);
            this.rbSELECCION.Name = "rbSELECCION";
            this.rbSELECCION.Size = new System.Drawing.Size(151, 17);
            this.rbSELECCION.TabIndex = 30;
            this.rbSELECCION.TabStop = true;
            this.rbSELECCION.Text = "Que pertenezcan al grupo:";
            this.rbSELECCION.UseVisualStyleBackColor = true;
            this.rbSELECCION.CheckedChanged += new System.EventHandler(this.rbSELECCION_CheckedChanged);
            // 
            // cmbGRUPO
            // 
            this.cmbGRUPO.Enabled = false;
            this.cmbGRUPO.FormattingEnabled = true;
            this.cmbGRUPO.Location = new System.Drawing.Point(411, 65);
            this.cmbGRUPO.Name = "cmbGRUPO";
            this.cmbGRUPO.Size = new System.Drawing.Size(168, 21);
            this.cmbGRUPO.TabIndex = 31;
            // 
            // btnRESETEAR_CLAVE
            // 
            this.btnRESETEAR_CLAVE.Image = ((System.Drawing.Image)(resources.GetObject("btnRESETEAR_CLAVE.Image")));
            this.btnRESETEAR_CLAVE.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRESETEAR_CLAVE.Location = new System.Drawing.Point(297, 403);
            this.btnRESETEAR_CLAVE.Name = "btnRESETEAR_CLAVE";
            this.btnRESETEAR_CLAVE.Size = new System.Drawing.Size(91, 60);
            this.btnRESETEAR_CLAVE.TabIndex = 32;
            this.btnRESETEAR_CLAVE.Text = "&Resetear clave";
            this.btnRESETEAR_CLAVE.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRESETEAR_CLAVE.UseVisualStyleBackColor = true;
            this.btnRESETEAR_CLAVE.Click += new System.EventHandler(this.btnRESETEAR_CLAVE_Click);
            // 
            // frmUSUARIOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 472);
            this.Controls.Add(this.btnRESETEAR_CLAVE);
            this.Controls.Add(this.cmbGRUPO);
            this.Controls.Add(this.rbSELECCION);
            this.Controls.Add(this.rbTODOS);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chkINACTIVOS);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDESCRIPCION);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBUSCAR);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCONSULTAS);
            this.Controls.Add(this.btnBAJAS);
            this.Controls.Add(this.btnMODIFICACIONES);
            this.Controls.Add(this.btnALTAS);
            this.Controls.Add(this.btnCERRAR);
            this.Controls.Add(this.dgvDATA);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmUSUARIOS";
            this.Text = "::.. GESTION DE USUARIOS DEL SISTEMA";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDATA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCONSULTAS;
        private System.Windows.Forms.Button btnBAJAS;
        private System.Windows.Forms.Button btnMODIFICACIONES;
        private System.Windows.Forms.Button btnALTAS;
        private System.Windows.Forms.Button btnCERRAR;
        private System.Windows.Forms.DataGridView dgvDATA;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnBUSCAR;
        private System.Windows.Forms.CheckBox chkINACTIVOS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDESCRIPCION;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbTODOS;
        private System.Windows.Forms.RadioButton rbSELECCION;
        private System.Windows.Forms.ComboBox cmbGRUPO;
        private System.Windows.Forms.Button btnRESETEAR_CLAVE;
    }
}