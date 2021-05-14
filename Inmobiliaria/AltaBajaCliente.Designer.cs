
namespace Inmobiliaria
{
    partial class AltaBajaCliente
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
            this.gdrClientes = new System.Windows.Forms.DataGridView();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.btnAgregarCliente = new System.Windows.Forms.Button();
            this.btnModificarCliente = new System.Windows.Forms.Button();
            this.btnEliminarCliente = new System.Windows.Forms.Button();
            this.btnVolverPrincipal = new System.Windows.Forms.Button();
            this.Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadDptos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ascensor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelefonoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Calle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroCalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdBarrio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gdrClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // gdrClientes
            // 
            this.gdrClientes.AllowUserToAddRows = false;
            this.gdrClientes.AllowUserToDeleteRows = false;
            this.gdrClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdrClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Documento,
            this.CantidadDptos,
            this.Ascensor,
            this.ApellidoCliente,
            this.TelefonoCliente,
            this.Calle,
            this.NumeroCalle,
            this.IdBarrio});
            this.gdrClientes.Location = new System.Drawing.Point(12, 72);
            this.gdrClientes.Name = "gdrClientes";
            this.gdrClientes.ReadOnly = true;
            this.gdrClientes.Size = new System.Drawing.Size(703, 284);
            this.gdrClientes.TabIndex = 15;
            this.gdrClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdrClientes_CellClick);
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(12, 27);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(124, 20);
            this.txtNombreCliente.TabIndex = 1;
            this.txtNombreCliente.Tag = "";
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Location = new System.Drawing.Point(142, 27);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(102, 20);
            this.btnBuscarCliente.TabIndex = 16;
            this.btnBuscarCliente.Text = "Buscar";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            // 
            // btnAgregarCliente
            // 
            this.btnAgregarCliente.Location = new System.Drawing.Point(538, 27);
            this.btnAgregarCliente.Name = "btnAgregarCliente";
            this.btnAgregarCliente.Size = new System.Drawing.Size(177, 20);
            this.btnAgregarCliente.TabIndex = 17;
            this.btnAgregarCliente.Text = "Nuevo Cliente";
            this.btnAgregarCliente.UseVisualStyleBackColor = true;
            this.btnAgregarCliente.Click += new System.EventHandler(this.btnAgregarCliente_Click);
            // 
            // btnModificarCliente
            // 
            this.btnModificarCliente.Location = new System.Drawing.Point(379, 362);
            this.btnModificarCliente.Name = "btnModificarCliente";
            this.btnModificarCliente.Size = new System.Drawing.Size(165, 39);
            this.btnModificarCliente.TabIndex = 19;
            this.btnModificarCliente.Text = "Modificar Cliente";
            this.btnModificarCliente.UseVisualStyleBackColor = true;
            // 
            // btnEliminarCliente
            // 
            this.btnEliminarCliente.Location = new System.Drawing.Point(550, 363);
            this.btnEliminarCliente.Name = "btnEliminarCliente";
            this.btnEliminarCliente.Size = new System.Drawing.Size(165, 39);
            this.btnEliminarCliente.TabIndex = 20;
            this.btnEliminarCliente.Text = "Eliminar Cliente";
            this.btnEliminarCliente.UseVisualStyleBackColor = true;
            // 
            // btnVolverPrincipal
            // 
            this.btnVolverPrincipal.Location = new System.Drawing.Point(12, 363);
            this.btnVolverPrincipal.Name = "btnVolverPrincipal";
            this.btnVolverPrincipal.Size = new System.Drawing.Size(165, 39);
            this.btnVolverPrincipal.TabIndex = 21;
            this.btnVolverPrincipal.Text = "Volver al Inicio";
            this.btnVolverPrincipal.UseVisualStyleBackColor = true;
            // 
            // Documento
            // 
            this.Documento.DataPropertyName = "nro_documento_c";
            this.Documento.HeaderText = "Documento";
            this.Documento.Name = "Documento";
            this.Documento.ReadOnly = true;
            // 
            // CantidadDptos
            // 
            this.CantidadDptos.DataPropertyName = "tipo_documento_c";
            this.CantidadDptos.HeaderText = "TipoDocumento";
            this.CantidadDptos.Name = "CantidadDptos";
            this.CantidadDptos.ReadOnly = true;
            // 
            // Ascensor
            // 
            this.Ascensor.DataPropertyName = "n_cliente";
            this.Ascensor.HeaderText = "Nombre";
            this.Ascensor.Name = "Ascensor";
            this.Ascensor.ReadOnly = true;
            this.Ascensor.Width = 90;
            // 
            // ApellidoCliente
            // 
            this.ApellidoCliente.DataPropertyName = "apellido_cliente";
            this.ApellidoCliente.HeaderText = "Apellido";
            this.ApellidoCliente.Name = "ApellidoCliente";
            this.ApellidoCliente.ReadOnly = true;
            this.ApellidoCliente.Width = 90;
            // 
            // TelefonoCliente
            // 
            this.TelefonoCliente.DataPropertyName = "tel_cliente";
            this.TelefonoCliente.HeaderText = "Telefono";
            this.TelefonoCliente.Name = "TelefonoCliente";
            this.TelefonoCliente.ReadOnly = true;
            this.TelefonoCliente.Width = 70;
            // 
            // Calle
            // 
            this.Calle.DataPropertyName = "calle";
            this.Calle.HeaderText = "Calle";
            this.Calle.Name = "Calle";
            this.Calle.ReadOnly = true;
            this.Calle.Width = 80;
            // 
            // NumeroCalle
            // 
            this.NumeroCalle.DataPropertyName = "nro_calle";
            this.NumeroCalle.HeaderText = "Nro Casa";
            this.NumeroCalle.Name = "NumeroCalle";
            this.NumeroCalle.ReadOnly = true;
            this.NumeroCalle.Width = 70;
            // 
            // IdBarrio
            // 
            this.IdBarrio.DataPropertyName = "id_barrio";
            this.IdBarrio.HeaderText = "IdBarrio";
            this.IdBarrio.Name = "IdBarrio";
            this.IdBarrio.ReadOnly = true;
            this.IdBarrio.Width = 60;
            // 
            // AltaBajaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 408);
            this.Controls.Add(this.btnVolverPrincipal);
            this.Controls.Add(this.btnEliminarCliente);
            this.Controls.Add(this.btnModificarCliente);
            this.Controls.Add(this.btnAgregarCliente);
            this.Controls.Add(this.btnBuscarCliente);
            this.Controls.Add(this.txtNombreCliente);
            this.Controls.Add(this.gdrClientes);
            this.Name = "AltaBajaCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AltaBajaCliente";
            this.Load += new System.EventHandler(this.AltaBajaCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gdrClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gdrClientes;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.Button btnAgregarCliente;
        private System.Windows.Forms.Button btnModificarCliente;
        private System.Windows.Forms.Button btnEliminarCliente;
        private System.Windows.Forms.Button btnVolverPrincipal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadDptos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ascensor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelefonoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Calle;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroCalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdBarrio;
    }
}