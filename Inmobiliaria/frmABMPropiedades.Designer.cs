
namespace Inmobiliaria
{
    partial class frmABMPropiedades
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
            this.lblPropiedades = new System.Windows.Forms.Label();
            this.lblDesignacionCatastral = new System.Windows.Forms.Label();
            this.txtDesignacionCatastral = new System.Windows.Forms.TextBox();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.lblCalle = new System.Windows.Forms.Label();
            this.txtNroCalle = new System.Windows.Forms.TextBox();
            this.lblNroCalle = new System.Windows.Forms.Label();
            this.lblBarrio = new System.Windows.Forms.Label();
            this.cmbBarrio = new System.Windows.Forms.ComboBox();
            this.txtPiso = new System.Windows.Forms.TextBox();
            this.lblPiso = new System.Windows.Forms.Label();
            this.txtDepartamento = new System.Windows.Forms.TextBox();
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.cmbTipoPropiedad = new System.Windows.Forms.ComboBox();
            this.lblTipoPropiedad = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.lblMonto = new System.Windows.Forms.Label();
            this.cmbMoneda = new System.Windows.Forms.ComboBox();
            this.lblMoneda = new System.Windows.Forms.Label();
            this.cmbTipoOperacion = new System.Windows.Forms.ComboBox();
            this.lblTipoOperacion = new System.Windows.Forms.Label();
            this.grillaPropiedades = new System.Windows.Forms.DataGridView();
            this.DesignacionCatastral = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Calle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NroCalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdBarrio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdMoneda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdTipoOperacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGuardarPropiedad = new System.Windows.Forms.Button();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.btnActualizarPropiedad = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblAviso = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grillaPropiedades)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPropiedades
            // 
            this.lblPropiedades.AutoSize = true;
            this.lblPropiedades.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPropiedades.Location = new System.Drawing.Point(21, 24);
            this.lblPropiedades.Name = "lblPropiedades";
            this.lblPropiedades.Size = new System.Drawing.Size(246, 25);
            this.lblPropiedades.TabIndex = 0;
            this.lblPropiedades.Text = "Registro de propiedades";
            // 
            // lblDesignacionCatastral
            // 
            this.lblDesignacionCatastral.AutoSize = true;
            this.lblDesignacionCatastral.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesignacionCatastral.Location = new System.Drawing.Point(52, 74);
            this.lblDesignacionCatastral.Name = "lblDesignacionCatastral";
            this.lblDesignacionCatastral.Size = new System.Drawing.Size(157, 18);
            this.lblDesignacionCatastral.TabIndex = 1;
            this.lblDesignacionCatastral.Text = "Designacion Catastral:";
            // 
            // txtDesignacionCatastral
            // 
            this.txtDesignacionCatastral.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesignacionCatastral.Location = new System.Drawing.Point(229, 71);
            this.txtDesignacionCatastral.Name = "txtDesignacionCatastral";
            this.txtDesignacionCatastral.Size = new System.Drawing.Size(133, 24);
            this.txtDesignacionCatastral.TabIndex = 1;
            // 
            // txtCalle
            // 
            this.txtCalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCalle.Location = new System.Drawing.Point(229, 119);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(133, 24);
            this.txtCalle.TabIndex = 2;
            // 
            // lblCalle
            // 
            this.lblCalle.AutoSize = true;
            this.lblCalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalle.Location = new System.Drawing.Point(159, 122);
            this.lblCalle.Name = "lblCalle";
            this.lblCalle.Size = new System.Drawing.Size(45, 18);
            this.lblCalle.TabIndex = 3;
            this.lblCalle.Text = "Calle:";
            // 
            // txtNroCalle
            // 
            this.txtNroCalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNroCalle.Location = new System.Drawing.Point(229, 167);
            this.txtNroCalle.Name = "txtNroCalle";
            this.txtNroCalle.Size = new System.Drawing.Size(133, 24);
            this.txtNroCalle.TabIndex = 3;
            // 
            // lblNroCalle
            // 
            this.lblNroCalle.AutoSize = true;
            this.lblNroCalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroCalle.Location = new System.Drawing.Point(112, 170);
            this.lblNroCalle.Name = "lblNroCalle";
            this.lblNroCalle.Size = new System.Drawing.Size(94, 18);
            this.lblNroCalle.TabIndex = 5;
            this.lblNroCalle.Text = "Nro de Calle:";
            // 
            // lblBarrio
            // 
            this.lblBarrio.AutoSize = true;
            this.lblBarrio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBarrio.Location = new System.Drawing.Point(152, 214);
            this.lblBarrio.Name = "lblBarrio";
            this.lblBarrio.Size = new System.Drawing.Size(52, 18);
            this.lblBarrio.TabIndex = 7;
            this.lblBarrio.Text = "Barrio:";
            // 
            // cmbBarrio
            // 
            this.cmbBarrio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBarrio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBarrio.FormattingEnabled = true;
            this.cmbBarrio.Location = new System.Drawing.Point(229, 211);
            this.cmbBarrio.Name = "cmbBarrio";
            this.cmbBarrio.Size = new System.Drawing.Size(133, 26);
            this.cmbBarrio.TabIndex = 4;
            // 
            // txtPiso
            // 
            this.txtPiso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPiso.Location = new System.Drawing.Point(547, 122);
            this.txtPiso.Name = "txtPiso";
            this.txtPiso.Size = new System.Drawing.Size(47, 24);
            this.txtPiso.TabIndex = 5;
            // 
            // lblPiso
            // 
            this.lblPiso.AutoSize = true;
            this.lblPiso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPiso.Location = new System.Drawing.Point(487, 125);
            this.lblPiso.Name = "lblPiso";
            this.lblPiso.Size = new System.Drawing.Size(42, 18);
            this.lblPiso.TabIndex = 9;
            this.lblPiso.Text = "Piso:";
            // 
            // txtDepartamento
            // 
            this.txtDepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepartamento.Location = new System.Drawing.Point(547, 170);
            this.txtDepartamento.Name = "txtDepartamento";
            this.txtDepartamento.Size = new System.Drawing.Size(47, 24);
            this.txtDepartamento.TabIndex = 6;
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.AutoSize = true;
            this.lblDepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartamento.Location = new System.Drawing.Point(424, 173);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(106, 18);
            this.lblDepartamento.TabIndex = 11;
            this.lblDepartamento.Text = "Departamento:";
            // 
            // cmbTipoPropiedad
            // 
            this.cmbTipoPropiedad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoPropiedad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoPropiedad.FormattingEnabled = true;
            this.cmbTipoPropiedad.Location = new System.Drawing.Point(229, 261);
            this.cmbTipoPropiedad.Name = "cmbTipoPropiedad";
            this.cmbTipoPropiedad.Size = new System.Drawing.Size(133, 26);
            this.cmbTipoPropiedad.TabIndex = 7;
            // 
            // lblTipoPropiedad
            // 
            this.lblTipoPropiedad.AutoSize = true;
            this.lblTipoPropiedad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoPropiedad.Location = new System.Drawing.Point(72, 264);
            this.lblTipoPropiedad.Name = "lblTipoPropiedad";
            this.lblTipoPropiedad.Size = new System.Drawing.Size(132, 18);
            this.lblTipoPropiedad.TabIndex = 13;
            this.lblTipoPropiedad.Text = "Tipo de Propiedad:";
            // 
            // txtMonto
            // 
            this.txtMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonto.Location = new System.Drawing.Point(229, 320);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(133, 24);
            this.txtMonto.TabIndex = 9;
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonto.Location = new System.Drawing.Point(149, 323);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(55, 18);
            this.lblMonto.TabIndex = 15;
            this.lblMonto.Text = "Monto:";
            // 
            // cmbMoneda
            // 
            this.cmbMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMoneda.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMoneda.FormattingEnabled = true;
            this.cmbMoneda.Location = new System.Drawing.Point(547, 323);
            this.cmbMoneda.Name = "cmbMoneda";
            this.cmbMoneda.Size = new System.Drawing.Size(133, 26);
            this.cmbMoneda.TabIndex = 10;
            // 
            // lblMoneda
            // 
            this.lblMoneda.AutoSize = true;
            this.lblMoneda.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoneda.Location = new System.Drawing.Point(463, 326);
            this.lblMoneda.Name = "lblMoneda";
            this.lblMoneda.Size = new System.Drawing.Size(66, 18);
            this.lblMoneda.TabIndex = 17;
            this.lblMoneda.Text = "Moneda:";
            // 
            // cmbTipoOperacion
            // 
            this.cmbTipoOperacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoOperacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoOperacion.FormattingEnabled = true;
            this.cmbTipoOperacion.Location = new System.Drawing.Point(547, 261);
            this.cmbTipoOperacion.Name = "cmbTipoOperacion";
            this.cmbTipoOperacion.Size = new System.Drawing.Size(133, 26);
            this.cmbTipoOperacion.TabIndex = 8;
            // 
            // lblTipoOperacion
            // 
            this.lblTipoOperacion.AutoSize = true;
            this.lblTipoOperacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoOperacion.Location = new System.Drawing.Point(395, 267);
            this.lblTipoOperacion.Name = "lblTipoOperacion";
            this.lblTipoOperacion.Size = new System.Drawing.Size(134, 18);
            this.lblTipoOperacion.TabIndex = 19;
            this.lblTipoOperacion.Text = "Tipo de Operacion:";
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
            this.grillaPropiedades.Location = new System.Drawing.Point(26, 370);
            this.grillaPropiedades.Name = "grillaPropiedades";
            this.grillaPropiedades.ReadOnly = true;
            this.grillaPropiedades.Size = new System.Drawing.Size(744, 159);
            this.grillaPropiedades.TabIndex = 20;
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
            this.NroCalle.HeaderText = "NroCalle";
            this.NroCalle.Name = "NroCalle";
            this.NroCalle.ReadOnly = true;
            // 
            // IdBarrio
            // 
            this.IdBarrio.DataPropertyName = "id_barrio";
            this.IdBarrio.HeaderText = "ID Barrio";
            this.IdBarrio.Name = "IdBarrio";
            this.IdBarrio.ReadOnly = true;
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
            // btnGuardarPropiedad
            // 
            this.btnGuardarPropiedad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarPropiedad.Location = new System.Drawing.Point(581, 535);
            this.btnGuardarPropiedad.Name = "btnGuardarPropiedad";
            this.btnGuardarPropiedad.Size = new System.Drawing.Size(86, 46);
            this.btnGuardarPropiedad.TabIndex = 21;
            this.btnGuardarPropiedad.Text = "Guardar";
            this.btnGuardarPropiedad.UseVisualStyleBackColor = true;
            this.btnGuardarPropiedad.Click += new System.EventHandler(this.btnGuardarPropiedad_Click);
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarCampos.Location = new System.Drawing.Point(705, 535);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(86, 46);
            this.btnLimpiarCampos.TabIndex = 22;
            this.btnLimpiarCampos.Text = "Limpiar Campos";
            this.btnLimpiarCampos.UseVisualStyleBackColor = true;
            this.btnLimpiarCampos.Click += new System.EventHandler(this.btnLimpiarCampos_Click);
            // 
            // btnActualizarPropiedad
            // 
            this.btnActualizarPropiedad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarPropiedad.Location = new System.Drawing.Point(453, 535);
            this.btnActualizarPropiedad.Name = "btnActualizarPropiedad";
            this.btnActualizarPropiedad.Size = new System.Drawing.Size(90, 46);
            this.btnActualizarPropiedad.TabIndex = 23;
            this.btnActualizarPropiedad.Text = "Actualizar";
            this.btnActualizarPropiedad.UseVisualStyleBackColor = true;
            this.btnActualizarPropiedad.Click += new System.EventHandler(this.btnActualizarPropiedad_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(329, 535);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(90, 46);
            this.btnEliminar.TabIndex = 24;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblAviso
            // 
            this.lblAviso.AutoSize = true;
            this.lblAviso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAviso.Location = new System.Drawing.Point(462, 93);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Size = new System.Drawing.Size(370, 15);
            this.lblAviso.TabIndex = 25;
            this.lblAviso.Text = "En caso de no tener numero de piso o ser de planta baja indique 0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(368, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 15);
            this.label1.TabIndex = 26;
            this.label1.Text = "(*)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(368, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 15);
            this.label2.TabIndex = 27;
            this.label2.Text = "(*)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(368, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 15);
            this.label3.TabIndex = 28;
            this.label3.Text = "(*)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(368, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 15);
            this.label4.TabIndex = 29;
            this.label4.Text = "(*)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(686, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 15);
            this.label5.TabIndex = 30;
            this.label5.Text = "(*)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(686, 328);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 15);
            this.label6.TabIndex = 31;
            this.label6.Text = "(*)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(368, 325);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 15);
            this.label7.TabIndex = 32;
            this.label7.Text = "(*)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(600, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 15);
            this.label8.TabIndex = 33;
            this.label8.Text = "(*)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(368, 267);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 15);
            this.label9.TabIndex = 34;
            this.label9.Text = "(*)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(462, 71);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 15);
            this.label10.TabIndex = 35;
            this.label10.Text = "(*) Campo obligatorio";
            // 
            // frmABMPropiedades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 593);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAviso);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizarPropiedad);
            this.Controls.Add(this.btnLimpiarCampos);
            this.Controls.Add(this.btnGuardarPropiedad);
            this.Controls.Add(this.grillaPropiedades);
            this.Controls.Add(this.cmbTipoOperacion);
            this.Controls.Add(this.lblTipoOperacion);
            this.Controls.Add(this.cmbMoneda);
            this.Controls.Add(this.lblMoneda);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.cmbTipoPropiedad);
            this.Controls.Add(this.lblTipoPropiedad);
            this.Controls.Add(this.txtDepartamento);
            this.Controls.Add(this.lblDepartamento);
            this.Controls.Add(this.txtPiso);
            this.Controls.Add(this.lblPiso);
            this.Controls.Add(this.cmbBarrio);
            this.Controls.Add(this.lblBarrio);
            this.Controls.Add(this.txtNroCalle);
            this.Controls.Add(this.lblNroCalle);
            this.Controls.Add(this.txtCalle);
            this.Controls.Add(this.lblCalle);
            this.Controls.Add(this.txtDesignacionCatastral);
            this.Controls.Add(this.lblDesignacionCatastral);
            this.Controls.Add(this.lblPropiedades);
            this.Name = "frmABMPropiedades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Propiedades";
            this.Load += new System.EventHandler(this.frmABMPropiedades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grillaPropiedades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPropiedades;
        private System.Windows.Forms.Label lblDesignacionCatastral;
        private System.Windows.Forms.TextBox txtDesignacionCatastral;
        private System.Windows.Forms.TextBox txtCalle;
        private System.Windows.Forms.Label lblCalle;
        private System.Windows.Forms.TextBox txtNroCalle;
        private System.Windows.Forms.Label lblNroCalle;
        private System.Windows.Forms.Label lblBarrio;
        private System.Windows.Forms.ComboBox cmbBarrio;
        private System.Windows.Forms.TextBox txtPiso;
        private System.Windows.Forms.Label lblPiso;
        private System.Windows.Forms.TextBox txtDepartamento;
        private System.Windows.Forms.Label lblDepartamento;
        private System.Windows.Forms.ComboBox cmbTipoPropiedad;
        private System.Windows.Forms.Label lblTipoPropiedad;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.ComboBox cmbMoneda;
        private System.Windows.Forms.Label lblMoneda;
        private System.Windows.Forms.ComboBox cmbTipoOperacion;
        private System.Windows.Forms.Label lblTipoOperacion;
        private System.Windows.Forms.DataGridView grillaPropiedades;
        private System.Windows.Forms.Button btnGuardarPropiedad;
        private System.Windows.Forms.Button btnLimpiarCampos;
        private System.Windows.Forms.Button btnActualizarPropiedad;
        private System.Windows.Forms.DataGridViewTextBoxColumn DesignacionCatastral;
        private System.Windows.Forms.DataGridViewTextBoxColumn Calle;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroCalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdBarrio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMoneda;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTipoOperacion;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblAviso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}