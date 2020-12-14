namespace Practica_6___Sambade_Martínez_Miguel
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
            this.btnA = new System.Windows.Forms.Button();
            this.btnB = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rtnTodas = new System.Windows.Forms.RadioButton();
            this.rtn1C = new System.Windows.Forms.RadioButton();
            this.rtn1B = new System.Windows.Forms.RadioButton();
            this.rtn1A = new System.Windows.Forms.RadioButton();
            this.Mostrar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rtnTodas2 = new System.Windows.Forms.RadioButton();
            this.rtn2C = new System.Windows.Forms.RadioButton();
            this.rtn2B = new System.Windows.Forms.RadioButton();
            this.rtn2A = new System.Windows.Forms.RadioButton();
            this.Ocultar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listVentanas = new System.Windows.Forms.ListBox();
            this.listCerrar = new System.Windows.Forms.Button();
            this.listOcultar = new System.Windows.Forms.Button();
            this.listMostrar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnA
            // 
            this.btnA.Location = new System.Drawing.Point(26, 12);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(75, 23);
            this.btnA.TabIndex = 0;
            this.btnA.Text = "Hija A";
            this.btnA.UseVisualStyleBackColor = true;
            this.btnA.Click += new System.EventHandler(this.btnA_Click);
            // 
            // btnB
            // 
            this.btnB.Location = new System.Drawing.Point(26, 41);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(75, 23);
            this.btnB.TabIndex = 1;
            this.btnB.Text = "Hija B";
            this.btnB.UseVisualStyleBackColor = true;
            this.btnB.Click += new System.EventHandler(this.btnB_Click);
            // 
            // btnC
            // 
            this.btnC.Location = new System.Drawing.Point(26, 70);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(75, 23);
            this.btnC.TabIndex = 2;
            this.btnC.Text = "Hija C";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rtnTodas);
            this.groupBox1.Controls.Add(this.rtn1C);
            this.groupBox1.Controls.Add(this.rtn1B);
            this.groupBox1.Controls.Add(this.rtn1A);
            this.groupBox1.Controls.Add(this.Mostrar);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(123, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(98, 175);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mostrar";
            // 
            // rtnTodas
            // 
            this.rtnTodas.AutoSize = true;
            this.rtnTodas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.rtnTodas.Location = new System.Drawing.Point(6, 89);
            this.rtnTodas.Name = "rtnTodas";
            this.rtnTodas.Size = new System.Drawing.Size(55, 17);
            this.rtnTodas.TabIndex = 8;
            this.rtnTodas.TabStop = true;
            this.rtnTodas.Text = "Todas";
            this.rtnTodas.UseVisualStyleBackColor = true;
            // 
            // rtn1C
            // 
            this.rtn1C.AutoSize = true;
            this.rtn1C.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.rtn1C.Location = new System.Drawing.Point(7, 66);
            this.rtn1C.Name = "rtn1C";
            this.rtn1C.Size = new System.Drawing.Size(56, 17);
            this.rtn1C.TabIndex = 7;
            this.rtn1C.TabStop = true;
            this.rtn1C.Text = "Tipo C";
            this.rtn1C.UseVisualStyleBackColor = true;
            // 
            // rtn1B
            // 
            this.rtn1B.AutoSize = true;
            this.rtn1B.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.rtn1B.Location = new System.Drawing.Point(6, 43);
            this.rtn1B.Name = "rtn1B";
            this.rtn1B.Size = new System.Drawing.Size(56, 17);
            this.rtn1B.TabIndex = 6;
            this.rtn1B.TabStop = true;
            this.rtn1B.Text = "Tipo B";
            this.rtn1B.UseVisualStyleBackColor = true;
            // 
            // rtn1A
            // 
            this.rtn1A.AutoSize = true;
            this.rtn1A.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.rtn1A.Location = new System.Drawing.Point(7, 20);
            this.rtn1A.Name = "rtn1A";
            this.rtn1A.Size = new System.Drawing.Size(56, 17);
            this.rtn1A.TabIndex = 5;
            this.rtn1A.TabStop = true;
            this.rtn1A.Text = "Tipo A";
            this.rtn1A.UseVisualStyleBackColor = true;
            // 
            // Mostrar
            // 
            this.Mostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Mostrar.Location = new System.Drawing.Point(6, 122);
            this.Mostrar.Name = "Mostrar";
            this.Mostrar.Size = new System.Drawing.Size(58, 19);
            this.Mostrar.TabIndex = 4;
            this.Mostrar.Text = "Mostrar";
            this.Mostrar.UseVisualStyleBackColor = true;
            this.Mostrar.Click += new System.EventHandler(this.Mostrar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rtnTodas2);
            this.groupBox2.Controls.Add(this.rtn2C);
            this.groupBox2.Controls.Add(this.rtn2B);
            this.groupBox2.Controls.Add(this.rtn2A);
            this.groupBox2.Controls.Add(this.Ocultar);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(242, 41);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(98, 175);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ocultar";
            // 
            // rtnTodas2
            // 
            this.rtnTodas2.AutoSize = true;
            this.rtnTodas2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.rtnTodas2.Location = new System.Drawing.Point(6, 89);
            this.rtnTodas2.Name = "rtnTodas2";
            this.rtnTodas2.Size = new System.Drawing.Size(55, 17);
            this.rtnTodas2.TabIndex = 8;
            this.rtnTodas2.TabStop = true;
            this.rtnTodas2.Text = "Todas";
            this.rtnTodas2.UseVisualStyleBackColor = true;
            // 
            // rtn2C
            // 
            this.rtn2C.AutoSize = true;
            this.rtn2C.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.rtn2C.Location = new System.Drawing.Point(7, 66);
            this.rtn2C.Name = "rtn2C";
            this.rtn2C.Size = new System.Drawing.Size(56, 17);
            this.rtn2C.TabIndex = 7;
            this.rtn2C.TabStop = true;
            this.rtn2C.Text = "Tipo C";
            this.rtn2C.UseVisualStyleBackColor = true;
            // 
            // rtn2B
            // 
            this.rtn2B.AutoSize = true;
            this.rtn2B.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.rtn2B.Location = new System.Drawing.Point(6, 43);
            this.rtn2B.Name = "rtn2B";
            this.rtn2B.Size = new System.Drawing.Size(56, 17);
            this.rtn2B.TabIndex = 6;
            this.rtn2B.TabStop = true;
            this.rtn2B.Text = "Tipo B";
            this.rtn2B.UseVisualStyleBackColor = true;
            // 
            // rtn2A
            // 
            this.rtn2A.AutoSize = true;
            this.rtn2A.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtn2A.Location = new System.Drawing.Point(7, 20);
            this.rtn2A.Name = "rtn2A";
            this.rtn2A.Size = new System.Drawing.Size(56, 17);
            this.rtn2A.TabIndex = 5;
            this.rtn2A.TabStop = true;
            this.rtn2A.Text = "Tipo A";
            this.rtn2A.UseVisualStyleBackColor = true;
            // 
            // Ocultar
            // 
            this.Ocultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Ocultar.Location = new System.Drawing.Point(6, 122);
            this.Ocultar.Name = "Ocultar";
            this.Ocultar.Size = new System.Drawing.Size(58, 19);
            this.Ocultar.TabIndex = 4;
            this.Ocultar.Text = "Ocultar";
            this.Ocultar.UseVisualStyleBackColor = true;
            this.Ocultar.Click += new System.EventHandler(this.Ocultar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(160, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Numero de Hijos actuales: 0 ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listVentanas);
            this.groupBox3.Controls.Add(this.listCerrar);
            this.groupBox3.Controls.Add(this.listOcultar);
            this.groupBox3.Controls.Add(this.listMostrar);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(395, 41);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(316, 175);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ventanas Hijas";
            // 
            // listVentanas
            // 
            this.listVentanas.FormattingEnabled = true;
            this.listVentanas.ItemHeight = 16;
            this.listVentanas.Location = new System.Drawing.Point(6, 22);
            this.listVentanas.Name = "listVentanas";
            this.listVentanas.Size = new System.Drawing.Size(304, 116);
            this.listVentanas.TabIndex = 8;
            // 
            // listCerrar
            // 
            this.listCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.listCerrar.Location = new System.Drawing.Point(187, 150);
            this.listCerrar.Name = "listCerrar";
            this.listCerrar.Size = new System.Drawing.Size(58, 19);
            this.listCerrar.TabIndex = 7;
            this.listCerrar.Text = "Cerrar";
            this.listCerrar.UseVisualStyleBackColor = true;
            this.listCerrar.Click += new System.EventHandler(this.listCerrar_Click);
            // 
            // listOcultar
            // 
            this.listOcultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.listOcultar.Location = new System.Drawing.Point(123, 150);
            this.listOcultar.Name = "listOcultar";
            this.listOcultar.Size = new System.Drawing.Size(58, 19);
            this.listOcultar.TabIndex = 6;
            this.listOcultar.Text = "Ocultar";
            this.listOcultar.UseVisualStyleBackColor = true;
            this.listOcultar.Click += new System.EventHandler(this.listOcultar_Click);
            // 
            // listMostrar
            // 
            this.listMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.listMostrar.Location = new System.Drawing.Point(59, 150);
            this.listMostrar.Name = "listMostrar";
            this.listMostrar.Size = new System.Drawing.Size(58, 19);
            this.listMostrar.TabIndex = 5;
            this.listMostrar.Text = "Mostrar";
            this.listMostrar.UseVisualStyleBackColor = true;
            this.listMostrar.Click += new System.EventHandler(this.listMostrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 313);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnB);
            this.Controls.Add(this.btnA);
            this.Name = "Form1";
            this.Text = "PADRE";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.Button btnB;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rtnTodas;
        private System.Windows.Forms.RadioButton rtn1C;
        private System.Windows.Forms.RadioButton rtn1B;
        private System.Windows.Forms.RadioButton rtn1A;
        private System.Windows.Forms.Button Mostrar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rtnTodas2;
        private System.Windows.Forms.RadioButton rtn2C;
        private System.Windows.Forms.RadioButton rtn2B;
        private System.Windows.Forms.RadioButton rtn2A;
        private System.Windows.Forms.Button Ocultar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox listVentanas;
        private System.Windows.Forms.Button listCerrar;
        private System.Windows.Forms.Button listOcultar;
        private System.Windows.Forms.Button listMostrar;
    }
}

