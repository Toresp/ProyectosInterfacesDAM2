using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_6___Sambade_Martínez_Miguel
{
    public partial class Form1 : Form
    {
        int contA = 0;
        int contB = 0;
        int contC = 0;
        List<Form2> Ventanas = new List<Form2>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            contA++;
            Form2 F = new Form2("A");
            F.Text = "A-" + contA;
            F.Show();
            Ventanas.Add(F);
            listVentanas.Items.Add(new TextBox().Text = "Ventana " + F.Text);
            label1.Text = textoConteo();

        }
        private string textoConteo()
        {
            return "Numero de hijos actuales: " + Ventanas.Count;
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            contB++;
            Form2 F = new Form2("B");
            F.Text = "B-" + contA;
            F.Show();
            Ventanas.Add(F);
            listVentanas.Items.Add(new TextBox().Text = "Ventana " + F.Text);
            label1.Text = textoConteo();
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            contC++;
            Form2 F = new Form2("C");
            F.Text = "C-" + contA;
            F.Show();
            Ventanas.Add(F);
            listVentanas.Items.Add(new TextBox().Text = "Ventana " + F.Text);
            label1.Text = textoConteo();
        }

        private void Mostrar_Click(object sender, EventArgs e)
        {

            if (!rtn1A.Checked && !rtn1B.Checked && !rtn1C.Checked && !rtnTodas.Checked)
            {
                MessageBox.Show("Seleccione un tipo de Ventana.", "Aviso");
            } else {
                if (Ventanas.Count==0)
                {
                    MessageBox.Show("No hay Ventas Existentes.", "Aviso");
                }else
                {
                    if (rtn1A.Checked)
                    {
                        if (contA!=0)
                            for (int i = 0; i < Ventanas.Count; i++)
                            {
                                if (Ventanas[i].Tipo.Equals("A"))
                                {
                                    Ventanas[i].Show();
                                    listVentanas.Items[i] = "Ventana " + Ventanas[i].Tipo;
                                }
                            }
                        else MessageBox.Show("No hay Ventanas de Tipo A.", "Aviso");
                    }
                    if (rtn1B.Checked)
                    {
                        if (contB != 0)
                            for (int i = 0; i < Ventanas.Count; i++)
                            {
                                if (Ventanas[i].Tipo.Equals("B"))
                                {
                                    Ventanas[i].Show();
                                    listVentanas.Items[i] = "Ventana " + Ventanas[i].Tipo;
                                }
                            }
                        else MessageBox.Show("No hay Ventanas de Tipo B.", "Aviso");
                    }
                    if (rtn1C.Checked)
                    {
                        if (contC != 0)
                            for (int i = 0; i < Ventanas.Count; i++)
                            {
                                if (Ventanas[i].Tipo.Equals("C"))
                                {
                                    Ventanas[i].Show();
                                    listVentanas.Items[i] = "Ventana " + Ventanas[i].Tipo;
                                }
                            }
                        else MessageBox.Show("No hay Ventanas de Tipo C.", "Aviso");
                    }
                    if (rtnTodas.Checked)
                    {
                        for (int i = 0; i < Ventanas.Count; i++)
                        {
                            Ventanas[i].Show();
                            listVentanas.Items[i] = "Ventana " + Ventanas[i].Tipo;
                        }
                    }
                }
            }
        }

        private void Ocultar_Click(object sender, EventArgs e)
        {

            if (!rtn2A.Checked && !rtn2B.Checked && !rtn2C.Checked && !rtnTodas2.Checked)
            {
                MessageBox.Show("Seleccione un tipo de Ventana.", "Aviso");
            }
            else
            {
                if (Ventanas.Count == 0)
                {
                    MessageBox.Show("No hay Ventanas Existentes.", "Aviso");
                }
                else
                {
                    if (rtn2A.Checked)
                    {
                        if (contA != 0)
                            for (int i = 0; i < Ventanas.Count; i++)
                            {
                                if (Ventanas[i].Tipo.Equals("A"))
                                {
                                    Ventanas[i].Hide();
                                    listVentanas.Items[i] = "Ventana " + Ventanas[i].Tipo + " (oculta)";
                                }
                            }
                        else MessageBox.Show("No hay Ventanas de Tipo A.", "Aviso");
                    }
                    if (rtn2B.Checked)
                    {
                        if (contB != 0)
                            for (int i = 0; i < Ventanas.Count; i++)
                            {
                                if (Ventanas[i].Tipo.Equals("B"))
                                {
                                    Ventanas[i].Hide();
                                    listVentanas.Items[i] = "Ventana " + Ventanas[i].Tipo + " (oculta)";
                                }
                            }
                        else MessageBox.Show("No hay Ventanas de Tipo B.", "Aviso");
                    }
                    if (rtn2C.Checked)
                    {
                        if (contC != 0)
                            for (int i = 0; i < Ventanas.Count; i++)
                            {
                                if (Ventanas[i].Tipo.Equals("C"))
                                {
                                    Ventanas[i].Hide();
                                    listVentanas.Items[i] = "Ventana " + Ventanas[i].Tipo + " (oculta)";

                                }
                            }
                        else MessageBox.Show("No hay Ventanas de Tipo C.", "Aviso");
                    }
                    if (rtnTodas2.Checked)
                    {
                        for (int i = 0; i < Ventanas.Count; i++)
                        {
                            Ventanas[i].Hide();
                            listVentanas.Items[i] = "Ventana " + Ventanas[i].Tipo + " (oculta)";

                        }
                    }
                }
            }

        }

        private void listMostrar_Click(object sender, EventArgs e)
        {
            if(listVentanas.SelectedIndex < 0)
                MessageBox.Show("Seleccione una ventana.", "Aviso");
            else
            {
                Ventanas[listVentanas.SelectedIndex].Show();
                listVentanas.Items[listVentanas.SelectedIndex] = "Ventana " +  Ventanas[listVentanas.SelectedIndex].Tipo;
                label1.Text = textoConteo();
            }
            
        }

        private void listOcultar_Click(object sender, EventArgs e)
        {
            if (listVentanas.SelectedIndex < 0)
                MessageBox.Show("Seleccione una ventana.", "Aviso");
            else
            {
                Ventanas[listVentanas.SelectedIndex].Hide();
                listVentanas.Items[listVentanas.SelectedIndex] = "Ventana " + Ventanas[listVentanas.SelectedIndex].Tipo + " (oculta)";
                label1.Text = textoConteo();
            }
        }

        private void listCerrar_Click(object sender, EventArgs e)
        {
            if (listVentanas.SelectedIndex < 0)
                MessageBox.Show("Seleccione una ventana.", "Aviso");
            else
            {
                Ventanas[listVentanas.SelectedIndex].Dispose();
                Ventanas.RemoveAt(listVentanas.SelectedIndex);
                listVentanas.Items.RemoveAt(listVentanas.SelectedIndex);
                label1.Text = textoConteo();
            }
        }
    }
}
