
namespace Inmobiliaria
{
    partial class frmFiltroPropiedades
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFiltroPropiedades));
            this.lblPropiedad = new System.Windows.Forms.Label();
            this.lblDesigCat = new System.Windows.Forms.Label();
            this.txtDesigCat = new System.Windows.Forms.TextBox();
            this.grillaPropiedades = new System.Windows.Forms.DataGridView();
            this.DesignacionCatastral = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Calle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NroCalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdBarrio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdMoneda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdTipoOperacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chkMostrarTodasProp = new System.Windows.Forms.CheckBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.lblMensaje2 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grillaPropiedades)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPropiedad
            // 
            this.lblPropiedad.AutoSize = true;
            this.lblPropiedad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPropiedad.Location = new System.Drawing.Point(52, 30);
            this.lblPropiedad.Name = "lblPropiedad";
            this.lblPropiedad.Size = new System.Drawing.Size(133, 25);
            this.lblPropiedad.TabIndex = 1;
            this.lblPropiedad.Text = "Propiedades";
            // 
            // lblDesigCat
            // 
            this.lblDesigCat.AutoSize = true;
            this.lblDesigCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesigCat.Location = new System.Drawing.Point(68, 72);
            this.lblDesigCat.Name = "lblDesigCat";
            this.lblDesigCat.Size = new System.Drawing.Size(174, 18);
            this.lblDesigCat.TabIndex = 2;
            this.lblDesigCat.Text = "Designacion Catastral";
            // 
            // txtDesigCat
            // 
            this.txtDesigCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesigCat.Location = new System.Drawing.Point(248, 69);
            this.txtDesigCat.Name = "txtDesigCat";
            this.txtDesigCat.Size = new System.Drawing.Size(100, 24);
            this.txtDesigCat.TabIndex = 0;
            // 
            // grillaPropiedades
            // 
            this.grillaPropiedades.AllowUserToAddRows = false;
            this.grillaPropiedades.AllowUserToDeleteRows = false;
            this.grillaPropiedades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaPropiedades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DesignacionCatastral,
            this.Calle,
            this.NroCalle,
            this.IdBarrio,
            this.Monto,
            this.IdMoneda,
            this.IdTipoOperacion});
            this.grillaPropiedades.Location = new System.Drawing.Point(26, 151);
            this.grillaPropiedades.Name = "grillaPropiedades";
            this.grillaPropiedades.ReadOnly = true;
            this.grillaPropiedades.Size = new System.Drawing.Size(706, 235);
            this.grillaPropiedades.TabIndex = 3;
            this.grillaPropiedades.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grillaPropiedades_CellClick);
            // 
            // DesignacionCatastral
            // 
            this.DesignacionCatastral.DataPropertyName = "designacion_catastral";
            this.DesignacionCatastral.HeaderText = "Designacion Catastral";
            this.DesignacionCatastral.Name = "DesignacionCatastral";
            this.DesignacionCatastral.ReadOnly = true;
            // 
            // Calle
            // 
            this.Calle.DataPropertyName = "calle";
            this.Calle.HeaderText = "Calle";
            this.Calle.Name = "Calle";
            this.Calle.ReadOnly = true;
            // 
            // NroCalle
            // 
            this.NroCalle.DataPropertyName = "nro_calle";
            this.NroCalle.HeaderText = "Nro de Calle";
            this.NroCalle.Name = "NroCalle";
            this.NroCalle.ReadOnly = true;
            // 
            // IdBarrio
            // 
            this.IdBarrio.DataPropertyName = "id_barrio";
            this.IdBarrio.HeaderText = "ID Barrio";
            this.IdBarrio.Name = "IdBarrio";
            this.IdBarrio.ReadOnly = true;
            this.IdBarrio.Width = 80;
            // 
            // Monto
            // 
            this.Monto.DataPropertyName = "monto";
            this.Monto.HeaderText = "Monto";
            this.Monto.Name = "Monto";
            this.Monto.ReadOnly = true;
            // 
            // IdMoneda
            // 
            this.IdMoneda.DataPropertyName = "id_moneda";
            this.IdMoneda.HeaderText = "ID Moneda";
            this.IdMoneda.Name = "IdMoneda";
            this.IdMoneda.ReadOnly = true;
            // 
            // IdTipoOperacion
            // 
            this.IdTipoOperacion.DataPropertyName = "id_tipo_operacion";
            this.IdTipoOperacion.HeaderText = "ID Tipo Operacion";
            this.IdTipoOperacion.Name = "IdTipoOperacion";
            this.IdTipoOperacion.ReadOnly = true;
            // 
            // chkMostrarTodasProp
            // 
            this.chkMostrarTodasProp.AutoSize = true;
            this.chkMostrarTodasProp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMostrarTodasProp.Location = new System.Drawing.Point(248, 111);
            this.chkMostrarTodasProp.Name = "chkMostrarTodasProp";
            this.chkMostrarTodasProp.Size = new System.Drawing.Size(257, 22);
            this.chkMostrarTodasProp.TabIndex = 1;
            this.chkMostrarTodasProp.Text = "Mostrar todas las propiedades";
            this.chkMostrarTodasProp.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(641, 104);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(91, 35);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.Location = new System.Drawing.Point(23, 401);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(452, 17);
            this.lblMensaje.TabIndex = 28;
            this.lblMensaje.Text = "Para modificar o eliminar una propiedad debe seleccionarla de la grilla";
            // 
            // lblMensaje2
            // 
            this.lblMensaje2.AutoSize = true;
            this.lblMensaje2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje2.Location = new System.Drawing.Point(23, 434);
            this.lblMensaje2.Name = "lblMensaje2";
            this.lblMensaje2.Size = new System.Drawing.Size(359, 17);
            this.lblMensaje2.TabIndex = 29;
            this.lblMensaje2.Text = "Para actualizar la grilla, vuelva a realizar una busqueda";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackgroundImage = global::Inmobiliaria.Properties.Resources.iconfinder_add1__32378;
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAgregar.Location = new System.Drawing.Point(548, 424);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(74, 74);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackgroundImage = global::Inmobiliaria.Properties.Resources.iconfinder_2_2739118;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSalir.Location = new System.Drawing.Point(662, 424);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(74, 74);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmFiltroPropiedades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 510);
            this.Controls.Add(this.lblMensaje2);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.chkMostrarTodasProp);
            this.Controls.Add(this.grillaPropiedades);
            this.Controls.Add(this.txtDesigCat);
            this.Controls.Add(this.lblDesigCat);
            this.Controls.Add(this.lblPropiedad);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmFiltroPropiedades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ABM de Propiedades";
            this.Load += new System.EventHandler(this.frmFiltroPropiedades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grillaPropiedades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPropiedad;
        private System.Windows.Forms.Label lblDesigCat;
        private System.Windows.Forms.TextBox txtDesigCat;
        private System.Windows.Forms.DataGridView grillaPropiedades;
        private System.Windows.Forms.CheckBox chkMostrarTodasProp;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn DesignacionCatastral;
        private System.Windows.Forms.DataGridViewTextBoxColumn Calle;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroCalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdBarrio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMoneda;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTipoOperacion;
        private System.Windows.Forms.Label lblMensaje2;
    }
}