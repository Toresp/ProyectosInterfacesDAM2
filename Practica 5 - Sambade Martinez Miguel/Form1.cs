using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_5___Sambade_Martinez_Miguel
{
    public partial class Form1 : Form
    {
        List<Localidad> Localidades = new List<Localidad>();
        public Form1()
        {
            InitializeComponent();
            treeTrabajadores.Nodes.Add("CUADRILLAS");
            viewTrabajadores.Columns.Add("Nombre", 117);
            viewTrabajadores.Columns.Add("Apellido", 122);
            viewTrabajadores.Columns.Add("Cargo", 149);

        }
        //Da de alta una localidad
        private void btnAltaLocal_Click(object sender, EventArgs e)
        {
            Boolean añadir = true;
            if (!textLocalidad.Text.Equals(""))
            {
                if (Localidades.Count == 0)
                {
                    Localidades.Add(new Localidad("LOCALIDAD " + textLocalidad.Text));
                    cmbLocal.Items.Add(new TextBox().Text = "LOCALIDAD " + textLocalidad.Text);
                    treeTrabajadores.Nodes[0].Nodes.Add("LOCALIDAD " + textLocalidad.Text);
                    textLocalidad.Text = "";
                }
                else
                {
                    for (int i = 0; i < Localidades.Count; i++)
                    {
                        //Comprueba que la localidad no exista para poder añadirla
                        if (("localidad "+ textLocalidad.Text.ToLower()).Equals(Localidades[i].ToString()))
                        {
                            MessageBox.Show("Localidad ya existente", "Aviso");
                            añadir = false;
                        }
                       
                    }
                    if (añadir)
                    {
                        Localidades.Add(new Localidad("LOCALIDAD " + textLocalidad.Text));
                        cmbLocal.Items.Add(new TextBox().Text = "LOCALIDAD " + textLocalidad.Text);
                        treeTrabajadores.Nodes[0].Nodes.Add("LOCALIDAD " + textLocalidad.Text);
                        textLocalidad.Text = "";
                    }
                }
            }
                else
                    MessageBox.Show("No puede estar el campo vacío", "Aviso");
        }

        //Da de alta un Trabajador
        private void bttalta_Click(object sender, EventArgs e)
        {
            Boolean añadir=true;
            
            if(!textNombre.Text.Equals("") && !textApellido.Text.Equals("")){
                //Comprueba que haya algun elemento seleccionado y que este no este en el nivel 0
                if (treeTrabajadores.SelectedNode == null || (treeTrabajadores.SelectedNode.Level <= 0 && treeTrabajadores.SelectedNode.Index >= 0))
                {
                    MessageBox.Show("Seleccione en la ventana de la izquierda donde se posiciona el empleado.", "Aviso");
                }
                else
                {
                    if (treeTrabajadores.SelectedNode.Level == 1 && Localidades[treeTrabajadores.SelectedNode.Index].Jefe == false)
                    {
                        //Indicamos que en esta Localidad no pueden haber mas jefes
                        Localidades[treeTrabajadores.SelectedNode.Index].Jefe = true;
                        //Accede a la localidad seleccionada y añade el trabajador 0 que sería el jefe
                        if (Localidades[treeTrabajadores.SelectedNode.Index].Trabajadores.Count>0)
                            for (int i = 0; i < Localidades[treeTrabajadores.SelectedNode.Index].Trabajadores.Count; i++)
                            {
                                if ((textNombre.Text.ToLower() + " " + textApellido.Text.ToLower()).Equals(Localidades[treeTrabajadores.SelectedNode.Index].Trabajadores[i].ToString()))
                                    añadir = false;
                            }
                        if (añadir)
                        {
                            Localidades[treeTrabajadores.SelectedNode.Index].Trabajadores.Add(new Trabajador(textNombre.Text, textApellido.Text, "Jefe"));
                            treeTrabajadores.Nodes[0].Nodes[treeTrabajadores.SelectedNode.Index].Nodes.Add("JEFE: " + textNombre.Text + " " + textApellido.Text);
                            textNombre.Text = "";
                            textApellido.Text = "";
                        }
                        else MessageBox.Show("Trabajador con este nombre ya existente.", "Aviso");
                    }
                    else
                    {
                        if (treeTrabajadores.SelectedNode.Level == 1 && Localidades[treeTrabajadores.SelectedNode.Index].Jefe == true)
                            MessageBox.Show("Solo se permite un jefe por localidad.", "Aviso");
                    }
                    if (treeTrabajadores.SelectedNode.Level == 2)
                    {
                        if (Localidades[treeTrabajadores.SelectedNode.Index].Trabajadores.Count > 0)
                            for (int i = 0; i < Localidades[treeTrabajadores.SelectedNode.Index].Trabajadores.Count; i++)
                            {
                                if ((textNombre.Text.ToLower() + " " + textApellido.Text.ToLower()).Equals(Localidades[treeTrabajadores.SelectedNode.Index].Trabajadores[i].ToString()))
                                    añadir = false;
                            }

                        if (añadir)
                        {
                            Localidades[treeTrabajadores.SelectedNode.Parent.Index].Trabajadores.Add(new Trabajador(textNombre.Text, textApellido.Text, "1ER OFICIAL"));
                            treeTrabajadores.Nodes[0].Nodes[treeTrabajadores.SelectedNode.Parent.Index].Nodes[treeTrabajadores.SelectedNode.Index].Nodes.Add("1ER OFICIAL: " +
                                textNombre.Text + " " + textApellido.Text);
                            textNombre.Text = "";
                            textApellido.Text = "";
                        }
                        else MessageBox.Show("Trabajador con este nombre ya existente.", "Aviso");
                    }
                    if (treeTrabajadores.SelectedNode.Level == 3)
                    {
                        if (Localidades[treeTrabajadores.SelectedNode.Index].Trabajadores.Count > 0)
                            for (int i = 0; i < Localidades[treeTrabajadores.SelectedNode.Index].Trabajadores.Count; i++)
                            {
                                if ((textNombre.Text.ToLower() + " " + textApellido.Text.ToLower()).Equals(Localidades[treeTrabajadores.SelectedNode.Index].Trabajadores[i].ToString()))
                                    añadir = false;
                            }
                        if (añadir)
                        {
                            Localidades[treeTrabajadores.SelectedNode.Parent.Parent.Index].Trabajadores.Add(new Trabajador(textNombre.Text, textApellido.Text, "2º OFICIAL"));
                            treeTrabajadores.Nodes[0].Nodes[treeTrabajadores.SelectedNode.Parent.Parent.Index].Nodes[treeTrabajadores.SelectedNode.Parent.Index]
                                .Nodes[treeTrabajadores.SelectedNode.Index].Nodes.Add("2º OFICIAL: " + textNombre.Text + " " + textApellido.Text);
                            textNombre.Text = "";
                            textApellido.Text = "";
                        }
                        else MessageBox.Show("Trabajador con este nombre ya existente.", "Aviso");
                    }
                }
            }
            else
            {
                MessageBox.Show("El campo nombre y el campo apellido no pueden estar vacíos.", "Aviso");
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if (cmbLocal.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccione una provincia", "Aviso");
            }
            else
            {
                viewTrabajadores.Items.Clear();
                for (int i = 0; i < Localidades[cmbLocal.SelectedIndex].Trabajadores.Count; i++)
                {
                    viewTrabajadores.Items.Add(new ListViewItem(Localidades[cmbLocal.SelectedIndex].Trabajadores[i].toString()));
                }
            }
        }

        private void treeTrabajadores_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            try
            {
                if(treeTrabajadores.SelectedNode.Level == 4)
                {
                    treeTrabajadores.SelectedNode.ImageIndex = 2;
                    treeTrabajadores.SelectedNode.SelectedImageIndex = 2;
                }
            }catch (Exception Ex)
            {

            }
        }
    }

    public class Trabajador
    {
        public string nombre;
        public string apellido;
        public string cargo;

        public Trabajador(string n, string ap, string c)
        {
            nombre = n;
            apellido = ap;
            cargo = c;
        }

        //Devuelve un array que contiene las tres propiedades de trabajador
        public string[] toString()
        {
            string[] dev = new string[] { nombre, apellido, cargo };
            return dev;
        }

        public override string ToString()
        {
            return nombre.ToLower()+" "+apellido.ToLower();
        }
    }
    public class Localidad
    {
        public string localidad;
        public Boolean Jefe = false;
        public List<Trabajador> Trabajadores = new List<Trabajador>();

        public Localidad(string l)
        {
            localidad = l;
        }


        public override string ToString()
        {
            return localidad.ToLower();
        }

    }

}
