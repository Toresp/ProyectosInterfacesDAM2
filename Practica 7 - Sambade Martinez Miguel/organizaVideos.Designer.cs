namespace Practica_7___Sambade_Martinez_Miguel
{
    partial class organizaVideos
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
            this.tvFolders = new System.Windows.Forms.TreeView();
            this.lbVideos = new System.Windows.Forms.ListBox();
            this.btnCarpeta = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Fecha = new System.Windows.Forms.DateTimePicker();
            this.labCarpeta = new System.Windows.Forms.Label();
            this.btnOrganiza = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Carpetas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(336, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Videos carpeta seleccionada";
            // 
            // tvFolders
            // 
            this.tvFolders.Location = new System.Drawing.Point(12, 35);
            this.tvFolders.Name = "tvFolders";
            this.tvFolders.Size = new System.Drawing.Size(304, 440);
            this.tvFolders.TabIndex = 2;
            // 
            // lbVideos
            // 
            this.lbVideos.FormattingEnabled = true;
            this.lbVideos.Location = new System.Drawing.Point(339, 35);
            this.lbVideos.Name = "lbVideos";
            this.lbVideos.Size = new System.Drawing.Size(202, 433);
            this.lbVideos.TabIndex = 3;
            // 
            // btnCarpeta
            // 
            this.btnCarpeta.Location = new System.Drawing.Point(621, 35);
            this.btnCarpeta.Name = "btnCarpeta";
            this.btnCarpeta.Size = new System.Drawing.Size(293, 84);
            this.btnCarpeta.TabIndex = 4;
            this.btnCarpeta.Text = "Seleccione Carpeta";
            this.btnCarpeta.UseVisualStyleBackColor = true;
            this.btnCarpeta.Click += new System.EventHandler(this.btnCarpeta_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(618, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Carpeta Seleccionada";
            // 
            // Fecha
            // 
            this.Fecha.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fecha.Location = new System.Drawing.Point(621, 243);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(243, 21);
            this.Fecha.TabIndex = 6;
            // 
            // labCarpeta
            // 
            this.labCarpeta.AutoSize = true;
            this.labCarpeta.Location = new System.Drawing.Point(618, 218);
            this.labCarpeta.Name = "labCarpeta";
            this.labCarpeta.Size = new System.Drawing.Size(0, 13);
            this.labCarpeta.TabIndex = 7;
            // 
            // btnOrganiza
            // 
            this.btnOrganiza.BackColor = System.Drawing.Color.Lime;
            this.btnOrganiza.Location = new System.Drawing.Point(604, 408);
            this.btnOrganiza.Name = "btnOrganiza";
            this.btnOrganiza.Size = new System.Drawing.Size(321, 60);
            this.btnOrganiza.TabIndex = 8;
            this.btnOrganiza.Text = "Organiza";
            this.btnOrganiza.UseVisualStyleBackColor = false;
            this.btnOrganiza.Click += new System.EventHandler(this.btnOrganiza_Click);
            // 
            // organizaVideos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 487);
            this.Controls.Add(this.btnOrganiza);
            this.Controls.Add(this.labCarpeta);
            this.Controls.Add(this.Fecha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCarpeta);
            this.Controls.Add(this.lbVideos);
            this.Controls.Add(this.tvFolders);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "organizaVideos";
            this.Text = "organizaVideos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.organizaVideos_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TreeView tvFolders;
        private System.Windows.Forms.ListBox lbVideos;
        private System.Windows.Forms.Button btnCarpeta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker Fecha;
        private System.Windows.Forms.Label labCarpeta;
        private System.Windows.Forms.Button btnOrganiza;
    }
}