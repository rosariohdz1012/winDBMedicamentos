namespace winDBMedicamentos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.catalogosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medicamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laboratoriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otraOpcionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.primeraOpcionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.segundaOpcionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.terceraOpcionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.catalogosToolStripMenuItem,
            this.otraOpcionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // catalogosToolStripMenuItem
            // 
            this.catalogosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.medicamentoToolStripMenuItem,
            this.laboratoriosToolStripMenuItem});
            this.catalogosToolStripMenuItem.Name = "catalogosToolStripMenuItem";
            this.catalogosToolStripMenuItem.Size = new System.Drawing.Size(108, 29);
            this.catalogosToolStripMenuItem.Text = "Catalogos";
            // 
            // medicamentoToolStripMenuItem
            // 
            this.medicamentoToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.medicamentoToolStripMenuItem.Name = "medicamentoToolStripMenuItem";
            this.medicamentoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.medicamentoToolStripMenuItem.Size = new System.Drawing.Size(295, 34);
            this.medicamentoToolStripMenuItem.Text = "Medicamentos";
            this.medicamentoToolStripMenuItem.Click += new System.EventHandler(this.medicamentoToolStripMenuItem_Click);
            // 
            // laboratoriosToolStripMenuItem
            // 
            this.laboratoriosToolStripMenuItem.Name = "laboratoriosToolStripMenuItem";
            this.laboratoriosToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.laboratoriosToolStripMenuItem.Size = new System.Drawing.Size(295, 34);
            this.laboratoriosToolStripMenuItem.Text = "Laboratorios";
            this.laboratoriosToolStripMenuItem.Click += new System.EventHandler(this.laboratoriosToolStripMenuItem_Click);
            // 
            // otraOpcionToolStripMenuItem
            // 
            this.otraOpcionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.primeraOpcionToolStripMenuItem,
            this.segundaOpcionToolStripMenuItem,
            this.terceraOpcionToolStripMenuItem});
            this.otraOpcionToolStripMenuItem.Name = "otraOpcionToolStripMenuItem";
            this.otraOpcionToolStripMenuItem.Size = new System.Drawing.Size(194, 29);
            this.otraOpcionToolStripMenuItem.Text = "Otra opcion Principal";
            // 
            // primeraOpcionToolStripMenuItem
            // 
            this.primeraOpcionToolStripMenuItem.Name = "primeraOpcionToolStripMenuItem";
            this.primeraOpcionToolStripMenuItem.Size = new System.Drawing.Size(247, 34);
            this.primeraOpcionToolStripMenuItem.Text = "Primera Opcion";
            // 
            // segundaOpcionToolStripMenuItem
            // 
            this.segundaOpcionToolStripMenuItem.Name = "segundaOpcionToolStripMenuItem";
            this.segundaOpcionToolStripMenuItem.Size = new System.Drawing.Size(247, 34);
            this.segundaOpcionToolStripMenuItem.Text = "Segunda Opcion";
            // 
            // terceraOpcionToolStripMenuItem
            // 
            this.terceraOpcionToolStripMenuItem.Name = "terceraOpcionToolStripMenuItem";
            this.terceraOpcionToolStripMenuItem.Size = new System.Drawing.Size(247, 34);
            this.terceraOpcionToolStripMenuItem.Text = "Tercera Opcion";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Sistema de control Clinico";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem catalogosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otraOpcionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem primeraOpcionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem segundaOpcionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem terceraOpcionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medicamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laboratoriosToolStripMenuItem;
    }
}

