using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Práctica_3_Miguel_Sambade
{
    public partial class Form1 : Form
    {
        private List<persona> Personas = new List<persona>();
        BindingSource PersonasBinded;

        public Form1()
        {
            InitializeComponent();
            PersonasBinded = new BindingSource();
            PersonasBinded.DataSource = Personas;
            listBox1.DataSource = PersonasBinded;
            Foto.ImageLocation = ".\\Data\\persona.png";
            Foto.Image = Image.FromFile(Foto.ImageLocation);
            PersonasBinded.ResetBindings(false);
        }
        //Establece todo visible para poder escribir y resetea valores.
        private void New_Click(object sender, EventArgs e)
        {
            Nombretxt.Text = "";
            Telefonotxt.Text = "";
            Emailtxt.Text = "";
            Foto.ImageLocation = ".\\Data\\persona.png";
            Delete.Enabled = false;
            Modify.Enabled = false;
            New.Visible = false;
            Add.Visible = true;
            Add.Enabled = true;
            Nombretxt.Enabled = true;
            Telefonotxt.Enabled = true;
            Emailtxt.Enabled = true;
            Foto.Enabled = true;

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Nombretxt.Text = Personas[listBox1.SelectedIndex].Nombre;
            Telefonotxt.Text = Personas[listBox1.SelectedIndex].telefono; ;
            Emailtxt.Text = Personas[listBox1.SelectedIndex].Email.ToString();
            Foto.ImageLocation = Personas[listBox1.SelectedIndex].Foto;
        }


        private void Add_Click(object sender, EventArgs e)
        {
            if(!Nombretxt.Text.Length.Equals("") || !Emailtxt.Text.Length.Equals("") || !Telefonotxt.Text.Length.Equals(""))
            { 
                if (persona.validate_Email(Emailtxt.Text))
                {
                    if (!Comprobar(Nombretxt.Text))
                    {//Realiza comprobaciones para que se cumplan todas las condiciones necesarias al añadir
                        Delete.Enabled = true;
                        Modify.Enabled = true;
                        New.Visible = true;
                        Add.Visible = false;
                        Add.Enabled = false;
                        Nombretxt.Enabled = false;
                        Telefonotxt.Enabled = false;
                        Emailtxt.Enabled = false;
                        Foto.Enabled = false;
                        //Oculta y evita poder interactuar con los elementos una vez añadido el dato
                        Personas.Add(new persona(Nombretxt.Text, Telefonotxt.Text, Emailtxt.Text, Foto.ImageLocation));
                        PersonasBinded.ResetBindings(false);
                    }
                    else MessageBox.Show("La persona que intenta Introducir ya existe", "Aviso");
                }else MessageBox.Show("Email no válido", "Aviso");
            }
        }


        private Boolean Comprobar(string nom)
        {
            persona P = new persona(nom);
            if (Personas != null)
            {
                for (int i = 0; i < Personas.Count; i++)
                {
                    if (Personas[i].Equals(P))
                        return true;
                }
            }

            return false;
        }

        private void Telefonotxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void Foto_Click(object sender, EventArgs e)
        {
            OpenFileDialog D = new OpenFileDialog();
            D.Title = "Elige una foto de Perfil";
            D.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (D.ShowDialog() == DialogResult.OK)
            {
                Foto.Image= new Bitmap(D.FileName);
                Foto.ImageLocation = D.FileName;
            }

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("¿Seguro que desea Eliminar?", "Confirmar", MessageBoxButtons.YesNo);
            if (Result == DialogResult.Yes)
            {
                Personas.RemoveAt(listBox1.SelectedIndex);
                PersonasBinded.ResetBindings(false);
            }
            if (Personas.Count == 0)
            {
                Modify.Enabled = false;
                Delete.Enabled = false;
            }
        }

        private void Modify_Click(object sender, EventArgs e)
        {
            Nombretxt.Text = Personas[listBox1.SelectedIndex].Nombre;
            Telefonotxt.Text = Personas[listBox1.SelectedIndex].telefono;;
            Emailtxt.Text = Personas[listBox1.SelectedIndex].Email.ToString();
            Foto.ImageLocation = Personas[listBox1.SelectedIndex].Foto;
            Delete.Enabled = false;
            Modify.Enabled = false;
            New.Visible = false;
            Add.Visible = true;
            Add.Enabled = true;
            Nombretxt.Enabled = true;
            Telefonotxt.Enabled = true;
            Emailtxt.Enabled = true;
            Foto.Enabled = true;
            Personas.RemoveAt(listBox1.SelectedIndex);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

    public class persona
    {
        public string Nombre;
        public string telefono;
        public MailAddress Email;
        public string Foto;

        public persona(string nom, string tel, string mail, string f)
        {
            Nombre = nom;
            telefono = tel;
            Email = new MailAddress(mail);
            Foto = f;
        }

        public persona(string nom)
        {
            Nombre = nom;
        }

        public static Boolean validate_Email(string txt)
        {
            try
            {
                MailAddress E = new MailAddress(txt);
                return true;
            }catch (Exception Ex)
            {
                return false;

            }
        }

        public override string ToString()
        {
            return Nombre;
        }

        public override bool Equals(object obj)
        {
            return obj is persona persona &&
                   Nombre == persona.Nombre &&
                   EqualityComparer<MailAddress>.Default.Equals(Email, persona.Email);
        }
    }
}
