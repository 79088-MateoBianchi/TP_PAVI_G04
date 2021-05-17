
namespace Inmobiliaria.Formularios
{
    partial class frmFiltroProvincias
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
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.grillaProvincias = new System.Windows.Forms.DataGridView();
            this.IdProvincia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Provincia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBuscarProvincias = new System.Windows.Forms.Button();
            this.chkTodasProvincias = new System.Windows.Forms.CheckBox();
            this.txtIdProvincia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregarProvincia = new System.Windows.Forms.Button();
            this.btnSalirProvincias = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grillaProvincias)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarCampos.Location = new System.Drawing.Point(48, 518);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(96, 52);
            this.btnLimpiarCampos.TabIndex = 4;
            this.btnLimpiarCampos.Text = "Limpiar Campos";
            this.btnLimpiarCampos.UseVisualStyleBackColor = true;
            this.btnLimpiarCampos.Click += new System.EventHandler(this.btnLimpiarCampos_Click);
            // 
            // grillaProvincias
            // 
            this.grillaProvincias.AllowUserToAddRows = false;
            this.grillaProvincias.AllowUserToDeleteRows = false;
            this.grillaProvincias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaProvincias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProvincia,
            this.Provincia});
            this.grillaProvincias.Location = new System.Drawing.Point(48, 208);
            this.grillaProvincias.Name = "grillaProvincias";
            this.grillaProvincias.ReadOnly = true;
            this.grillaProvincias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grillaProvincias.Size = new System.Drawing.Size(344, 271);
            this.grillaProvincias.TabIndex = 14;
            this.grillaProvincias.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grillaProvincias_CellClick);
            // 
            // IdProvincia
            // 
            this.IdProvincia.DataPropertyName = "id_provincia";
            this.IdProvincia.HeaderText = "Id Provincia";
            this.IdProvincia.Name = "IdProvincia";
            this.IdProvincia.ReadOnly = true;
            // 
            // Provincia
            // 
            this.Provincia.DataPropertyName = "n_provincia";
            this.Provincia.HeaderText = "Provincia";
            this.Provincia.Name = "Provincia";
            this.Provincia.ReadOnly = true;
            this.Provincia.Width = 200;
            // 
            // btnBuscarProvincias
            // 
            this.btnBuscarProvincias.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarProvincias.Location = new System.Drawing.Point(313, 98);
            this.btnBuscarProvincias.Name = "btnBuscarProvincias";
            this.btnBuscarProvincias.Size = new System.Drawing.Size(79, 35);
            this.btnBuscarProvincias.TabIndex = 3;
            this.btnBuscarProvincias.Text = "Buscar";
            this.btnBuscarProvincias.UseVisualStyleBackColor = true;
            this.btnBuscarProvincias.Click += new System.EventHandler(this.btnBuscarProvincias_Click);
            // 
            // chkTodasProvincias
            // 
            this.chkTodasProvincias.AutoSize = true;
            this.chkTodasProvincias.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTodasProvincias.Location = new System.Drawing.Point(48, 148);
            this.chkTodasProvincias.Name = "chkTodasProvincias";
            this.chkTodasProvincias.Size = new System.Drawing.Size(248, 22);
            this.chkTodasProvincias.TabIndex = 2;
            this.chkTodasProvincias.Text = "Mostrar todos los departamentos";
            this.chkTodasProvincias.UseVisualStyleBackColor = true;
            this.chkTodasProvincias.CheckedChanged += new System.EventHandler(this.chkTodasProvincias_CheckedChanged);
            // 
            // txtIdProvincia
            // 
            this.txtIdProvincia.Location = new System.Drawing.Point(149, 99);
            this.txtIdProvincia.Name = "txtIdProvincia";
            this.txtIdProvincia.Size = new System.Drawing.Size(91, 20);
            this.txtIdProvincia.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nro Provincia";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Provincias";
            // 
            // btnAgregarProvincia
            // 
            this.btnAgregarProvincia.BackgroundImage = global::Inmobiliaria.Properties.Resources.iconfinder_add1__323785;
            this.btnAgregarProvincia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAgregarProvincia.Location = new System.Drawing.Point(221, 508);
            this.btnAgregarProvincia.Name = "btnAgregarProvincia";
            this.btnAgregarProvincia.Size = new System.Drawing.Size(75, 75);
            this.btnAgregarProvincia.TabIndex = 5;
            this.btnAgregarProvincia.UseVisualStyleBackColor = true;
            this.btnAgregarProvincia.Click += new System.EventHandler(this.btnAgregarProvincia_Click);
            // 
            // btnSalirProvincias
            // 
            this.btnSalirProvincias.BackgroundImage = global::Inmobiliaria.Properties.Resources.iconfinder_2_27391183;
            this.btnSalirProvincias.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSalirProvincias.Location = new System.Drawing.Point(317, 508);
            this.btnSalirProvincias.Name = "btnSalirProvincias";
            this.btnSalirProvincias.Size = new System.Drawing.Size(75, 75);
            this.btnSalirProvincias.TabIndex = 6;
            this.btnSalirProvincias.UseVisualStyleBackColor = true;
            this.btnSalirProvincias.Click += new System.EventHandler(this.btnSalirProvincias_Click);
            // 
            // frmFiltroProvincias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 600);
            this.Controls.Add(this.btnAgregarProvincia);
            this.Controls.Add(this.btnSalirProvincias);
            this.Controls.Add(this.btnLimpiarCampos);
            this.Controls.Add(this.grillaProvincias);
            this.Controls.Add(this.btnBuscarProvincias);
            this.Controls.Add(this.chkTodasProvincias);
            this.Controls.Add(this.txtIdProvincia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmFiltroProvincias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ABM Provincias";
            this.Load += new System.EventHandler(this.frmFiltroProvincias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grillaProvincias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarProvincia;
        private System.Windows.Forms.Button btnSalirProvincias;
        private System.Windows.Forms.Button btnLimpiarCampos;
        private System.Windows.Forms.DataGridView grillaProvincias;
        private System.Windows.Forms.Button btnBuscarProvincias;
        private System.Windows.Forms.CheckBox chkTodasProvincias;
        private System.Windows.Forms.TextBox txtIdProvincia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProvincia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Provincia;
    }
}