
namespace Inmobiliaria
{
    partial class frmFiltroEscribanos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFiltroEscribanos));
            this.lblMatricula = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.lblEscribanos = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.chkMostrarTodosEscrib = new System.Windows.Forms.CheckBox();
            this.grillaEscribanos = new System.Windows.Forms.DataGridView();
            this.Matricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblMensaje2 = new System.Windows.Forms.Label();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grillaEscribanos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatricula.Location = new System.Drawing.Point(61, 79);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(77, 18);
            this.lblMatricula.TabIndex = 3;
            this.lblMatricula.Text = "Matricula";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatricula.Location = new System.Drawing.Point(158, 76);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(110, 24);
            this.txtMatricula.TabIndex = 4;
            // 
            // lblEscribanos
            // 
            this.lblEscribanos.AutoSize = true;
            this.lblEscribanos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEscribanos.Location = new System.Drawing.Point(19, 21);
            this.lblEscribanos.Name = "lblEscribanos";
            this.lblEscribanos.Size = new System.Drawing.Size(119, 25);
            this.lblEscribanos.TabIndex = 5;
            this.lblEscribanos.Text = "Escribanos";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(560, 112);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(91, 35);
            this.btnBuscar.TabIndex = 7;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // chkMostrarTodosEscrib
            // 
            this.chkMostrarTodosEscrib.AutoSize = true;
            this.chkMostrarTodosEscrib.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMostrarTodosEscrib.Location = new System.Drawing.Point(158, 117);
            this.chkMostrarTodosEscrib.Name = "chkMostrarTodosEscrib";
            this.chkMostrarTodosEscrib.Size = new System.Drawing.Size(250, 22);
            this.chkMostrarTodosEscrib.TabIndex = 6;
            this.chkMostrarTodosEscrib.Text = "Mostrar todos los escribanos";
            this.chkMostrarTodosEscrib.UseVisualStyleBackColor = true;
            // 
            // grillaEscribanos
            // 
            this.grillaEscribanos.AllowUserToAddRows = false;
            this.grillaEscribanos.AllowUserToDeleteRows = false;
            this.grillaEscribanos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaEscribanos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Matricula,
            this.Nombre,
            this.Apellido});
            this.grillaEscribanos.Location = new System.Drawing.Point(61, 173);
            this.grillaEscribanos.Name = "grillaEscribanos";
            this.grillaEscribanos.ReadOnly = true;
            this.grillaEscribanos.Size = new System.Drawing.Size(590, 150);
            this.grillaEscribanos.TabIndex = 8;
            this.grillaEscribanos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grillaEscribanos_CellClick);
            // 
            // Matricula
            // 
            this.Matricula.DataPropertyName = "matricula";
            this.Matricula.HeaderText = "Matricula";
            this.Matricula.Name = "Matricula";
            this.Matricula.ReadOnly = true;
            this.Matricula.Width = 140;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "n_escribano";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 200;
            // 
            // Apellido
            // 
            this.Apellido.DataPropertyName = "apellido_escribano";
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            this.Apellido.Width = 200;
            // 
            // lblMensaje2
            // 
            this.lblMensaje2.AutoSize = true;
            this.lblMensaje2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje2.Location = new System.Drawing.Point(58, 365);
            this.lblMensaje2.Name = "lblMensaje2";
            this.lblMensaje2.Size = new System.Drawing.Size(359, 17);
            this.lblMensaje2.TabIndex = 33;
            this.lblMensaje2.Text = "Para actualizar la grilla, vuelva a realizar una busqueda";
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.Location = new System.Drawing.Point(58, 332);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(442, 17);
            this.lblMensaje.TabIndex = 32;
            this.lblMensaje.Text = "Para modificar o eliminar un escribano debe seleccionarlo de la grilla";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackgroundImage = global::Inmobiliaria.Properties.Resources.iconfinder_add1__32378;
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAgregar.Location = new System.Drawing.Point(463, 421);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(74, 74);
            this.btnAgregar.TabIndex = 30;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackgroundImage = global::Inmobiliaria.Properties.Resources.iconfinder_2_2739118;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSalir.Location = new System.Drawing.Point(577, 421);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(74, 74);
            this.btnSalir.TabIndex = 31;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmFiltroEscribanos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 507);
            this.Controls.Add(this.lblMensaje2);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.grillaEscribanos);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.chkMostrarTodosEscrib);
            this.Controls.Add(this.lblEscribanos);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.lblMatricula);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmFiltroEscribanos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ABM Escribanos";
            this.Load += new System.EventHandler(this.frmFiltroEscribanos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grillaEscribanos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.Label lblEscribanos;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.CheckBox chkMostrarTodosEscrib;
        private System.Windows.Forms.DataGridView grillaEscribanos;
        private System.Windows.Forms.Label lblMensaje2;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridViewTextBoxColumn Matricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
    }
}