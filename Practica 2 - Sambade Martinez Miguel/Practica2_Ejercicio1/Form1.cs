using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica2_Ejercicio1
{
    public partial class Form1 : Form
    {
        Boolean guardar=false;
        Alfombra A = new Alfombra();

        public Form1()
        {
            InitializeComponent();
        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            if (Cor.Text.Equals("") || Model.Text.Equals("") || Alto.Text.Equals("") || Ancho.Equals(""))
            {
                errorProvider1.SetError(Savebtn, "Este campo no puede estar vacío");
                guardar = false;

            }
            else  errorProvider1.SetError(Savebtn, ""); guardar = true; 

            if (guardar)
            {
                if (A.añadir(Model.Text, Cor.Text, Ancho.Text, Alto.Text))
                {
                    comboBox1.Items.Add(new TextBox().Text = "MODELO: " + Model.Text + " " + "COR: " + Cor.Text);
                    clear();
                }else MessageBox.Show("Error al guardar datos introducidos erroneos");
            }
        }
        
        private void clear()
        {
            Model.Text = "";
            Cor.Text = "";
            Ancho.Text = "";
            Alto.Text = "";
        }

        private void Delete_click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex < 0)
                MessageBox.Show("Seleccione la alfombra a Eliminar", "Aviso");
            else
            {
                DialogResult Result = MessageBox.Show("¿Seguro que desea Eliminar?", "Confirmar", MessageBoxButtons.YesNo);
                int i;
                if (Result == DialogResult.Yes)
                {
                    i = comboBox1.SelectedIndex;
                    comboBox1.Items.RemoveAt(i);
                    A.Alfombras.RemoveAt(i);
                }
            }
        }

        private void DeleteAll_Click(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("¿Seguro que desea Eliminar ¡TODO!?", "Confirmar", MessageBoxButtons.YesNo);
            if(Result == DialogResult.Yes)
            {
                comboBox1.Items.Clear();
                A.Alfombras.Clear();
            }
        }


        private void Info_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex < 0)
                MessageBox.Show("Seleccione la alfombra a Eliminar", "Aviso");
            else
            {
                int i;
                i = comboBox1.SelectedIndex;
                MessageBox.Show("MODELO: " + A.Alfombras[i].modelo + "\nCOR: "+ A.Alfombras[i].cor + "\nANCHO: "+ A.Alfombras[i].ancho.ToString()+"\nALTO: " 
                    + A.Alfombras[i].alto.ToString()  , "Mensaje");
            }
        }
    }
    public class Alfombra
    {
        public List<Tipo_Alfombra> Alfombras = new List<Tipo_Alfombra>();
        
        public struct Tipo_Alfombra
        {
            public string modelo;
            public string cor;
            public float ancho;
            public float alto;
        }
        public Boolean añadir(string model, string cor, String an, String alt)
        {
            Tipo_Alfombra Al = new Tipo_Alfombra();
            Al.modelo = model;
            Al.cor = cor;
            try
            {
                Al.ancho = float.Parse(an);
                Al.alto = float.Parse(alt);
                Alfombras.Add(Al);
                return true;

            }catch(Exception Ex)
            {
                return false;
            }
        }
       
    }
}
