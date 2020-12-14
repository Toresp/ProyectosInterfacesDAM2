namespace Practica4_Miguel_Sambade
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
            this.apel2Box = new System.Windows.Forms.TextBox();
            this.apel1Box = new System.Windows.Forms.TextBox();
            this.nomBox = new System.Windows.Forms.TextBox();
            this.dniBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.engadirProv = new System.Windows.Forms.Button();
            this.provList = new System.Windows.Forms.ComboBox();
            this.eliminarProv = new System.Windows.Forms.Button();
            this.provinBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.engadirProf = new System.Windows.Forms.Button();
            this.eliminarProf = new System.Windows.Forms.Button();
            this.profBox = new System.Windows.Forms.TextBox();
            this.profList = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Disponible = new System.Windows.Forms.ListView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.Details = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.apel2Box);
            this.groupBox1.Controls.Add(this.apel1Box);
            this.groupBox1.Controls.Add(this.nomBox);
            this.groupBox1.Controls.Add(this.dniBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(29, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(441, 169);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Identificación do traballador";
            // 
            // apel2Box
            // 
            this.apel2Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apel2Box.Location = new System.Drawing.Point(89, 113);
            this.apel2Box.Name = "apel2Box";
            this.apel2Box.Size = new System.Drawing.Size(246, 20);
            this.apel2Box.TabIndex = 7;
            // 
            // apel1Box
            // 
            this.apel1Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apel1Box.Location = new System.Drawing.Point(89, 82);
            this.apel1Box.Name = "apel1Box";
            this.apel1Box.Size = new System.Drawing.Size(246, 20);
            this.apel1Box.TabIndex = 6;
            // 
            // nomBox
            // 
            this.nomBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomBox.Location = new System.Drawing.Point(89, 52);
            this.nomBox.Name = "nomBox";
            this.nomBox.Size = new System.Drawing.Size(246, 20);
            this.nomBox.TabIndex = 5;
            // 
            // dniBox
            // 
            this.dniBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dniBox.Location = new System.Drawing.Point(89, 21);
            this.dniBox.Name = "dniBox";
            this.dniBox.Size = new System.Drawing.Size(246, 20);
            this.dniBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Apellido 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellido 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "DNI";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.engadirProv);
            this.groupBox2.Controls.Add(this.provList);
            this.groupBox2.Controls.Add(this.eliminarProv);
            this.groupBox2.Controls.Add(this.provinBox);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(29, 209);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(441, 97);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Provincia do traballador";
            // 
            // engadirProv
            // 
            this.engadirProv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.engadirProv.Location = new System.Drawing.Point(319, 57);
            this.engadirProv.Name = "engadirProv";
            this.engadirProv.Size = new System.Drawing.Size(116, 23);
            this.engadirProv.TabIndex = 10;
            this.engadirProv.Text = "Engadir Provincia";
            this.engadirProv.UseVisualStyleBackColor = true;
            this.engadirProv.Click += new System.EventHandler(this.engadirProv_Click);
            // 
            // provList
            // 
            this.provList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.provList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.provList.FormattingEnabled = true;
            this.provList.Location = new System.Drawing.Point(6, 20);
            this.provList.Name = "provList";
            this.provList.Size = new System.Drawing.Size(297, 21);
            this.provList.TabIndex = 9;
            // 
            // eliminarProv
            // 
            this.eliminarProv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminarProv.Location = new System.Drawing.Point(319, 21);
            this.eliminarProv.Name = "eliminarProv";
            this.eliminarProv.Size = new System.Drawing.Size(116, 23);
            this.eliminarProv.TabIndex = 8;
            this.eliminarProv.Text = "Eliminar Provincia";
            this.eliminarProv.UseVisualStyleBackColor = true;
            this.eliminarProv.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // provinBox
            // 
            this.provinBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.provinBox.Location = new System.Drawing.Point(6, 60);
            this.provinBox.Name = "provinBox";
            this.provinBox.Size = new System.Drawing.Size(299, 20);
            this.provinBox.TabIndex = 8;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.engadirProf);
            this.groupBox3.Controls.Add(this.eliminarProf);
            this.groupBox3.Controls.Add(this.profBox);
            this.groupBox3.Controls.Add(this.profList);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(29, 312);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(441, 221);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Profresión do traballador";
            // 
            // engadirProf
            // 
            this.engadirProf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.engadirProf.Location = new System.Drawing.Point(319, 177);
            this.engadirProf.Name = "engadirProf";
            this.engadirProf.Size = new System.Drawing.Size(116, 23);
            this.engadirProf.TabIndex = 11;
            this.engadirProf.Text = "Engadir Profesion";
            this.engadirProf.UseVisualStyleBackColor = true;
            this.engadirProf.Click += new System.EventHandler(this.engadirProf_Click);
            // 
            // eliminarProf
            // 
            this.eliminarProf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminarProf.Location = new System.Drawing.Point(319, 43);
            this.eliminarProf.Name = "eliminarProf";
            this.eliminarProf.Size = new System.Drawing.Size(116, 23);
            this.eliminarProf.TabIndex = 10;
            this.eliminarProf.Text = "Eliminar Profesion";
            this.eliminarProf.UseVisualStyleBackColor = true;
            this.eliminarProf.Click += new System.EventHandler(this.eliminarProf_Click);
            // 
            // profBox
            // 
            this.profBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profBox.Location = new System.Drawing.Point(6, 180);
            this.profBox.Name = "profBox";
            this.profBox.Size = new System.Drawing.Size(299, 20);
            this.profBox.TabIndex = 9;
            // 
            // profList
            // 
            this.profList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profList.FormattingEnabled = true;
            this.profList.Location = new System.Drawing.Point(6, 43);
            this.profList.Name = "profList";
            this.profList.Size = new System.Drawing.Size(299, 121);
            this.profList.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Disponible);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(488, 24);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(502, 206);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Traballadores Disponibles";
            // 
            // Disponible
            // 
            this.Disponible.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Disponible.FullRowSelect = true;
            this.Disponible.HideSelection = false;
            this.Disponible.Location = new System.Drawing.Point(26, 34);
            this.Disponible.Name = "Disponible";
            this.Disponible.Size = new System.Drawing.Size(458, 155);
            this.Disponible.TabIndex = 0;
            this.Disponible.UseCompatibleStateImageBehavior = false;
            this.Disponible.View = System.Windows.Forms.View.Details;
            this.Disponible.DoubleClick += new System.EventHandler(this.Disponible_DoubleClick);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.Details);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(488, 312);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(502, 221);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Detalles do traballador";
            // 
            // Details
            // 
            this.Details.Enabled = false;
            this.Details.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Details.Location = new System.Drawing.Point(26, 33);
            this.Details.Multiline = true;
            this.Details.Name = "Details";
            this.Details.Size = new System.Drawing.Size(446, 167);
            this.Details.TabIndex = 0;
            // 
            // Add
            // 
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.Location = new System.Drawing.Point(29, 539);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(441, 23);
            this.Add.TabIndex = 12;
            this.Add.Text = "Engadir Traballador";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Delete
            // 
            this.Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.Location = new System.Drawing.Point(488, 255);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(502, 23);
            this.Delete.TabIndex = 13;
            this.Delete.Text = "Eliminar Traballador";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 571);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox dniBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox apel2Box;
        private System.Windows.Forms.TextBox apel1Box;
        private System.Windows.Forms.TextBox nomBox;
        private System.Windows.Forms.TextBox provinBox;
        private System.Windows.Forms.ListBox profList;
        private System.Windows.Forms.Button engadirProv;
        private System.Windows.Forms.ComboBox provList;
        private System.Windows.Forms.Button eliminarProv;
        private System.Windows.Forms.TextBox profBox;
        private System.Windows.Forms.Button eliminarProf;
        private System.Windows.Forms.Button engadirProf;
        private System.Windows.Forms.ListView Disponible;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.TextBox Details;
        private System.Windows.Forms.Button Delete;
    }
}

