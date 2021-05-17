
namespace Inmobiliaria
{
    partial class frmPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBMEmpleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarEliminarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.propiedadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarEliminarPropiedadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.escribanosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBMEscribanosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ABMDepartamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localidadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBMLocalidadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vistasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.monedasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBMMonedasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.vistasToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.empleadosToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.propiedadesToolStripMenuItem,
            this.escribanosToolStripMenuItem,
            this.departamentosToolStripMenuItem,
            this.monedasToolStripMenuItem,
            this.localidadesToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // empleadosToolStripMenuItem
            // 
            this.empleadosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aBMEmpleadosToolStripMenuItem});
            this.empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            this.empleadosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.empleadosToolStripMenuItem.Text = "Empleados";
            // 
            // aBMEmpleadosToolStripMenuItem
            // 
            this.aBMEmpleadosToolStripMenuItem.Image = global::Inmobiliaria.Properties.Resources.iconfinder_user_group_285648;
            this.aBMEmpleadosToolStripMenuItem.Name = "aBMEmpleadosToolStripMenuItem";
            this.aBMEmpleadosToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.aBMEmpleadosToolStripMenuItem.Text = "ABM Empleados";
            this.aBMEmpleadosToolStripMenuItem.Click += new System.EventHandler(this.aBMEmpleadosToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarEliminarClienteToolStripMenuItem,
            this.modificarClienteToolStripMenuItem});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // registrarEliminarClienteToolStripMenuItem
            // 
            this.registrarEliminarClienteToolStripMenuItem.Name = "registrarEliminarClienteToolStripMenuItem";
            this.registrarEliminarClienteToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.registrarEliminarClienteToolStripMenuItem.Text = "Registrar/Eliminar Cliente";
            // 
            // modificarClienteToolStripMenuItem
            // 
            this.modificarClienteToolStripMenuItem.Name = "modificarClienteToolStripMenuItem";
            this.modificarClienteToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.modificarClienteToolStripMenuItem.Text = "Modificar Cliente";
            // 
            // propiedadesToolStripMenuItem
            // 
            this.propiedadesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarEliminarPropiedadesToolStripMenuItem});
            this.propiedadesToolStripMenuItem.Name = "propiedadesToolStripMenuItem";
            this.propiedadesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.propiedadesToolStripMenuItem.Text = "Propiedades";
            // 
            // registrarEliminarPropiedadesToolStripMenuItem
            // 
            this.registrarEliminarPropiedadesToolStripMenuItem.Name = "registrarEliminarPropiedadesToolStripMenuItem";
            this.registrarEliminarPropiedadesToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.registrarEliminarPropiedadesToolStripMenuItem.Text = "ABM Propiedades";
            this.registrarEliminarPropiedadesToolStripMenuItem.Click += new System.EventHandler(this.registrarEliminarPropiedadesToolStripMenuItem_Click);
            // 
            // escribanosToolStripMenuItem
            // 
            this.escribanosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aBMEscribanosToolStripMenuItem});
            this.escribanosToolStripMenuItem.Name = "escribanosToolStripMenuItem";
            this.escribanosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.escribanosToolStripMenuItem.Text = "Escribanos";
            // 
            // aBMEscribanosToolStripMenuItem
            // 
            this.aBMEscribanosToolStripMenuItem.Name = "aBMEscribanosToolStripMenuItem";
            this.aBMEscribanosToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.aBMEscribanosToolStripMenuItem.Text = "ABM Escribanos";
            this.aBMEscribanosToolStripMenuItem.Click += new System.EventHandler(this.aBMEscribanosToolStripMenuItem_Click);
            // 
            // departamentosToolStripMenuItem
            // 
            this.departamentosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ABMDepartamentosToolStripMenuItem});
            this.departamentosToolStripMenuItem.Name = "departamentosToolStripMenuItem";
            this.departamentosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.departamentosToolStripMenuItem.Text = "Departamentos";
            // 
            // ABMDepartamentosToolStripMenuItem
            // 
            this.ABMDepartamentosToolStripMenuItem.Image = global::Inmobiliaria.Properties.Resources.ABM_Departamentos;
            this.ABMDepartamentosToolStripMenuItem.Name = "ABMDepartamentosToolStripMenuItem";
            this.ABMDepartamentosToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.ABMDepartamentosToolStripMenuItem.Text = "ABM Departamentos";
            this.ABMDepartamentosToolStripMenuItem.Click += new System.EventHandler(this.ABMDepartamentosToolStripMenuItem_Click);
            // 
            // localidadesToolStripMenuItem
            // 
            this.localidadesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aBMLocalidadesToolStripMenuItem});
            this.localidadesToolStripMenuItem.Name = "localidadesToolStripMenuItem";
            this.localidadesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.localidadesToolStripMenuItem.Text = "Localidades";
            // 
            // aBMLocalidadesToolStripMenuItem
            // 
            this.aBMLocalidadesToolStripMenuItem.Name = "aBMLocalidadesToolStripMenuItem";
            this.aBMLocalidadesToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.aBMLocalidadesToolStripMenuItem.Text = "ABM Localidades";
            this.aBMLocalidadesToolStripMenuItem.Click += new System.EventHandler(this.aBMLocalidadesToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.editarToolStripMenuItem.Text = "Editar";
            // 
            // vistasToolStripMenuItem
            // 
            this.vistasToolStripMenuItem.Name = "vistasToolStripMenuItem";
            this.vistasToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.vistasToolStripMenuItem.Text = "Vistas";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Inmobiliaria.Properties.Resources.casa_inmobiliaria;
            this.pictureBox1.Location = new System.Drawing.Point(0, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 426);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // monedasToolStripMenuItem
            // 
            this.monedasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aBMMonedasToolStripMenuItem});
            this.monedasToolStripMenuItem.Name = "monedasToolStripMenuItem";
            this.monedasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.monedasToolStripMenuItem.Text = "Monedas";
            // 
            // aBMMonedasToolStripMenuItem
            // 
            this.aBMMonedasToolStripMenuItem.Name = "aBMMonedasToolStripMenuItem";
            this.aBMMonedasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aBMMonedasToolStripMenuItem.Text = "ABM Monedas";
            this.aBMMonedasToolStripMenuItem.Click += new System.EventHandler(this.aBMMonedasToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarEliminarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem propiedadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarEliminarPropiedadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem departamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vistasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem escribanosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBMEscribanosToolStripMenuItem;
        
        private System.Windows.Forms.ToolStripMenuItem ABMDepartamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBMEmpleadosToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem monedasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBMMonedasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem localidadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBMLocalidadesToolStripMenuItem;
    }
}