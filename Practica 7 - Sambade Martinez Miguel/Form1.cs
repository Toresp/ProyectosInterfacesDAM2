using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_7___Sambade_Martinez_Miguel
{
    public partial class Form1 : Form
    {
        buscaPalabra buscarPalabras = new buscaPalabra();
        encriptaGif encriptarGIF = new encriptaGif();
        organizaVideos organizarVideos = new organizaVideos();
        public Form1()
        {
            InitializeComponent();

        }

        private void buscaPalabra_Click(object sender, EventArgs e)
        {
            buscarPalabras.MdiParent = this;
            buscarPalabras.Show();
            buscarPalabrasToolStripMenuItem.Visible = true;
        }

        private void encripta_Click(object sender, EventArgs e)
        {
            encriptarGIF.MdiParent = this;
            encriptarGIF.Show();
            encriptaGIFToolStripMenuItem.Visible = true;
        }

        private void organiza_Click(object sender, EventArgs e)
        {
            organizarVideos.MdiParent = this;
            organizarVideos.Show();
            organizaVideosToolStripMenuItem.Visible = true;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            buscarPalabras.Close();
            encriptarGIF.Close();
            organizarVideos.Close();
            e.Cancel = false;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
