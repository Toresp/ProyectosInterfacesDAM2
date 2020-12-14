namespace Practica_7___Sambade_Martinez_Miguel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Archivos = new System.Windows.Forms.ToolStripDropDownButton();
            this.buscaPalabra = new System.Windows.Forms.ToolStripMenuItem();
            this.encripta = new System.Windows.Forms.ToolStripMenuItem();
            this.organiza = new System.Windows.Forms.ToolStripMenuItem();
            this.toolventanas = new System.Windows.Forms.ToolStripDropDownButton();
            this.buscarPalabrasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encriptaGIFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.organizaVideosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Archivos,
            this.toolventanas});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1514, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Archivos
            // 
            this.Archivos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Archivos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buscaPalabra,
            this.encripta,
            this.organiza,
            this.salirToolStripMenuItem});
            this.Archivos.Image = ((System.Drawing.Image)(resources.GetObject("Archivos.Image")));
            this.Archivos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Archivos.Name = "Archivos";
            this.Archivos.Size = new System.Drawing.Size(66, 22);
            this.Archivos.Text = "Archivos";
            // 
            // buscaPalabra
            // 
            this.buscaPalabra.Name = "buscaPalabra";
            this.buscaPalabra.Size = new System.Drawing.Size(180, 22);
            this.buscaPalabra.Text = "Busca Palabra";
            this.buscaPalabra.Click += new System.EventHandler(this.buscaPalabra_Click);
            // 
            // encripta
            // 
            this.encripta.Name = "encripta";
            this.encripta.Size = new System.Drawing.Size(180, 22);
            this.encripta.Text = "Encripta GIF";
            this.encripta.Click += new System.EventHandler(this.encripta_Click);
            // 
            // organiza
            // 
            this.organiza.Name = "organiza";
            this.organiza.Size = new System.Drawing.Size(180, 22);
            this.organiza.Text = "Organiza Videos";
            this.organiza.Click += new System.EventHandler(this.organiza_Click);
            // 
            // toolventanas
            // 
            this.toolventanas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolventanas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buscarPalabrasToolStripMenuItem,
            this.encriptaGIFToolStripMenuItem,
            this.organizaVideosToolStripMenuItem});
            this.toolventanas.Image = ((System.Drawing.Image)(resources.GetObject("toolventanas.Image")));
            this.toolventanas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolventanas.Name = "toolventanas";
            this.toolventanas.Size = new System.Drawing.Size(67, 22);
            this.toolventanas.Text = "Ventanas";
            // 
            // buscarPalabrasToolStripMenuItem
            // 
            this.buscarPalabrasToolStripMenuItem.Name = "buscarPalabrasToolStripMenuItem";
            this.buscarPalabrasToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.buscarPalabrasToolStripMenuItem.Text = "Buscar Palabras";
            this.buscarPalabrasToolStripMenuItem.Visible = false;
            // 
            // encriptaGIFToolStripMenuItem
            // 
            this.encriptaGIFToolStripMenuItem.Name = "encriptaGIFToolStripMenuItem";
            this.encriptaGIFToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.encriptaGIFToolStripMenuItem.Text = "Encripta GIF";
            this.encriptaGIFToolStripMenuItem.Visible = false;
            // 
            // organizaVideosToolStripMenuItem
            // 
            this.organizaVideosToolStripMenuItem.Name = "organizaVideosToolStripMenuItem";
            this.organizaVideosToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.organizaVideosToolStripMenuItem.Text = "Organiza Videos";
            this.organizaVideosToolStripMenuItem.Visible = false;
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1514, 779);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Archivos y Directorios";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton Archivos;
        private System.Windows.Forms.ToolStripMenuItem buscaPalabra;
        private System.Windows.Forms.ToolStripMenuItem encripta;
        private System.Windows.Forms.ToolStripMenuItem organiza;
        private System.Windows.Forms.ToolStripDropDownButton toolventanas;
        private System.Windows.Forms.ToolStripMenuItem buscarPalabrasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem encriptaGIFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem organizaVideosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}

