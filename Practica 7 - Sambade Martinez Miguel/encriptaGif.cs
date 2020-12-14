using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_7___Sambade_Martinez_Miguel
{
    public partial class encriptaGif : Form
    {
        OpenFileDialog D = new OpenFileDialog();
        List<string> Rutas = new List<string>();


        public encriptaGif()
        {
            InitializeComponent();
        }

        private void btnEncriptar_Click(object sender, EventArgs e)
        {

            D.Title = "Elige un gif";
            D.Filter = "gif files (*.gif) | *.gif";
            if (D.ShowDialog() == DialogResult.OK)
            {

                if (!Existe(D.FileName))
                    encriptarODesencriptarArchivo(D, true);
                else
                {
                    Boolean encriptado = true;
                    int indice=-1;
                    for (int i = 0; i < lbMostrar.Items.Count; i++)
                    {
                        if (lbMostrar.Items[i].Equals(D.SafeFileName))
                        {
                            encriptado = false;
                            indice = i;
                        }
                    }
                    if (!encriptado)
                    {
                        encriptarODesencriptarArchivo(D, false);
                        lbMostrar.Items.RemoveAt(indice);
                        barraProgreso.PerformStep();
                        lbMostrar.Items.Add(new TextBox().Text = D.SafeFileName + " (Encriptado)");
                        Rutas.RemoveAt(indice);
                        Rutas.Add(D.FileName);
                        barraProgreso.PerformStep();
                    }
                    else MessageBox.Show("El archivo ya se encuentra Encriptado", "Aviso");
                }



            }
        }
        private Boolean Existe(string ruta)
        {
            for (int i = 0; i < Rutas.Count; i++)
            {
                if (ruta.Equals(Rutas[i]))
                    return true;
            }
            return false;
        }

        private void btnEncriptarCarpeta_Click(object sender, EventArgs e)
        {

            FolderBrowserDialog fdb = new FolderBrowserDialog();

            if (fdb.ShowDialog() == DialogResult.OK && !string.IsNullOrWhiteSpace(fdb.SelectedPath))
            {
                string[] files = Directory.GetFiles(fdb.SelectedPath);
                for (int i = 0; i < files.Length; i++)
                {
                    if (files[i].Substring(files[i].Length - 3).Equals("gif"))
                    {
                        if (!Existe(files[i])) {
                            Thread.Sleep(200);
                            D.FileName = files[i];
                            encriptarODesencriptarArchivo(D, true);
                        }
                    }
                }
            }
        }

        /*Se le pasa un OpenFileDialog que será el archivo a encriptar o desencriptar, luego un Boolean, 
        si es true, encripta, si es false desencripta.*/
        private void encriptarODesencriptarArchivo(OpenFileDialog D, Boolean Tipo)
        {
            Byte[] FIG;
            Byte f;
            Byte g;
            barraProgreso.Value = 0;
            label2.Hide();
            FIG = File.ReadAllBytes(D.FileName);
            g = FIG[0];
            f = FIG[2];
            FIG[0] = f;
            FIG[2] = g;
            try
            {
                if (Tipo)
                {
                    barraProgreso.PerformStep();
                    Rutas.Add(D.FileName);
                    lbMostrar.Items.Add(new TextBox().Text = D.SafeFileName + " (Encriptado)");
                    barraProgreso.PerformStep();
                    FileStream fs = new FileStream(D.FileName, FileMode.Open);
                    BinaryWriter bw = new BinaryWriter(fs);
                    barraProgreso.PerformStep();
                    label2.Show();
                    bw.Write(FIG);
                    bw.Close();
                    fs.Close();
                }
                else
                {
                    FileStream fs = new FileStream(D.FileName, FileMode.Open);
                    BinaryWriter bw = new BinaryWriter(fs);
                    bw.Write(FIG);
                    bw.Close();
                    fs.Close();

                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show("No se puede acceder a la imagen", "Aviso");
            }

        }

        private void btnDesencriptar_Click(object sender, EventArgs e)
        {
            int selected = lbMostrar.SelectedIndex;
            if (selected >= 0)
            {
                D.FileName = Rutas[selected];
                if (lbMostrar.Items[selected].ToString().Equals(D.SafeFileName + " (Encriptado)"))
                {
                    encriptarODesencriptarArchivo(D, false);
                    lbMostrar.Items.RemoveAt(selected);
                    lbMostrar.Items.Add(new TextBox().Text = D.SafeFileName);
                    Rutas.RemoveAt(selected);
                    Rutas.Add(D.FileName);
                }
                else MessageBox.Show("El archivo seleccionado no está encriptado", "Aviso");
            }
            else MessageBox.Show("Seleccione un archivo a desencriptar", "Aviso");
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            int selected = lbMostrar.SelectedIndex;
            if (selected >= 0)
            {
                D.FileName = Rutas[selected];
                if (!lbMostrar.Items[selected].ToString().Equals(D.SafeFileName + " (Encriptado)"))
                {
                    System.Diagnostics.Process.Start(Rutas[selected]);
                }
                else MessageBox.Show("El archivo seleccionado está encriptado.\n" +
                    "Desencriptelo para poder abrirlo.", "Aviso");
            }
            else MessageBox.Show("Seleccione un archivo a mostrar", "Aviso");
        }

        private void lbMostrar_Click(object sender, EventArgs e)
        {
            int selected = lbMostrar.SelectedIndex;
            if (selected >= 0)
            {
                D.FileName = Rutas[selected];
                pictureBox1.ImageLocation=Rutas[selected];
            }

        }

        private void encriptaGif_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
    }
}
