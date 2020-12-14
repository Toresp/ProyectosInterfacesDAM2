using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica1_Sambade_Martinez__Miguel
{
    public partial class Form1 : Form
    {

        Persona P = new Persona();


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Save_button_Click(object sender, EventArgs e)
        {
            Search_box.Text = "";
            string sexo="", permiso="", titul="";
            if (Dni_box.Text.Length == 0 || nombre_box.Text.Length == 0 || apell1_box.Text.Length == 0 || apel2_box.Text.Length == 0 ||
                (!checkBox1.Checked && !checkBox2.Checked && !checkBox3.Checked && !checkBox4.Checked && !checkBox5.Checked)) {
                if (Otra.Checked && Otra_box.Text.Equals(""))
                    errorProvider1.SetError(Search_button, "Uno o mas campos vacíos");
                else errorProvider1.SetError(Search_button, "Uno o mas campos vacíos");
            }
                
                
            else
            {
                if (Hombre.Checked) sexo = Hombre.Text;
                else sexo = Mujer.Text;
                if (checkBox1.Checked) permiso = permiso + checkBox1.Text;
                if (checkBox2.Checked) permiso = permiso + checkBox2.Text;
                if (checkBox3.Checked) permiso = permiso + checkBox3.Text;
                if (checkBox4.Checked) permiso = permiso + checkBox4.Text;
                if (checkBox5.Checked) permiso = permiso + checkBox5.Text;
                if (Ninguna.Checked) titul = Ninguna.Text;
                if (ESO.Checked) titul = ESO.Text;
                if (Bach.Checked) titul = Bach.Text;
                if (FP.Checked) titul = FP.Text;
                if (Uni.Checked) titul = Uni.Text;


                errorProvider1.SetError(Search_button, "");

                if (P.Save(Dni_box.Text, nombre_box.Text, apell1_box.Text, apel2_box.Text, sexo, permiso, titul))
                    reset();
                else errorProvider1.SetError(Search_button, "Dni ya existente");
            }

        }
        private void reset()
        {
            Dni_box.Text = "";
            nombre_box.Text = "";
            apell1_box.Text = "";
            apel2_box.Text = "";
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            Hombre.Checked = true;
            Mujer.Checked = false;
            Ninguna.Checked = true;
            ESO.Checked = false;
            Bach.Checked = false;
            FP.Checked = false;
            Uni.Checked = false;
            Otra_box.Text = "";
            errorProvider1.SetError(Search_button, "");
        }

        private void Search_button_Click(object sender, EventArgs e)
        {
            errorProvider1.SetError(Search_button, "");

            if (Search_box.Text.Equals(""))
                errorProvider1.SetError(Search_button, "No hay texto");
            else
            {
                reset();
                int pos = P.Search(Search_box.Text);
                string txt;
                if (pos!=-1)
                {
                    Dni_box.Text = P.Personas[pos].Dni;
                    nombre_box.Text = P.Personas[pos].nombre;
                    apell1_box.Text = P.Personas[pos].apel1;
                    apel2_box.Text = P.Personas[pos].apel2;
                    if (P.Personas[pos].sexo.Equals("Hombre"))
                        Hombre.Checked = true;
                    else Mujer.Checked = true;
                    if (P.Personas[pos].permiso.Contains("A"))
                        checkBox1.Checked = true;
                    if (P.Personas[pos].permiso.Contains("B"))
                        checkBox2.Checked = true;
                    if (P.Personas[pos].permiso.Contains("C"))
                        checkBox3.Checked = true;
                    if (P.Personas[pos].permiso.Contains("D"))
                        checkBox4.Checked = true;
                    if (P.Personas[pos].permiso.Contains("E"))
                        checkBox5.Checked = true;
                    txt = P.Personas[pos].max_titul;
                    switch (txt)
                    {
                        case "Ninguna": Ninguna.Checked = true; break;
                        case "ESO": ESO.Checked = true; break;
                        case "Bach": Bach.Checked = true; break;
                        case "FP": FP.Checked = true;  break;
                        case "Uni":Uni.Checked = true; break;
                        default: Otra.Checked = true; Otra_box.Text = txt; break;
                    }
                }
                else errorProvider1.SetError(Search_button, "El Dni buscado no existe");
            }
        }
       
        
        private void Otra_MouseClick(object sender, MouseEventArgs e)
        {
            Otra_box.Enabled = true;
        }

        private void Otra_CheckedChanged(object sender, EventArgs e)
        {
            Otra_box.Enabled = false;
            Otra_box.Text = "";
        }
    }
    public class Persona
    {
        private int añadidos = 0;
        public struct tipo_persona
        {
            public string Dni;
            public string nombre;
            public string apel1;
            public string apel2;
            public string sexo;
            public string permiso;
            public string max_titul;
        }
        
        public tipo_persona[] Personas = new tipo_persona[10];
        //Guarda todos los datos en el Array
        public Boolean Save(string dni, string nom, string ap1, string ap2, string sx, string perm, string titul)
        {
            if (añadidos==0) LlenarArray();
            for (int i = añadidos; i < Personas.Length; i++)
            {
                if (!SearchExist(dni))
                {
                    Personas[i].Dni = dni;
                    Personas[i].nombre = nom;
                    Personas[i].apel1 = ap1;
                    Personas[i].apel2 = ap2;
                    Personas[i].sexo = sx;
                    Personas[i].permiso = perm;
                    Personas[i].max_titul = titul;
                    añadidos++;
                    return true;
                }
               return false;
                    
               
            }

            return false;
        }
        public int Search(string dni)
        {
            if (dni.Equals("") || dni.Equals(null)) return -1;
            for (int i = 0; i < Personas.Length; i++)
            {
                if (Personas[i].Dni.Equals(dni)) return i;
            }
            return -1;
        }

        public Boolean SearchExist(string dni)
        {
            if (dni.Equals(null) || dni.Equals("")) return false;
            for (int i = 0; i < Personas.Length; i++)
            {
                if (Personas[i].Dni.Equals(dni)) return true;
            }
            return false;
        }
        public void LlenarArray()
        {
            for (int i = 0; i < Personas.Length; i++)
            {
                Personas[i].Dni = "";
            }
        }
       
    }
}
