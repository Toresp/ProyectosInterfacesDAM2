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
    public partial class Form2 : Form
    {
        public string Tipo;
        public Form2(string tipo)
        {
            Tipo = tipo;
            InitializeComponent();
            test.Text = "VENTANA TIPO " + tipo;
        }
    }
}
