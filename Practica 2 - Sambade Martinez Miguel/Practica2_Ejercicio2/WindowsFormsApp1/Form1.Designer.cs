namespace Practica2_Ejercicio2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Localidad = new System.Windows.Forms.ComboBox();
            this.Provincia = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Exe = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.RadioButton();
            this.Modify = new System.Windows.Forms.RadioButton();
            this.New = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.Localtxt = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Localidad);
            this.groupBox1.Controls.Add(this.Provincia);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(31, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(530, 145);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información";
            // 
            // Localidad
            // 
            this.Localidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Localidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Localidad.FormattingEnabled = true;
            this.Localidad.Location = new System.Drawing.Point(103, 76);
            this.Localidad.Name = "Localidad";
            this.Localidad.Size = new System.Drawing.Size(401, 21);
            this.Localidad.TabIndex = 3;
            // 
            // Provincia
            // 
            this.Provincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Provincia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Provincia.FormattingEnabled = true;
            this.Provincia.Location = new System.Drawing.Point(103, 40);
            this.Provincia.Name = "Provincia";
            this.Provincia.Size = new System.Drawing.Size(401, 21);
            this.Provincia.TabIndex = 2;
            this.Provincia.SelectedIndexChanged += new System.EventHandler(this.Provincia_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(28, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Localidad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(28, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Provincia";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Localtxt);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.New);
            this.groupBox2.Controls.Add(this.Modify);
            this.groupBox2.Controls.Add(this.Delete);
            this.groupBox2.Controls.Add(this.Exe);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(31, 212);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(530, 173);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gestión información";
            // 
            // Exe
            // 
            this.Exe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exe.Location = new System.Drawing.Point(336, 30);
            this.Exe.Name = "Exe";
            this.Exe.Size = new System.Drawing.Size(168, 83);
            this.Exe.TabIndex = 0;
            this.Exe.Text = "EJECUTAR";
            this.Exe.UseVisualStyleBackColor = true;
            this.Exe.Click += new System.EventHandler(this.Exe_Click);
            // 
            // Delete
            // 
            this.Delete.AutoSize = true;
            this.Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.Location = new System.Drawing.Point(31, 30);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(218, 20);
            this.Delete.TabIndex = 1;
            this.Delete.Text = "Eliminar localidad seleccionada";
            this.Delete.UseVisualStyleBackColor = true;
            // 
            // Modify
            // 
            this.Modify.AutoSize = true;
            this.Modify.Enabled = false;
            this.Modify.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Modify.Location = new System.Drawing.Point(31, 63);
            this.Modify.Name = "Modify";
            this.Modify.Size = new System.Drawing.Size(225, 20);
            this.Modify.TabIndex = 2;
            this.Modify.Text = "Modificar localidad seleccionada";
            this.Modify.UseVisualStyleBackColor = true;
            // 
            // New
            // 
            this.New.AutoSize = true;
            this.New.Checked = true;
            this.New.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.New.Location = new System.Drawing.Point(31, 96);
            this.New.Name = "New";
            this.New.Size = new System.Drawing.Size(125, 20);
            this.New.TabIndex = 3;
            this.New.TabStop = true;
            this.New.Text = "Nueva localidad";
            this.New.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Localidad";
            // 
            // Localtxt
            // 
            this.Localtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Localtxt.Location = new System.Drawing.Point(103, 135);
            this.Localtxt.Name = "Localtxt";
            this.Localtxt.Size = new System.Drawing.Size(401, 22);
            this.Localtxt.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 409);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox Localidad;
        private System.Windows.Forms.ComboBox Provincia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox Localtxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton New;
        private System.Windows.Forms.RadioButton Modify;
        private System.Windows.Forms.RadioButton Delete;
        private System.Windows.Forms.Button Exe;
    }
}

