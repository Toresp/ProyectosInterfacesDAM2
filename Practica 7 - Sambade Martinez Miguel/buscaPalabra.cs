using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_7___Sambade_Martinez_Miguel
{
    public partial class buscaPalabra : Form
    {
        List <string> archivo = new List<string>();
        OpenFileDialog D = new OpenFileDialog();
        public buscaPalabra()
        {
            InitializeComponent();
        }

        private void search_Click(object sender, EventArgs e)
        {
            int inicio=0;
            if (!txtPalabra.Text.Equals(""))
            {
                string palabra = txtPalabra.Text;


                if (richTextBox.Text.Contains(palabra)) //Busca la palabra y la resalta.
                {
                    Boolean Found = true;
                    do
                    {
                        inicio = richTextBox.Text.IndexOf(palabra,inicio);
                        if (inicio != -1)
                        {
                            richTextBox.SelectionStart = inicio;
                            richTextBox.SelectionLength = palabra.Length;
                            richTextBox.SelectionBackColor = Color.Yellow;
                            inicio += palabra.Length;
                        }
                        else
                            Found = false;
                    }while(Found);
                    contiene(palabra);
                    

                }
            }
            else MessageBox.Show("Introduzca la palabra a buscar", "Aviso");

        }
        private void contiene(String palabra)//Añade las que lo contengan al listBox.
        {
            for (int i = 0; i < archivo.Count; i++)
            {
                if (archivo[i].Contains(palabra))
                    lbText.Items.Add(new TextBox().Text = archivo[i]);
            }
        }

        private void abrirArchivo_Click(object sender, EventArgs e)
        {
            
            D.Title = "Elige un texto";
            D.Filter = "txt files (*.txt) | *.txt";
            if (D.ShowDialog() == DialogResult.OK)
            {
                string[] lineas = File.ReadAllLines(D.FileName);
                foreach (string linea in lineas)
                {
                    archivo.Add(linea);
                }
                ActualizarArchivo();
            }
        }
        private void ActualizarArchivo()
        {
            richTextBox.Clear();
            richTextBox.Text = File.ReadAllText(D.FileName);
        }

        private void borrarLineaEnArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lbText.SelectedIndex>=0)
            {
                string textoSeleccionado = lbText.SelectedItem.ToString();//guarda el texto seleccionado.
                for (int i = 0; i < archivo.Count; i++)
                {
                    if (archivo[i].Contains(textoSeleccionado))
                        archivo.RemoveAt(i);
                }
                lbText.Items.RemoveAt(lbText.SelectedIndex);
                richTextBox.Text.Remove(richTextBox.Text.IndexOf(textoSeleccionado), textoSeleccionado.Length);
                File.WriteAllText(D.FileName,richTextBox.Text);
                ActualizarArchivo();
                
            }else MessageBox.Show("Seleccione el texto a borrar", "Aviso");
        }

        private void crearNuevoArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lbText.SelectedIndex >= 0)
            {
                try
                {
                    StreamWriter sw = new StreamWriter(D.InitialDirectory + "lineas" + D.SafeFileName, true);
                    string textoSeleccionado = lbText.Items[lbText.SelectedIndex].ToString();//guarda el texto seleccionado.
                    sw.WriteLine(textoSeleccionado);
                    sw.Close();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message, "Aviso");
                }


            }
            else MessageBox.Show("Seleccione el texto a añadir", "Aviso");
        }

        private void buscaPalabra_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
    }
}
