
namespace Inmobiliaria
{
    partial class AltaEdificio
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNombreEdificio = new System.Windows.Forms.TextBox();
            this.txtCantidadDptos = new System.Windows.Forms.MaskedTextBox();
            this.chkAscensor = new System.Windows.Forms.CheckBox();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.gdrEdificios = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.btnActualizarEdificio = new System.Windows.Forms.Button();
            this.txtNumeroCalle = new System.Windows.Forms.MaskedTextBox();
            this.txtIdBarrio = new System.Windows.Forms.MaskedTextBox();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadDptos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ascensor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Calle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroCalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdBarrio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gdrEdificios)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del Edificio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cantidad de Departamentos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(128, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ascensor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(157, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Calle";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(80, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Numero de Calle";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(133, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "ID Barrio";
            // 
            // txtNombreEdificio
            // 
            this.txtNombreEdificio.Location = new System.Drawing.Point(205, 110);
            this.txtNombreEdificio.Name = "txtNombreEdificio";
            this.txtNombreEdificio.Size = new System.Drawing.Size(130, 20);
            this.txtNombreEdificio.TabIndex = 6;
            // 
            // txtCantidadDptos
            // 
            this.txtCantidadDptos.Location = new System.Drawing.Point(204, 142);
            this.txtCantidadDptos.Mask = "999";
            this.txtCantidadDptos.Name = "txtCantidadDptos";
            this.txtCantidadDptos.Size = new System.Drawing.Size(24, 20);
            this.txtCantidadDptos.TabIndex = 7;
            this.txtCantidadDptos.ValidatingType = typeof(int);
            // 
            // chkAscensor
            // 
            this.chkAscensor.AutoSize = true;
            this.chkAscensor.Location = new System.Drawing.Point(205, 178);
            this.chkAscensor.Name = "chkAscensor";
            this.chkAscensor.Size = new System.Drawing.Size(15, 14);
            this.chkAscensor.TabIndex = 8;
            this.chkAscensor.UseVisualStyleBackColor = true;
            // 
            // txtCalle
            // 
            this.txtCalle.Location = new System.Drawing.Point(204, 204);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(131, 20);
            this.txtCalle.TabIndex = 9;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(205, 306);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(91, 48);
            this.btnAgregar.TabIndex = 12;
            this.btnAgregar.Text = "Guardar Edificio";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.Location = new System.Drawing.Point(12, 306);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(89, 48);
            this.btnLimpiarCampos.TabIndex = 13;
            this.btnLimpiarCampos.Text = "Limpiar Campos";
            this.btnLimpiarCampos.UseVisualStyleBackColor = true;
            this.btnLimpiarCampos.Click += new System.EventHandler(this.btnLimpiarCampos_Click);
            // 
            // gdrEdificios
            // 
            this.gdrEdificios.AllowUserToAddRows = false;
            this.gdrEdificios.AllowUserToDeleteRows = false;
            this.gdrEdificios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdrEdificios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.CantidadDptos,
            this.Ascensor,
            this.Calle,
            this.NumeroCalle,
            this.IdBarrio});
            this.gdrEdificios.Location = new System.Drawing.Point(353, 12);
            this.gdrEdificios.Name = "gdrEdificios";
            this.gdrEdificios.ReadOnly = true;
            this.gdrEdificios.Size = new System.Drawing.Size(524, 407);
            this.gdrEdificios.TabIndex = 14;
            this.gdrEdificios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdrEdificios_CellClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Coral;
            this.label7.Location = new System.Drawing.Point(17, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 31);
            this.label7.TabIndex = 15;
            this.label7.Text = "Edificios";
            // 
            // btnActualizarEdificio
            // 
            this.btnActualizarEdificio.Enabled = false;
            this.btnActualizarEdificio.Location = new System.Drawing.Point(110, 306);
            this.btnActualizarEdificio.Name = "btnActualizarEdificio";
            this.btnActualizarEdificio.Size = new System.Drawing.Size(89, 48);
            this.btnActualizarEdificio.TabIndex = 16;
            this.btnActualizarEdificio.Text = "Actualizar Edificio";
            this.btnActualizarEdificio.UseVisualStyleBackColor = true;
            this.btnActualizarEdificio.Click += new System.EventHandler(this.btnActualizarEdificio_Click);
            // 
            // txtNumeroCalle
            // 
            this.txtNumeroCalle.Location = new System.Drawing.Point(205, 244);
            this.txtNumeroCalle.Mask = "99999";
            this.txtNumeroCalle.Name = "txtNumeroCalle";
            this.txtNumeroCalle.Size = new System.Drawing.Size(35, 20);
            this.txtNumeroCalle.TabIndex = 17;
            this.txtNumeroCalle.ValidatingType = typeof(int);
            // 
            // txtIdBarrio
            // 
            this.txtIdBarrio.Location = new System.Drawing.Point(205, 271);
            this.txtIdBarrio.Mask = "999";
            this.txtIdBarrio.Name = "txtIdBarrio";
            this.txtIdBarrio.Size = new System.Drawing.Size(23, 20);
            this.txtIdBarrio.TabIndex = 18;
            this.txtIdBarrio.ValidatingType = typeof(int);
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "n_edificio";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // CantidadDptos
            // 
            this.CantidadDptos.DataPropertyName = "cantidad_deptos";
            this.CantidadDptos.HeaderText = "Cantidad de Departamentos";
            this.CantidadDptos.Name = "CantidadDptos";
            this.CantidadDptos.ReadOnly = true;
            this.CantidadDptos.Width = 85;
            // 
            // Ascensor
            // 
            this.Ascensor.DataPropertyName = "tiene_ascensor";
            this.Ascensor.HeaderText = "Ascensor";
            this.Ascensor.Name = "Ascensor";
            this.Ascensor.ReadOnly = true;
            this.Ascensor.Width = 60;
            // 
            // Calle
            // 
            this.Calle.DataPropertyName = "calle";
            this.Calle.HeaderText = "Calle";
            this.Calle.Name = "Calle";
            this.Calle.ReadOnly = true;
            // 
            // NumeroCalle
            // 
            this.NumeroCalle.DataPropertyName = "nro_calle";
            this.NumeroCalle.HeaderText = "Numero de Calle";
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
            this.IdBarrio.Width = 65;
            // 
            // AltaEdificio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 431);
            this.Controls.Add(this.txtIdBarrio);
            this.Controls.Add(this.txtNumeroCalle);
            this.Controls.Add(this.btnActualizarEdificio);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.gdrEdificios);
            this.Controls.Add(this.btnLimpiarCampos);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtCalle);
            this.Controls.Add(this.chkAscensor);
            this.Controls.Add(this.txtCantidadDptos);
            this.Controls.Add(this.txtNombreEdificio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AltaEdificio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ABM Edificios";
            this.Load += new System.EventHandler(this.AltaEdificio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gdrEdificios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNombreEdificio;
        private System.Windows.Forms.MaskedTextBox txtCantidadDptos;
        private System.Windows.Forms.CheckBox chkAscensor;
        private System.Windows.Forms.TextBox txtCalle;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnLimpiarCampos;
        private System.Windows.Forms.DataGridView gdrEdificios;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnActualizarEdificio;
        private System.Windows.Forms.MaskedTextBox txtNumeroCalle;
        private System.Windows.Forms.MaskedTextBox txtIdBarrio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadDptos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ascensor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Calle;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroCalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdBarrio;
    }
}