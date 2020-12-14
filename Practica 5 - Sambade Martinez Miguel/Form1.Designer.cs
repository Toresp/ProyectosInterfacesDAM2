namespace Practica_5___Sambade_Martinez_Miguel
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bttalta = new System.Windows.Forms.Button();
            this.textApellido = new System.Windows.Forms.TextBox();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAltaLocal = new System.Windows.Forms.Button();
            this.textLocalidad = new System.Windows.Forms.TextBox();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbLocal = new System.Windows.Forms.ComboBox();
            this.viewTrabajadores = new System.Windows.Forms.ListView();
            this.treeTrabajadores = new System.Windows.Forms.TreeView();
            this.Imagenes = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bttalta);
            this.groupBox1.Controls.Add(this.textApellido);
            this.groupBox1.Controls.Add(this.textNombre);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(361, 117);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(406, 88);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nuevo empleado";
            // 
            // bttalta
            // 
            this.bttalta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttalta.Location = new System.Drawing.Point(321, 25);
            this.bttalta.Name = "bttalta";
            this.bttalta.Size = new System.Drawing.Size(79, 23);
            this.bttalta.TabIndex = 4;
            this.bttalta.Text = "Alta";
            this.bttalta.UseVisualStyleBackColor = true;
            this.bttalta.Click += new System.EventHandler(this.bttalta_Click);
            // 
            // textApellido
            // 
            this.textApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textApellido.Location = new System.Drawing.Point(80, 58);
            this.textApellido.Name = "textApellido";
            this.textApellido.Size = new System.Drawing.Size(220, 20);
            this.textApellido.TabIndex = 5;
            // 
            // textNombre
            // 
            this.textNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNombre.Location = new System.Drawing.Point(80, 27);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(220, 20);
            this.textNombre.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(358, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Localidad";
            // 
            // btnAltaLocal
            // 
            this.btnAltaLocal.Location = new System.Drawing.Point(554, 33);
            this.btnAltaLocal.Name = "btnAltaLocal";
            this.btnAltaLocal.Size = new System.Drawing.Size(213, 23);
            this.btnAltaLocal.TabIndex = 2;
            this.btnAltaLocal.Text = "Alta Localidad";
            this.btnAltaLocal.UseVisualStyleBackColor = true;
            this.btnAltaLocal.Click += new System.EventHandler(this.btnAltaLocal_Click);
            // 
            // textLocalidad
            // 
            this.textLocalidad.Location = new System.Drawing.Point(417, 35);
            this.textLocalidad.Name = "textLocalidad";
            this.textLocalidad.Size = new System.Drawing.Size(122, 20);
            this.textLocalidad.TabIndex = 3;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrar.Location = new System.Drawing.Point(651, 242);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(116, 23);
            this.btnMostrar.TabIndex = 5;
            this.btnMostrar.Text = "Trabajadores";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(371, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Localidades";
            // 
            // cmbLocal
            // 
            this.cmbLocal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLocal.FormattingEnabled = true;
            this.cmbLocal.Location = new System.Drawing.Point(455, 244);
            this.cmbLocal.Name = "cmbLocal";
            this.cmbLocal.Size = new System.Drawing.Size(171, 21);
            this.cmbLocal.TabIndex = 7;
            // 
            // viewTrabajadores
            // 
            this.viewTrabajadores.FullRowSelect = true;
            this.viewTrabajadores.HideSelection = false;
            this.viewTrabajadores.Location = new System.Drawing.Point(374, 286);
            this.viewTrabajadores.Name = "viewTrabajadores";
            this.viewTrabajadores.Size = new System.Drawing.Size(393, 207);
            this.viewTrabajadores.TabIndex = 8;
            this.viewTrabajadores.UseCompatibleStateImageBehavior = false;
            this.viewTrabajadores.View = System.Windows.Forms.View.Details;
            // 
            // treeTrabajadores
            // 
            this.treeTrabajadores.ImageIndex = 0;
            this.treeTrabajadores.ImageList = this.Imagenes;
            this.treeTrabajadores.Location = new System.Drawing.Point(28, 24);
            this.treeTrabajadores.Name = "treeTrabajadores";
            this.treeTrabajadores.SelectedImageIndex = 1;
            this.treeTrabajadores.Size = new System.Drawing.Size(324, 469);
            this.treeTrabajadores.TabIndex = 9;
            this.treeTrabajadores.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeTrabajadores_NodeMouseClick);
            // 
            // Imagenes
            // 
            this.Imagenes.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("Imagenes.ImageStream")));
            this.Imagenes.TransparentColor = System.Drawing.Color.Transparent;
            this.Imagenes.Images.SetKeyName(0, "closed.png");
            this.Imagenes.Images.SetKeyName(1, "open.png");
            this.Imagenes.Images.SetKeyName(2, "paper.png");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 505);
            this.Controls.Add(this.treeTrabajadores);
            this.Controls.Add(this.viewTrabajadores);
            this.Controls.Add(this.cmbLocal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.textLocalidad);
            this.Controls.Add(this.btnAltaLocal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bttalta;
        private System.Windows.Forms.TextBox textApellido;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAltaLocal;
        private System.Windows.Forms.TextBox textLocalidad;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbLocal;
        private System.Windows.Forms.ListView viewTrabajadores;
        private System.Windows.Forms.TreeView treeTrabajadores;
        private System.Windows.Forms.ImageList Imagenes;
    }
}

