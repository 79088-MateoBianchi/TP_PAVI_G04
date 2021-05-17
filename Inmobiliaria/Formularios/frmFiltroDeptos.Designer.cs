
namespace Inmobiliaria.Formularios
{
    partial class frmFiltroDeptos
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
            this.grillaDeptos = new System.Windows.Forms.DataGridView();
            this.btnBuscarProvincias = new System.Windows.Forms.Button();
            this.chkTodosDeptos = new System.Windows.Forms.CheckBox();
            this.txtIdProvincia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.IdDepartamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Departamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdProvincia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgregarProvincia = new System.Windows.Forms.Button();
            this.btnSalirProvincias = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grillaDeptos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarCampos.Location = new System.Drawing.Point(46, 499);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(96, 52);
            this.btnLimpiarCampos.TabIndex = 4;
            this.btnLimpiarCampos.Text = "Limpiar Campos";
            this.btnLimpiarCampos.UseVisualStyleBackColor = true;
            this.btnLimpiarCampos.Click += new System.EventHandler(this.btnLimpiarCampos_Click);
            // 
            // grillaDeptos
            // 
            this.grillaDeptos.AllowUserToAddRows = false;
            this.grillaDeptos.AllowUserToDeleteRows = false;
            this.grillaDeptos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaDeptos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdDepartamento,
            this.Departamento,
            this.IdProvincia});
            this.grillaDeptos.Location = new System.Drawing.Point(46, 189);
            this.grillaDeptos.Name = "grillaDeptos";
            this.grillaDeptos.ReadOnly = true;
            this.grillaDeptos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grillaDeptos.Size = new System.Drawing.Size(454, 271);
            this.grillaDeptos.TabIndex = 23;
            this.grillaDeptos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grillaDeptos_CellClick);
            // 
            // btnBuscarProvincias
            // 
            this.btnBuscarProvincias.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarProvincias.Location = new System.Drawing.Point(421, 79);
            this.btnBuscarProvincias.Name = "btnBuscarProvincias";
            this.btnBuscarProvincias.Size = new System.Drawing.Size(79, 35);
            this.btnBuscarProvincias.TabIndex = 3;
            this.btnBuscarProvincias.Text = "Buscar";
            this.btnBuscarProvincias.UseVisualStyleBackColor = true;
            this.btnBuscarProvincias.Click += new System.EventHandler(this.btnBuscarProvincias_Click);
            // 
            // chkTodosDeptos
            // 
            this.chkTodosDeptos.AutoSize = true;
            this.chkTodosDeptos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTodosDeptos.Location = new System.Drawing.Point(46, 129);
            this.chkTodosDeptos.Name = "chkTodosDeptos";
            this.chkTodosDeptos.Size = new System.Drawing.Size(248, 22);
            this.chkTodosDeptos.TabIndex = 2;
            this.chkTodosDeptos.Text = "Mostrar todos los departamentos";
            this.chkTodosDeptos.UseVisualStyleBackColor = true;
            this.chkTodosDeptos.CheckedChanged += new System.EventHandler(this.chkTodosDeptos_CheckedChanged);
            // 
            // txtIdProvincia
            // 
            this.txtIdProvincia.Location = new System.Drawing.Point(147, 80);
            this.txtIdProvincia.Name = "txtIdProvincia";
            this.txtIdProvincia.Size = new System.Drawing.Size(91, 20);
            this.txtIdProvincia.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 18);
            this.label2.TabIndex = 22;
            this.label2.Text = "Nro Provincia";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 24);
            this.label1.TabIndex = 21;
            this.label1.Text = "Departamentos Geográficos";
            // 
            // IdDepartamento
            // 
            this.IdDepartamento.DataPropertyName = "id_departamento";
            this.IdDepartamento.HeaderText = "Id Departamento";
            this.IdDepartamento.Name = "IdDepartamento";
            this.IdDepartamento.ReadOnly = true;
            this.IdDepartamento.Width = 110;
            // 
            // Departamento
            // 
            this.Departamento.DataPropertyName = "n_departamento";
            this.Departamento.HeaderText = "Departamento";
            this.Departamento.Name = "Departamento";
            this.Departamento.ReadOnly = true;
            this.Departamento.Width = 200;
            // 
            // IdProvincia
            // 
            this.IdProvincia.DataPropertyName = "id_provincia";
            this.IdProvincia.HeaderText = "Id Provincia";
            this.IdProvincia.Name = "IdProvincia";
            this.IdProvincia.ReadOnly = true;
            // 
            // btnAgregarProvincia
            // 
            this.btnAgregarProvincia.BackgroundImage = global::Inmobiliaria.Properties.Resources.iconfinder_add1__323785;
            this.btnAgregarProvincia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAgregarProvincia.Location = new System.Drawing.Point(323, 489);
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
            this.btnSalirProvincias.Location = new System.Drawing.Point(425, 489);
            this.btnSalirProvincias.Name = "btnSalirProvincias";
            this.btnSalirProvincias.Size = new System.Drawing.Size(75, 75);
            this.btnSalirProvincias.TabIndex = 6;
            this.btnSalirProvincias.UseVisualStyleBackColor = true;
            this.btnSalirProvincias.Click += new System.EventHandler(this.btnSalirProvincias_Click);
            // 
            // frmFiltroDeptos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 586);
            this.Controls.Add(this.btnAgregarProvincia);
            this.Controls.Add(this.btnSalirProvincias);
            this.Controls.Add(this.btnLimpiarCampos);
            this.Controls.Add(this.grillaDeptos);
            this.Controls.Add(this.btnBuscarProvincias);
            this.Controls.Add(this.chkTodosDeptos);
            this.Controls.Add(this.txtIdProvincia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmFiltroDeptos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ABM Deptos";
            this.Load += new System.EventHandler(this.frmFiltroDeptos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grillaDeptos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarProvincia;
        private System.Windows.Forms.Button btnSalirProvincias;
        private System.Windows.Forms.Button btnLimpiarCampos;
        private System.Windows.Forms.DataGridView grillaDeptos;
        private System.Windows.Forms.Button btnBuscarProvincias;
        private System.Windows.Forms.CheckBox chkTodosDeptos;
        private System.Windows.Forms.TextBox txtIdProvincia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdDepartamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Departamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProvincia;
    }
}