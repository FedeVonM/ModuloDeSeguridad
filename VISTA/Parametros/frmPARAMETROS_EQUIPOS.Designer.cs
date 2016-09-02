namespace VISTA.Parametros
{
    partial class frmPARAMETROS_EQUIPOS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPARAMETROS_EQUIPOS));
            this.label3 = new System.Windows.Forms.Label();
            this.btnBUSCAR = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCONSULTAS = new System.Windows.Forms.Button();
            this.btnMODIFICACIONES = new System.Windows.Forms.Button();
            this.dgvDATA = new System.Windows.Forms.DataGridView();
            this.txtNOMBRE_EQUIPO = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDATA)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "Nombre de equipo:";
            // 
            // btnBUSCAR
            // 
            this.btnBUSCAR.Image = ((System.Drawing.Image)(resources.GetObject("btnBUSCAR.Image")));
            this.btnBUSCAR.Location = new System.Drawing.Point(677, 6);
            this.btnBUSCAR.Name = "btnBUSCAR";
            this.btnBUSCAR.Size = new System.Drawing.Size(148, 63);
            this.btnBUSCAR.TabIndex = 39;
            this.btnBUSCAR.Text = "Buscar";
            this.btnBUSCAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBUSCAR.UseVisualStyleBackColor = true;
            this.btnBUSCAR.Click += new System.EventHandler(this.btnBUSCAR_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(731, 344);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 60);
            this.button1.TabIndex = 38;
            this.button1.Text = "&Cerrar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCONSULTAS
            // 
            this.btnCONSULTAS.Image = ((System.Drawing.Image)(resources.GetObject("btnCONSULTAS.Image")));
            this.btnCONSULTAS.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCONSULTAS.Location = new System.Drawing.Point(101, 344);
            this.btnCONSULTAS.Name = "btnCONSULTAS";
            this.btnCONSULTAS.Size = new System.Drawing.Size(91, 60);
            this.btnCONSULTAS.TabIndex = 37;
            this.btnCONSULTAS.Text = "&Ver Detalle";
            this.btnCONSULTAS.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCONSULTAS.UseVisualStyleBackColor = true;
            this.btnCONSULTAS.Click += new System.EventHandler(this.btnCONSULTAS_Click);
            // 
            // btnMODIFICACIONES
            // 
            this.btnMODIFICACIONES.Image = ((System.Drawing.Image)(resources.GetObject("btnMODIFICACIONES.Image")));
            this.btnMODIFICACIONES.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMODIFICACIONES.Location = new System.Drawing.Point(4, 344);
            this.btnMODIFICACIONES.Name = "btnMODIFICACIONES";
            this.btnMODIFICACIONES.Size = new System.Drawing.Size(91, 60);
            this.btnMODIFICACIONES.TabIndex = 36;
            this.btnMODIFICACIONES.Text = "&Modificar";
            this.btnMODIFICACIONES.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMODIFICACIONES.UseVisualStyleBackColor = true;
            this.btnMODIFICACIONES.Click += new System.EventHandler(this.btnMODIFICACIONES_Click);
            // 
            // dgvDATA
            // 
            this.dgvDATA.AllowUserToAddRows = false;
            this.dgvDATA.AllowUserToDeleteRows = false;
            this.dgvDATA.AllowUserToOrderColumns = true;
            this.dgvDATA.AllowUserToResizeRows = false;
            this.dgvDATA.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDATA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDATA.Location = new System.Drawing.Point(4, 75);
            this.dgvDATA.Name = "dgvDATA";
            this.dgvDATA.ReadOnly = true;
            this.dgvDATA.Size = new System.Drawing.Size(827, 263);
            this.dgvDATA.TabIndex = 33;
            // 
            // txtNOMBRE_EQUIPO
            // 
            this.txtNOMBRE_EQUIPO.Location = new System.Drawing.Point(137, 27);
            this.txtNOMBRE_EQUIPO.Name = "txtNOMBRE_EQUIPO";
            this.txtNOMBRE_EQUIPO.Size = new System.Drawing.Size(358, 20);
            this.txtNOMBRE_EQUIPO.TabIndex = 43;
            // 
            // frmPARAMETROS_EQUIPOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 409);
            this.Controls.Add(this.txtNOMBRE_EQUIPO);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBUSCAR);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCONSULTAS);
            this.Controls.Add(this.btnMODIFICACIONES);
            this.Controls.Add(this.dgvDATA);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPARAMETROS_EQUIPOS";
            this.Text = "::: GESTION DE PARAMETROS DE EQUIPOS";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDATA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBUSCAR;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCONSULTAS;
        private System.Windows.Forms.Button btnMODIFICACIONES;
        private System.Windows.Forms.DataGridView dgvDATA;
        private System.Windows.Forms.TextBox txtNOMBRE_EQUIPO;
    }
}