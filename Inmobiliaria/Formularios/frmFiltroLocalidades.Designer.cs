
namespace Inmobiliaria.Formularios
{
    partial class frmFiltroLocalidades
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
            this.btnInicio = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gdrLocalidades = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtFiltrarPorLocalidad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.IdLocal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdDepartamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdrLocalidades)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInicio
            // 
            this.btnInicio.BackColor = System.Drawing.SystemColors.Control;
            this.btnInicio.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnInicio.Image = global::Inmobiliaria.Properties.Resources.iconfinder_2_2739118;
            this.btnInicio.Location = new System.Drawing.Point(429, 440);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(69, 75);
            this.btnInicio.TabIndex = 7;
            this.btnInicio.UseVisualStyleBackColor = false;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.SystemColors.Control;
            this.btnActualizar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnActualizar.Image = global::Inmobiliaria.Properties.Resources.iconfinder_reload_46828;
            this.btnActualizar.Location = new System.Drawing.Point(142, 440);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(69, 75);
            this.btnActualizar.TabIndex = 8;
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.Control;
            this.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAgregar.Image = global::Inmobiliaria.Properties.Resources.iconfinder_add1__32378;
            this.btnAgregar.Location = new System.Drawing.Point(33, 440);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(69, 75);
            this.btnAgregar.TabIndex = 9;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.gdrLocalidades);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.txtFiltrarPorLocalidad);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(495, 422);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro Localidades";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 390);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(488, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "*Seleccione una Localidad de la tabla para modificar o eliminar*";
            // 
            // gdrLocalidades
            // 
            this.gdrLocalidades.AllowUserToAddRows = false;
            this.gdrLocalidades.AllowUserToDeleteRows = false;
            this.gdrLocalidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdrLocalidades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdLocal,
            this.Nombre,
            this.IdDepartamento});
            this.gdrLocalidades.Location = new System.Drawing.Point(5, 105);
            this.gdrLocalidades.Name = "gdrLocalidades";
            this.gdrLocalidades.ReadOnly = true;
            this.gdrLocalidades.Size = new System.Drawing.Size(483, 282);
            this.gdrLocalidades.TabIndex = 1;
            this.gdrLocalidades.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdrLocalidades_CellClick);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.Control;
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnBuscar.Image = global::Inmobiliaria.Properties.Resources.buscar;
            this.btnBuscar.Location = new System.Drawing.Point(320, 39);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(45, 43);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtFiltrarPorLocalidad
            // 
            this.txtFiltrarPorLocalidad.Location = new System.Drawing.Point(178, 47);
            this.txtFiltrarPorLocalidad.Name = "txtFiltrarPorLocalidad";
            this.txtFiltrarPorLocalidad.Size = new System.Drawing.Size(136, 26);
            this.txtFiltrarPorLocalidad.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre Localidad:";
            // 
            // IdLocal
            // 
            this.IdLocal.DataPropertyName = "id_localidad";
            this.IdLocal.HeaderText = "ID";
            this.IdLocal.Name = "IdLocal";
            this.IdLocal.ReadOnly = true;
            this.IdLocal.Width = 50;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "n_localidad";
            this.Nombre.HeaderText = "Nombre Localidad";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 195;
            // 
            // IdDepartamento
            // 
            this.IdDepartamento.DataPropertyName = "n_departamento";
            this.IdDepartamento.HeaderText = "Departamento";
            this.IdDepartamento.Name = "IdDepartamento";
            this.IdDepartamento.ReadOnly = true;
            this.IdDepartamento.Width = 195;
            // 
            // frmFiltroLocalidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 517);
            this.Controls.Add(this.btnInicio);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmFiltroLocalidades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmFiltroLocalidades";
            this.Load += new System.EventHandler(this.frmFiltroLocalidades_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdrLocalidades)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView gdrLocalidades;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtFiltrarPorLocalidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdLocal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdDepartamento;
    }
}