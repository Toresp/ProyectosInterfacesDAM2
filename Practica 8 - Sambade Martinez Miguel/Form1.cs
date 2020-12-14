using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_8___Sambade_Martinez_Miguel
{
    public partial class Form1 : Form
    {
        OpenFileDialog D = new OpenFileDialog();
        DataSet ds = new DataSet();
       
        public Form1()
        {
            InitializeComponent();
            
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            D.Title = "Elige un xml";
            D.Filter = "gif files (*.xml) | *.xml";
            if (D.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ds.Clear();
                    label1.Text = "Tabla Presiones " + D.SafeFileName;
                    ds.ReadXml(D.FileName);
                    dataGridView1.DataSource = ds;
                    dataGridView1.DataMember = "neumatico";
                    //Se cargan los controles
                    userControl11.Cargar("Rueda " + dataGridView1.Rows[0].Cells[0].Value, dataGridView1.Rows[0].Cells[1].Value.ToString());
                    userControl12.Cargar("Rueda " + dataGridView1.Rows[1].Cells[0].Value, dataGridView1.Rows[1].Cells[1].Value.ToString());
                    userControl13.Cargar("Rueda " + dataGridView1.Rows[2].Cells[0].Value, dataGridView1.Rows[2].Cells[1].Value.ToString());
                    userControl14.Cargar("Rueda " + dataGridView1.Rows[3].Cells[0].Value, dataGridView1.Rows[3].Cells[1].Value.ToString());

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message, "Error!");
                }


            }
        }

        private void btnPoner_Click(object sender, EventArgs e)
        {

            userControl11.Cargar("Rueda " + dataGridView1.Rows[0].Cells[0].Value, dataGridView1.Rows[0].Cells[2].Value.ToString());
            userControl12.Cargar("Rueda " + dataGridView1.Rows[1].Cells[0].Value, dataGridView1.Rows[1].Cells[2].Value.ToString());
            userControl13.Cargar("Rueda " + dataGridView1.Rows[2].Cells[0].Value, dataGridView1.Rows[2].Cells[2].Value.ToString());
            userControl14.Cargar("Rueda " + dataGridView1.Rows[3].Cells[0].Value, dataGridView1.Rows[3].Cells[2].Value.ToString());
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Rows[0].Cells[1].Value = userControl11.getPresion();
                dataGridView1.Rows[1].Cells[1].Value = userControl12.getPresion();
                dataGridView1.Rows[2].Cells[1].Value = userControl13.getPresion();
                dataGridView1.Rows[3].Cells[1].Value = userControl14.getPresion();
                ds.WriteXml(D.FileName);
                MessageBox.Show("Archivo Sobreescrito con Exito", "Aviso");
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Error!");
            }
        }
    }
}
