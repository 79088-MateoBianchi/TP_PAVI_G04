
namespace Inmobiliaria.Formularios
{
    partial class frmAltaMoneda
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
            this.label12 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCot = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label12.Location = new System.Drawing.Point(31, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(134, 25);
            this.label12.TabIndex = 97;
            this.label12.Text = "Alta Moneda";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 18);
            this.label3.TabIndex = 96;
            this.label3.Text = "Cotizacion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 95;
            this.label2.Text = "Nombre";
            // 
            // txtCot
            // 
            this.txtCot.Location = new System.Drawing.Point(100, 97);
            this.txtCot.Name = "txtCot";
            this.txtCot.Size = new System.Drawing.Size(161, 20);
            this.txtCot.TabIndex = 92;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(100, 67);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(161, 20);
            this.txtNom.TabIndex = 93;
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.SystemColors.Control;
            this.btnActualizar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnActualizar.Image = global::Inmobiliaria.Properties.Resources.iconfinder_floppy_285657;
            this.btnActualizar.Location = new System.Drawing.Point(155, 133);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(69, 75);
            this.btnActualizar.TabIndex = 98;
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button2.Image = global::Inmobiliaria.Properties.Resources.iconfinder_Cancel_728918;
            this.button2.Location = new System.Drawing.Point(59, 133);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(69, 75);
            this.button2.TabIndex = 100;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmAltaMoneda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 220);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCot);
            this.Controls.Add(this.txtNom);
            this.Name = "frmAltaMoneda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta Moneda";
            this.Load += new System.EventHandler(this.frmAltaMoneda_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtCot;
        public System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Button button2;
    }
}