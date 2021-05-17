
namespace Inmobiliaria.Formularios
{
    partial class frmFiltroProveedores
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
            this.lblProveedores = new System.Windows.Forms.Label();
            this.lblNro = new System.Windows.Forms.Label();
            this.txtNro = new System.Windows.Forms.TextBox();
            this.chkMostrarTodosProvee = new System.Windows.Forms.CheckBox();
            this.btnBuscarProveedores = new System.Windows.Forms.Button();
            this.grillaProveedores = new System.Windows.Forms.DataGridView();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.IdProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelefonoProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grillaProveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProveedores
            // 
            this.lblProveedores.AutoSize = true;
            this.lblProveedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProveedores.Location = new System.Drawing.Point(23, 23);
            this.lblProveedores.Name = "lblProveedores";
            this.lblProveedores.Size = new System.Drawing.Size(134, 25);
            this.lblProveedores.TabIndex = 0;
            this.lblProveedores.Text = "Proveedores";
            this.lblProveedores.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblNro
            // 
            this.lblNro.AutoSize = true;
            this.lblNro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNro.Location = new System.Drawing.Point(61, 75);
            this.lblNro.Name = "lblNro";
            this.lblNro.Size = new System.Drawing.Size(147, 18);
            this.lblNro.TabIndex = 1;
            this.lblNro.Text = "Nro de Proveedor:";
            // 
            // txtNro
            // 
            this.txtNro.Location = new System.Drawing.Point(214, 76);
            this.txtNro.Name = "txtNro";
            this.txtNro.Size = new System.Drawing.Size(75, 20);
            this.txtNro.TabIndex = 2;
            this.txtNro.TextChanged += new System.EventHandler(this.txtNro_TextChanged);
            // 
            // chkMostrarTodosProvee
            // 
            this.chkMostrarTodosProvee.AutoSize = true;
            this.chkMostrarTodosProvee.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMostrarTodosProvee.Location = new System.Drawing.Point(64, 115);
            this.chkMostrarTodosProvee.Name = "chkMostrarTodosProvee";
            this.chkMostrarTodosProvee.Size = new System.Drawing.Size(261, 22);
            this.chkMostrarTodosProvee.TabIndex = 3;
            this.chkMostrarTodosProvee.Text = "Mostrar todos los proveedores";
            this.chkMostrarTodosProvee.UseVisualStyleBackColor = true;
            this.chkMostrarTodosProvee.CheckedChanged += new System.EventHandler(this.chkMostrarTodosProvee_CheckedChanged);
            // 
            // btnBuscarProveedores
            // 
            this.btnBuscarProveedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarProveedores.Location = new System.Drawing.Point(550, 107);
            this.btnBuscarProveedores.Name = "btnBuscarProveedores";
            this.btnBuscarProveedores.Size = new System.Drawing.Size(79, 36);
            this.btnBuscarProveedores.TabIndex = 4;
            this.btnBuscarProveedores.Text = "Buscar";
            this.btnBuscarProveedores.UseVisualStyleBackColor = true;
            this.btnBuscarProveedores.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // grillaProveedores
            // 
            this.grillaProveedores.AllowUserToAddRows = false;
            this.grillaProveedores.AllowUserToDeleteRows = false;
            this.grillaProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaProveedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProveedor,
            this.NombreProveedor,
            this.DescripcionProveedor,
            this.TelefonoProveedor});
            this.grillaProveedores.Location = new System.Drawing.Point(64, 166);
            this.grillaProveedores.Name = "grillaProveedores";
            this.grillaProveedores.ReadOnly = true;
            this.grillaProveedores.Size = new System.Drawing.Size(565, 161);
            this.grillaProveedores.TabIndex = 5;
            this.grillaProveedores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grillaProveedores_CellClick);
            this.grillaProveedores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grillaProveedores_CellContentClick);
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.Location = new System.Drawing.Point(61, 345);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(442, 17);
            this.lblMensaje.TabIndex = 6;
            this.lblMensaje.Text = "Para modificar o eliminar un escribano debe seleccionarlo de la grilla";
            this.lblMensaje.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarCampos.Location = new System.Drawing.Point(61, 427);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(96, 52);
            this.btnLimpiarCampos.TabIndex = 33;
            this.btnLimpiarCampos.Text = "Limpiar Campos";
            this.btnLimpiarCampos.UseVisualStyleBackColor = true;
            this.btnLimpiarCampos.Click += new System.EventHandler(this.btnLimpiarCampos_Click);
            // 
            // IdProveedor
            // 
            this.IdProveedor.DataPropertyName = "Id_proveedor";
            this.IdProveedor.HeaderText = "Id";
            this.IdProveedor.Name = "IdProveedor";
            this.IdProveedor.ReadOnly = true;
            this.IdProveedor.Width = 70;
            // 
            // NombreProveedor
            // 
            this.NombreProveedor.DataPropertyName = "n_proveedor";
            this.NombreProveedor.HeaderText = "Nombre";
            this.NombreProveedor.Name = "NombreProveedor";
            this.NombreProveedor.ReadOnly = true;
            this.NombreProveedor.Width = 150;
            // 
            // DescripcionProveedor
            // 
            this.DescripcionProveedor.DataPropertyName = "descripcion";
            this.DescripcionProveedor.HeaderText = "Descripción";
            this.DescripcionProveedor.Name = "DescripcionProveedor";
            this.DescripcionProveedor.ReadOnly = true;
            this.DescripcionProveedor.Width = 150;
            // 
            // TelefonoProveedor
            // 
            this.TelefonoProveedor.DataPropertyName = "tel_proveedor";
            this.TelefonoProveedor.HeaderText = "Teléfono";
            this.TelefonoProveedor.Name = "TelefonoProveedor";
            this.TelefonoProveedor.ReadOnly = true;
            this.TelefonoProveedor.Width = 150;
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.SystemColors.Control;
            this.btnActualizar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnActualizar.Image = global::Inmobiliaria.Properties.Resources.iconfinder_reload_46828;
            this.btnActualizar.Location = new System.Drawing.Point(367, 417);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(69, 75);
            this.btnActualizar.TabIndex = 34;
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackgroundImage = global::Inmobiliaria.Properties.Resources.iconfinder_2_2739118;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSalir.Location = new System.Drawing.Point(555, 417);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(74, 74);
            this.btnSalir.TabIndex = 32;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackgroundImage = global::Inmobiliaria.Properties.Resources.iconfinder_add1__32378;
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAgregar.Location = new System.Drawing.Point(459, 418);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(74, 74);
            this.btnAgregar.TabIndex = 31;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // frmFiltroProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 520);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnLimpiarCampos);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.grillaProveedores);
            this.Controls.Add(this.btnBuscarProveedores);
            this.Controls.Add(this.chkMostrarTodosProvee);
            this.Controls.Add(this.txtNro);
            this.Controls.Add(this.lblNro);
            this.Controls.Add(this.lblProveedores);
            this.Name = "frmFiltroProveedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ABM Proveedores";
            this.Load += new System.EventHandler(this.frmFiltroProveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grillaProveedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProveedores;
        private System.Windows.Forms.Label lblNro;
        private System.Windows.Forms.TextBox txtNro;
        private System.Windows.Forms.CheckBox chkMostrarTodosProvee;
        private System.Windows.Forms.Button btnBuscarProveedores;
        private System.Windows.Forms.DataGridView grillaProveedores;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnLimpiarCampos;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelefonoProveedor;
    }
}