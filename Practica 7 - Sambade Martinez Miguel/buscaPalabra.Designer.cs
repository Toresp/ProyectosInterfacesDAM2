namespace Practica_7___Sambade_Martinez_Miguel
{
    partial class buscaPalabra
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
            this.components = new System.ComponentModel.Container();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.abrirArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPalabra = new System.Windows.Forms.TextBox();
            this.lbText = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.borrarLineaEnArchivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearNuevoArchivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.search = new System.Windows.Forms.Button();
            this.contextMenu.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox
            // 
            this.richTextBox.ContextMenuStrip = this.contextMenu;
            this.richTextBox.Location = new System.Drawing.Point(-2, -2);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(430, 398);
            this.richTextBox.TabIndex = 0;
            this.richTextBox.Text = "";
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirArchivo});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(143, 26);
            // 
            // abrirArchivo
            // 
            this.abrirArchivo.Name = "abrirArchivo";
            this.abrirArchivo.Size = new System.Drawing.Size(142, 22);
            this.abrirArchivo.Text = "Abrir archivo";
            this.abrirArchivo.Click += new System.EventHandler(this.abrirArchivo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(486, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Palabra a buscar";
            // 
            // txtPalabra
            // 
            this.txtPalabra.Location = new System.Drawing.Point(579, 45);
            this.txtPalabra.Name = "txtPalabra";
            this.txtPalabra.Size = new System.Drawing.Size(190, 20);
            this.txtPalabra.TabIndex = 2;
            // 
            // lbText
            // 
            this.lbText.ContextMenuStrip = this.contextMenuStrip1;
            this.lbText.FormattingEnabled = true;
            this.lbText.Location = new System.Drawing.Point(446, 134);
            this.lbText.Name = "lbText";
            this.lbText.Size = new System.Drawing.Size(323, 238);
            this.lbText.TabIndex = 3;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.borrarLineaEnArchivoToolStripMenuItem,
            this.crearNuevoArchivoToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(193, 48);
            // 
            // borrarLineaEnArchivoToolStripMenuItem
            // 
            this.borrarLineaEnArchivoToolStripMenuItem.Name = "borrarLineaEnArchivoToolStripMenuItem";
            this.borrarLineaEnArchivoToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.borrarLineaEnArchivoToolStripMenuItem.Text = "Borrar linea en archivo";
            this.borrarLineaEnArchivoToolStripMenuItem.Click += new System.EventHandler(this.borrarLineaEnArchivoToolStripMenuItem_Click);
            // 
            // crearNuevoArchivoToolStripMenuItem
            // 
            this.crearNuevoArchivoToolStripMenuItem.Name = "crearNuevoArchivoToolStripMenuItem";
            this.crearNuevoArchivoToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.crearNuevoArchivoToolStripMenuItem.Text = "Crear nuevo archivo";
            this.crearNuevoArchivoToolStripMenuItem.Click += new System.EventHandler(this.crearNuevoArchivoToolStripMenuItem_Click);
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(671, 71);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(98, 23);
            this.search.TabIndex = 4;
            this.search.Text = "Buscar";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // buscaPalabra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 392);
            this.Controls.Add(this.search);
            this.Controls.Add(this.lbText);
            this.Controls.Add(this.txtPalabra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox);
            this.Name = "buscaPalabra";
            this.Text = "Busca Palabra";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.buscaPalabra_FormClosing);
            this.contextMenu.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPalabra;
        private System.Windows.Forms.ListBox lbText;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem abrirArchivo;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem borrarLineaEnArchivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearNuevoArchivoToolStripMenuItem;
    }
}