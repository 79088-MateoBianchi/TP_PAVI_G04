
namespace Inmobiliaria.Formularios
{
    partial class frmModificarEliminarMoneda
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
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCot = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button2.Image = global::Inmobiliaria.Properties.Resources.iconfinder_Cancel_728918;
            this.button2.Location = new System.Drawing.Point(12, 147);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(69, 75);
            this.button2.TabIndex = 90;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.Control;
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnEliminar.Image = global::Inmobiliaria.Properties.Resources.iconfinder_trash_bin_garbage_delete_rubbish_waste_3643729;
            this.btnEliminar.Location = new System.Drawing.Point(127, 147);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(69, 75);
            this.btnEliminar.TabIndex = 89;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.SystemColors.Control;
            this.btnActualizar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnActualizar.Image = global::Inmobiliaria.Properties.Resources.iconfinder_floppy_285657;
            this.btnActualizar.Location = new System.Drawing.Point(250, 147);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(69, 75);
            this.btnActualizar.TabIndex = 88;
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(158, 53);
            this.txtId.Mask = "99999";
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(38, 20);
            this.txtId.TabIndex = 67;
            this.txtId.ValidatingType = typeof(int);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label12.Location = new System.Drawing.Point(34, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(184, 25);
            this.label12.TabIndex = 84;
            this.label12.Text = "Modificar Moneda";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(67, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 18);
            this.label3.TabIndex = 72;
            this.label3.Text = "Cotizacion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(91, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 71;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 18);
            this.label1.TabIndex = 70;
            this.label1.Text = "Id";
            // 
            // txtCot
            // 
            this.txtCot.Location = new System.Drawing.Point(158, 115);
            this.txtCot.Name = "txtCot";
            this.txtCot.Size = new System.Drawing.Size(161, 20);
            this.txtCot.TabIndex = 68;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(158, 85);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(161, 20);
            this.txtNom.TabIndex = 69;
            // 
            // frmModificarEliminarMoneda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 237);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCot);
            this.Controls.Add(this.txtNom);
            this.Name = "frmModificarEliminarMoneda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmModificarEliminarMoneda";
            this.Load += new System.EventHandler(this.frmModificarEliminarMoneda_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.MaskedTextBox txtId;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtCot;
        public System.Windows.Forms.TextBox txtNom;
    }
}