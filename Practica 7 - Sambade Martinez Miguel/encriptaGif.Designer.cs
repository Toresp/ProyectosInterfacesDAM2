namespace Practica_7___Sambade_Martinez_Miguel
{
    partial class encriptaGif
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.barraProgreso = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.lbMostrar = new System.Windows.Forms.ListBox();
            this.btnEncriptar = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnEncriptarCarpeta = new System.Windows.Forms.Button();
            this.btnDesencriptar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(599, 351);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // barraProgreso
            // 
            this.barraProgreso.Location = new System.Drawing.Point(634, 322);
            this.barraProgreso.Name = "barraProgreso";
            this.barraProgreso.Size = new System.Drawing.Size(387, 41);
            this.barraProgreso.Step = 50;
            this.barraProgreso.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(631, 306);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Proceso de encriptado";
            // 
            // lbMostrar
            // 
            this.lbMostrar.FormattingEnabled = true;
            this.lbMostrar.Location = new System.Drawing.Point(637, 12);
            this.lbMostrar.Name = "lbMostrar";
            this.lbMostrar.Size = new System.Drawing.Size(171, 264);
            this.lbMostrar.TabIndex = 3;
            this.lbMostrar.Click += new System.EventHandler(this.lbMostrar_Click);
            // 
            // btnEncriptar
            // 
            this.btnEncriptar.BackColor = System.Drawing.Color.Red;
            this.btnEncriptar.Location = new System.Drawing.Point(831, 12);
            this.btnEncriptar.Name = "btnEncriptar";
            this.btnEncriptar.Size = new System.Drawing.Size(190, 42);
            this.btnEncriptar.TabIndex = 4;
            this.btnEncriptar.Text = "Encriptar Archivo GIF";
            this.btnEncriptar.UseVisualStyleBackColor = false;
            this.btnEncriptar.Click += new System.EventHandler(this.btnEncriptar_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(831, 139);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(190, 137);
            this.btnMostrar.TabIndex = 5;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnEncriptarCarpeta
            // 
            this.btnEncriptarCarpeta.BackColor = System.Drawing.Color.Red;
            this.btnEncriptarCarpeta.Location = new System.Drawing.Point(831, 60);
            this.btnEncriptarCarpeta.Name = "btnEncriptarCarpeta";
            this.btnEncriptarCarpeta.Size = new System.Drawing.Size(190, 33);
            this.btnEncriptarCarpeta.TabIndex = 6;
            this.btnEncriptarCarpeta.Text = "Encriptar Carpeta con GIF";
            this.btnEncriptarCarpeta.UseVisualStyleBackColor = false;
            this.btnEncriptarCarpeta.Click += new System.EventHandler(this.btnEncriptarCarpeta_Click);
            // 
            // btnDesencriptar
            // 
            this.btnDesencriptar.BackColor = System.Drawing.Color.Lime;
            this.btnDesencriptar.Location = new System.Drawing.Point(831, 99);
            this.btnDesencriptar.Name = "btnDesencriptar";
            this.btnDesencriptar.Size = new System.Drawing.Size(190, 34);
            this.btnDesencriptar.TabIndex = 7;
            this.btnDesencriptar.Text = "Desencriptar";
            this.btnDesencriptar.UseVisualStyleBackColor = false;
            this.btnDesencriptar.Click += new System.EventHandler(this.btnDesencriptar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(634, 366);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Encriptación Finalizada";
            this.label2.Visible = false;
            // 
            // encriptaGif
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 384);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDesencriptar);
            this.Controls.Add(this.btnEncriptarCarpeta);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnEncriptar);
            this.Controls.Add(this.lbMostrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.barraProgreso);
            this.Controls.Add(this.pictureBox1);
            this.Name = "encriptaGif";
            this.Text = "Encripta Gif";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.encriptaGif_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar barraProgreso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbMostrar;
        private System.Windows.Forms.Button btnEncriptar;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnEncriptarCarpeta;
        private System.Windows.Forms.Button btnDesencriptar;
        private System.Windows.Forms.Label label2;
    }
}