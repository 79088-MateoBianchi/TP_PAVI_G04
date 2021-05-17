
namespace Inmobiliaria.Formularios
{
    partial class frmFiltroMoneda
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
            this.gdrMonedas = new System.Windows.Forms.DataGridView();
            this.IdMoneda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreMoneda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CotizacionMoneda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtFiltrarPorMoneda = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdrMonedas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInicio
            // 
            this.btnInicio.BackColor = System.Drawing.SystemColors.Control;
            this.btnInicio.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnInicio.Image = global::Inmobiliaria.Properties.Resources.iconfinder_2_2739118;
            this.btnInicio.Location = new System.Drawing.Point(426, 440);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(69, 75);
            this.btnInicio.TabIndex = 7;
            this.btnInicio.UseVisualStyleBackColor = false;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click_1);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.SystemColors.Control;
            this.btnActualizar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnActualizar.Image = global::Inmobiliaria.Properties.Resources.iconfinder_reload_46828;
            this.btnActualizar.Location = new System.Drawing.Point(148, 440);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(69, 75);
            this.btnActualizar.TabIndex = 8;
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click_1);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.Control;
            this.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAgregar.Image = global::Inmobiliaria.Properties.Resources.iconfinder_add1__32378;
            this.btnAgregar.Location = new System.Drawing.Point(39, 440);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(69, 75);
            this.btnAgregar.TabIndex = 9;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.gdrMonedas);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.txtFiltrarPorMoneda);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(493, 408);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro Moneda";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 350);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(476, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "*Seleccione una moneda de la tabla para modificar o eliminar*";
            // 
            // gdrMonedas
            // 
            this.gdrMonedas.AllowUserToAddRows = false;
            this.gdrMonedas.AllowUserToDeleteRows = false;
            this.gdrMonedas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdrMonedas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdMoneda,
            this.NombreMoneda,
            this.CotizacionMoneda});
            this.gdrMonedas.Location = new System.Drawing.Point(5, 105);
            this.gdrMonedas.Name = "gdrMonedas";
            this.gdrMonedas.ReadOnly = true;
            this.gdrMonedas.Size = new System.Drawing.Size(487, 232);
            this.gdrMonedas.TabIndex = 1;
            this.gdrMonedas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdrMonedas_CellClick);
            // 
            // IdMoneda
            // 
            this.IdMoneda.DataPropertyName = "id_moneda";
            this.IdMoneda.HeaderText = "Id";
            this.IdMoneda.Name = "IdMoneda";
            this.IdMoneda.ReadOnly = true;
            this.IdMoneda.Width = 50;
            // 
            // NombreMoneda
            // 
            this.NombreMoneda.DataPropertyName = "n_moneda";
            this.NombreMoneda.HeaderText = "Nombre de Moneda";
            this.NombreMoneda.Name = "NombreMoneda";
            this.NombreMoneda.ReadOnly = true;
            this.NombreMoneda.Width = 195;
            // 
            // CotizacionMoneda
            // 
            this.CotizacionMoneda.DataPropertyName = "cotizacion_pesos_arg";
            this.CotizacionMoneda.HeaderText = "Cotizacion";
            this.CotizacionMoneda.Name = "CotizacionMoneda";
            this.CotizacionMoneda.ReadOnly = true;
            this.CotizacionMoneda.Width = 195;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.Control;
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnBuscar.Image = global::Inmobiliaria.Properties.Resources.buscar;
            this.btnBuscar.Location = new System.Drawing.Point(298, 39);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(45, 43);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click_1);
            // 
            // txtFiltrarPorMoneda
            // 
            this.txtFiltrarPorMoneda.Location = new System.Drawing.Point(156, 47);
            this.txtFiltrarPorMoneda.Name = "txtFiltrarPorMoneda";
            this.txtFiltrarPorMoneda.Size = new System.Drawing.Size(136, 26);
            this.txtFiltrarPorMoneda.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre Moneda";
            // 
            // frmFiltroMoneda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 523);
            this.Controls.Add(this.btnInicio);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmFiltroMoneda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inmobiliaria";
            this.Load += new System.EventHandler(this.frmFiltroMoneda_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdrMonedas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView gdrMonedas;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtFiltrarPorMoneda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMoneda;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreMoneda;
        private System.Windows.Forms.DataGridViewTextBoxColumn CotizacionMoneda;
    }
}