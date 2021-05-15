
namespace Inmobiliaria
{
    partial class frmFiltroDepartamentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFiltroDepartamentos));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdEdificio = new System.Windows.Forms.TextBox();
            this.chkTodosDepartamentos = new System.Windows.Forms.CheckBox();
            this.btnBuscarDepartamentos = new System.Windows.Forms.Button();
            this.grillaDepartamentos = new System.Windows.Forms.DataGridView();
            this.IdEdificio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Piso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Denominacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Superficie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PorcentajeEdificio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LegajoEncargadoExp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.btnAgregarDepartamento = new System.Windows.Forms.Button();
            this.btnSalirDepartamentos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grillaDepartamentos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Departamentos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nro Edificio";
            // 
            // txtIdEdificio
            // 
            this.txtIdEdificio.Location = new System.Drawing.Point(124, 93);
            this.txtIdEdificio.Name = "txtIdEdificio";
            this.txtIdEdificio.Size = new System.Drawing.Size(91, 20);
            this.txtIdEdificio.TabIndex = 1;
            // 
            // chkTodosDepartamentos
            // 
            this.chkTodosDepartamentos.AutoSize = true;
            this.chkTodosDepartamentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTodosDepartamentos.Location = new System.Drawing.Point(259, 93);
            this.chkTodosDepartamentos.Name = "chkTodosDepartamentos";
            this.chkTodosDepartamentos.Size = new System.Drawing.Size(248, 22);
            this.chkTodosDepartamentos.TabIndex = 2;
            this.chkTodosDepartamentos.Text = "Mostrar todos los departamentos";
            this.chkTodosDepartamentos.UseVisualStyleBackColor = true;
            this.chkTodosDepartamentos.CheckedChanged += new System.EventHandler(this.chkTodosDepartamentos_CheckedChanged);
            // 
            // btnBuscarDepartamentos
            // 
            this.btnBuscarDepartamentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarDepartamentos.Location = new System.Drawing.Point(565, 86);
            this.btnBuscarDepartamentos.Name = "btnBuscarDepartamentos";
            this.btnBuscarDepartamentos.Size = new System.Drawing.Size(79, 35);
            this.btnBuscarDepartamentos.TabIndex = 3;
            this.btnBuscarDepartamentos.Text = "Buscar";
            this.btnBuscarDepartamentos.UseVisualStyleBackColor = true;
            this.btnBuscarDepartamentos.Click += new System.EventHandler(this.btnBuscarDepartamentos_Click);
            // 
            // grillaDepartamentos
            // 
            this.grillaDepartamentos.AllowUserToAddRows = false;
            this.grillaDepartamentos.AllowUserToDeleteRows = false;
            this.grillaDepartamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaDepartamentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdEdificio,
            this.Piso,
            this.Denominacion,
            this.Superficie,
            this.PorcentajeEdificio,
            this.LegajoEncargadoExp});
            this.grillaDepartamentos.Location = new System.Drawing.Point(36, 161);
            this.grillaDepartamentos.Name = "grillaDepartamentos";
            this.grillaDepartamentos.ReadOnly = true;
            this.grillaDepartamentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grillaDepartamentos.Size = new System.Drawing.Size(608, 271);
            this.grillaDepartamentos.TabIndex = 5;
            this.grillaDepartamentos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grillaDepartamentos_CellClick);
            // 
            // IdEdificio
            // 
            this.IdEdificio.DataPropertyName = "id_edificio";
            this.IdEdificio.HeaderText = "Id Edificio";
            this.IdEdificio.Name = "IdEdificio";
            this.IdEdificio.ReadOnly = true;
            this.IdEdificio.Width = 80;
            // 
            // Piso
            // 
            this.Piso.DataPropertyName = "piso";
            this.Piso.HeaderText = "Piso";
            this.Piso.Name = "Piso";
            this.Piso.ReadOnly = true;
            this.Piso.Width = 50;
            // 
            // Denominacion
            // 
            this.Denominacion.DataPropertyName = "denominacion";
            this.Denominacion.HeaderText = "Denominación";
            this.Denominacion.Name = "Denominacion";
            this.Denominacion.ReadOnly = true;
            this.Denominacion.Width = 80;
            // 
            // Superficie
            // 
            this.Superficie.DataPropertyName = "superficie";
            this.Superficie.HeaderText = "Superficie";
            this.Superficie.Name = "Superficie";
            this.Superficie.ReadOnly = true;
            this.Superficie.Width = 70;
            // 
            // PorcentajeEdificio
            // 
            this.PorcentajeEdificio.DataPropertyName = "porcentaje_edificio";
            this.PorcentajeEdificio.HeaderText = "Porcentaje del Edificio";
            this.PorcentajeEdificio.Name = "PorcentajeEdificio";
            this.PorcentajeEdificio.ReadOnly = true;
            this.PorcentajeEdificio.Width = 140;
            // 
            // LegajoEncargadoExp
            // 
            this.LegajoEncargadoExp.DataPropertyName = "legajo_encargado_exp";
            this.LegajoEncargadoExp.HeaderText = "Legajo Encargado Exp";
            this.LegajoEncargadoExp.Name = "LegajoEncargadoExp";
            this.LegajoEncargadoExp.ReadOnly = true;
            this.LegajoEncargadoExp.Width = 145;
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarCampos.Location = new System.Drawing.Point(36, 472);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(96, 52);
            this.btnLimpiarCampos.TabIndex = 4;
            this.btnLimpiarCampos.Text = "Limpiar Campos";
            this.btnLimpiarCampos.UseVisualStyleBackColor = true;
            this.btnLimpiarCampos.Click += new System.EventHandler(this.btnLimpiarCampos_Click);
            // 
            // btnAgregarDepartamento
            // 
            this.btnAgregarDepartamento.BackgroundImage = global::Inmobiliaria.Properties.Resources.iconfinder_add1__323785;
            this.btnAgregarDepartamento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAgregarDepartamento.Location = new System.Drawing.Point(461, 455);
            this.btnAgregarDepartamento.Name = "btnAgregarDepartamento";
            this.btnAgregarDepartamento.Size = new System.Drawing.Size(75, 75);
            this.btnAgregarDepartamento.TabIndex = 5;
            this.btnAgregarDepartamento.UseVisualStyleBackColor = true;
            this.btnAgregarDepartamento.Click += new System.EventHandler(this.btnAgregarDepartamento_Click);
            // 
            // btnSalirDepartamentos
            // 
            this.btnSalirDepartamentos.BackgroundImage = global::Inmobiliaria.Properties.Resources.iconfinder_2_27391183;
            this.btnSalirDepartamentos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSalirDepartamentos.Location = new System.Drawing.Point(568, 455);
            this.btnSalirDepartamentos.Name = "btnSalirDepartamentos";
            this.btnSalirDepartamentos.Size = new System.Drawing.Size(75, 75);
            this.btnSalirDepartamentos.TabIndex = 6;
            this.btnSalirDepartamentos.UseVisualStyleBackColor = true;
            this.btnSalirDepartamentos.Click += new System.EventHandler(this.btnSalirDepartamentos_Click);
            // 
            // frmFiltroDepartamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 545);
            this.Controls.Add(this.btnAgregarDepartamento);
            this.Controls.Add(this.btnSalirDepartamentos);
            this.Controls.Add(this.btnLimpiarCampos);
            this.Controls.Add(this.grillaDepartamentos);
            this.Controls.Add(this.btnBuscarDepartamentos);
            this.Controls.Add(this.chkTodosDepartamentos);
            this.Controls.Add(this.txtIdEdificio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmFiltroDepartamentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ABM Departamentos";
            this.Load += new System.EventHandler(this.frmFiltroDepartamentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grillaDepartamentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdEdificio;
        private System.Windows.Forms.CheckBox chkTodosDepartamentos;
        private System.Windows.Forms.Button btnBuscarDepartamentos;
        private System.Windows.Forms.DataGridView grillaDepartamentos;
        private System.Windows.Forms.Button btnLimpiarCampos;
        private System.Windows.Forms.Button btnSalirDepartamentos;
        private System.Windows.Forms.Button btnAgregarDepartamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEdificio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Piso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Denominacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Superficie;
        private System.Windows.Forms.DataGridViewTextBoxColumn PorcentajeEdificio;
        private System.Windows.Forms.DataGridViewTextBoxColumn LegajoEncargadoExp;
    }
}