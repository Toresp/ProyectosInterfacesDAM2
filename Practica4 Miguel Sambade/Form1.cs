using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica4_Miguel_Sambade
{
    public partial class Form1 : Form
    {
        List<Trabajador> Trabajadores = new List<Trabajador>();

        public Form1()
        {
            InitializeComponent();
            Disponible.Columns.Add("Nome e Apelido", 195);
            Disponible.Columns.Add("Provincia", 122);
            Disponible.Columns.Add("Profesión", 195);

        }
        private void reset()
        {
            dniBox.Text = "";
            nomBox.Text = "";
            apel1Box.Text = "";
            apel2Box.Text = "";

        }

        private void refrescar()
        {
            Trabajador T;
            T = Trabajadores.Last();
            Disponible.Items.Add(new ListViewItem(T.datos()));
        }


        private void Add_Click(object sender, EventArgs e)
        {
            if(!dniBox.Text.Equals("") && !nomBox.Text.Equals("") && !apel1Box.Text.Equals("") && !apel2Box.Text.Equals("")
                && provList.SelectedIndex>=0 && profList.SelectedIndex>=0)
            {
                Trabajadores.Add(new Trabajador(dniBox.Text, nomBox.Text, apel1Box.Text, apel2Box.Text,
                    ((string)provList.SelectedItem), ((string)profList.SelectedItem)));
                reset();
                refrescar();
            }else MessageBox.Show("No puede haber campos vacíos", "Aviso");
        }
        private void Delete_Click(object sender, EventArgs e)
        {
            if (Disponible.SelectedItems.Count!=0)
            {
                DialogResult Result = MessageBox.Show("¿Seguro que desea Eliminar?", "Confirmar", MessageBoxButtons.YesNo);
                if (Result == DialogResult.Yes)
                {
                    Trabajadores.RemoveAt(Disponible.SelectedIndices[0]);
                    Disponible.Items.RemoveAt(Disponible.SelectedIndices[0]);
                }
            }
            else MessageBox.Show("Seleccione el elemento a eliminar", "Aviso");
        }

        private void engadirProv_Click(object sender, EventArgs e)
        {
            if (!provinBox.Text.Equals(""))
            {
                provList.Items.Add(new TextBox().Text = provinBox.Text);
                provinBox.Text = "";
            }
            else MessageBox.Show("No hay texto que añadir", "Aviso");
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            if (provList.SelectedIndex >= 0)
            {
                DialogResult Result = MessageBox.Show("¿Seguro que desea Eliminar?", "Confirmar", MessageBoxButtons.YesNo);
                if (Result == DialogResult.Yes)
                {
                    provList.Items.RemoveAt(provList.SelectedIndex);
                }
            }
            else MessageBox.Show("Seleccione el elemento a eliminar", "Aviso");

        }

        private void eliminarProf_Click(object sender, EventArgs e)
        {
            if (profList.SelectedIndex >= 0)
            {
                DialogResult Result = MessageBox.Show("¿Seguro que desea Eliminar?", "Confirmar", MessageBoxButtons.YesNo);
                if (Result == DialogResult.Yes)
                {
                    profList.Items.RemoveAt(profList.SelectedIndex);
                }
            }else MessageBox.Show("Seleccione el elemento a eliminar", "Aviso");

        }

        private void engadirProf_Click(object sender, EventArgs e)
        {
            if (!profBox.Text.Equals(""))
            {
                profList.Items.Add(new TextBox().Text = profBox.Text);
                profBox.Text = "";
            }
            else MessageBox.Show("No hay texto que añadir", "Aviso");
        }

        private void Disponible_DoubleClick(object sender, EventArgs e)
        {
            Details.Clear();
            Details.Text = Trabajadores[Disponible.SelectedIndices[0]].ToString();

        }
    }

    public class Trabajador
    {
        public string dni;
        public string nombre;
        public string apell1;
        public string apell2;
        public string provincia;
        public string profesion;

        public Trabajador(string d, string n, string a1, string a2,string prov, string prof)
        {
            dni = d;
            nombre = n;
            apell1 = a1;
            apell2 = a2;
            provincia = prov;
            profesion = prof;
        }

        public string[] datos()
        {
            string[] devolver = new string[3];
            devolver[0] = nombre +" "+apell1+ " "+ apell2;
            devolver[1] = provincia;
            devolver[2] = profesion;
            return devolver;
        }

        public override string ToString()
        {
            return "DATOS DO TRABALLADOR" +
                "\r\nDNI: "+ dni
                + "\r\nNOME " + nombre
                + "\r\nAPELIDO 1: " + apell1
                + "\r\nAPELIDO 2: " + apell2
                + "\r\nPROVINCIA: " + provincia
                + "\r\nPROFESION: " + profesion;
        }
    }
}
