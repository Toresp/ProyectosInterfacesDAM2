using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica2_Ejercicio2
{
    public partial class Form1 : Form
    {
        List<string> coruña = new List<string>();
        List<string> ourense = new List<string>();
        List<string> lugo = new List<string>();
        List<string> pontevedra = new List<string>();

        public Form1()
        {
            InitializeComponent();
            Provincia.Items.Add(new TextBox().Text = "A CORUÑA");
            coruña.Add("Padrón");
            coruña.Add("Camariñas");
            Provincia.Items.Add(new TextBox().Text = "OURENSE");
            ourense.Add("Laza");
            ourense.Add("Allariz");
            Provincia.Items.Add(new TextBox().Text = "LUGO");
            lugo.Add("Samos");
            lugo.Add("Meira");
            Provincia.Items.Add(new TextBox().Text = "PONTEVEDRA");
            pontevedra.Add("Tui");
            pontevedra.Add("A Cañiza");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Provincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Provincia.Text.Equals("A CORUÑA"))
            {
                Localidad.Items.Clear();
                for (int i = 0; i < coruña.Count; i++)
                {
                    Localidad.Items.Add(new TextBox().Text = coruña[i]);

                }
            }
            if (Provincia.Text.Equals("OURENSE"))
            {
                Localidad.Items.Clear();
                for (int i = 0; i < ourense.Count; i++)
                {
                    Localidad.Items.Add(new TextBox().Text = ourense[i]);

                }
            }
            if (Provincia.Text.Equals("LUGO"))
            {
                Localidad.Items.Clear();
                for (int i = 0; i < lugo.Count; i++)
                {
                    Localidad.Items.Add(new TextBox().Text = lugo[i]);

                }
            }
            if (Provincia.Text.Equals("PONTEVEDRA"))
            {
                Localidad.Items.Clear();
                for (int i = 0; i < pontevedra.Count; i++)
                {
                    Localidad.Items.Add(new TextBox().Text = pontevedra[i]);
                }
            }


        }

        private void Exe_Click(object sender, EventArgs e)
        {
            if (Delete.Checked)
            {

                if (Localidad.SelectedIndex < 0)
                    MessageBox.Show("Seleccione una localidad", "Aviso");
                else
                {
                    DialogResult Result = MessageBox.Show("¿Seguro que desea Eliminar?", "Confirmar", MessageBoxButtons.YesNo);
                    int i;
                    i = Localidad.SelectedIndex;
                    Localidad.Items.RemoveAt(i);
                    if (Provincia.Text.Equals("A CORUÑA"))
                        coruña.RemoveAt(i);
                    if (Provincia.Text.Equals("OURENSE"))
                        ourense.RemoveAt(i);
                    if (Provincia.Text.Equals("LUGO"))
                        lugo.RemoveAt(i);
                    if (Provincia.Text.Equals("PONTEVEDRA"))
                        pontevedra.RemoveAt(i);
                }
            }
            if (New.Checked)
            {
                if (Localtxt.Text.Equals(""))
                    MessageBox.Show("Texto no introducido!", "Aviso");
                else
                {
                    if (Provincia.SelectedIndex < 0)
                        MessageBox.Show("Provincia no introducida!", "Aviso");

                    else
                    {
                        Localidad.Items.Add(new TextBox().Text = Localtxt.Text);
                        if (Provincia.Text.Equals("A CORUÑA"))
                            coruña.Add(Localtxt.Text);
                        if (Provincia.Text.Equals("OURENSE"))
                            ourense.Add(Localtxt.Text);
                        if (Provincia.Text.Equals("LUGO"))
                            lugo.Add(Localtxt.Text);
                        if (Provincia.Text.Equals("PONTEVEDRA"))
                            pontevedra.Add(Localtxt.Text);
                        Localtxt.Text = "";
                    }

                }

            }
        

        }
    }
}
