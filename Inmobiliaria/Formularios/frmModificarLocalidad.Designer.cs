
namespace Inmobiliaria.Formularios
{
    partial class frmModificarLocalidad
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
            this.button2 = new System.Windows.Forms.Button();
            this.btnModificarLocalidad = new System.Windows.Forms.Button();
            this.cmbDepartamento = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.MaskedTextBox();
            this.btnEliminarLocalidad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button2.Image = global::Inmobiliaria.Properties.Resources.iconfinder_Cancel_728918;
            this.button2.Location = new System.Drawing.Point(28, 174);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(69, 75);
            this.button2.TabIndex = 70;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnModificarLocalidad
            // 
            this.btnModificarLocalidad.BackColor = System.Drawing.SystemColors.Control;
            this.btnModificarLocalidad.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnModificarLocalidad.Image = global::Inmobiliaria.Properties.Resources.iconfinder_floppy_285657;
            this.btnModificarLocalidad.Location = new System.Drawing.Point(240, 174);
            this.btnModificarLocalidad.Name = "btnModificarLocalidad";
            this.btnModificarLocalidad.Size = new System.Drawing.Size(69, 75);
            this.btnModificarLocalidad.TabIndex = 69;
            this.btnModificarLocalidad.UseVisualStyleBackColor = false;
            this.btnModificarLocalidad.Click += new System.EventHandler(this.btnModificarLocalidad_Click);
            // 
            // cmbDepartamento
            // 
            this.cmbDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartamento.FormattingEnabled = true;
            this.cmbDepartamento.Location = new System.Drawing.Point(146, 125);
            this.cmbDepartamento.Name = "cmbDepartamento";
            this.cmbDepartamento.Size = new System.Drawing.Size(160, 21);
            this.cmbDepartamento.TabIndex = 66;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label12.Location = new System.Drawing.Point(36, 14);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(199, 25);
            this.label12.TabIndex = 68;
            this.label12.Text = "Modificar Localidad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 18);
            this.label4.TabIndex = 67;
            this.label4.Text = "Departamento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(79, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 64;
            this.label2.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(146, 86);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(161, 20);
            this.txtNombre.TabIndex = 65;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(118, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 18);
            this.label1.TabIndex = 71;
            this.label1.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(146, 50);
            this.txtID.Mask = "99999";
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(38, 20);
            this.txtID.TabIndex = 72;
            this.txtID.ValidatingType = typeof(int);
            // 
            // btnEliminarLocalidad
            // 
            this.btnEliminarLocalidad.BackColor = System.Drawing.SystemColors.Control;
            this.btnEliminarLocalidad.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnEliminarLocalidad.Image = global::Inmobiliaria.Properties.Resources.iconfinder_trash_bin_garbage_delete_rubbish_waste_3643729;
            this.btnEliminarLocalidad.Location = new System.Drawing.Point(134, 174);
            this.btnEliminarLocalidad.Name = "btnEliminarLocalidad";
            this.btnEliminarLocalidad.Size = new System.Drawing.Size(69, 75);
            this.btnEliminarLocalidad.TabIndex = 69;
            this.btnEliminarLocalidad.UseVisualStyleBackColor = false;
            this.btnEliminarLocalidad.Click += new System.EventHandler(this.btnEliminarLocalidad_Click);
            // 
            // frmModificarLocalidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 267);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnEliminarLocalidad);
            this.Controls.Add(this.btnModificarLocalidad);
            this.Controls.Add(this.cmbDepartamento);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombre);
            this.Name = "frmModificarLocalidad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmModificarLocalidad";
            this.Load += new System.EventHandler(this.frmModificarLocalidad_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnModificarLocalidad;
        public System.Windows.Forms.ComboBox cmbDepartamento;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtID;
        private System.Windows.Forms.Button btnEliminarLocalidad;
    }
}