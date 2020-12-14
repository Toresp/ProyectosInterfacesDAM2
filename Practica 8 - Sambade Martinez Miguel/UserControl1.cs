using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_8___Sambade_Martinez_Miguel
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void btnMas_Click(object sender, EventArgs e)
        {
            
            float Presion = float.Parse(txtPresion.Text);
            if (Presion > 4)
                txtPresion.Text = "4";
            if (Presion < 4)
            {
                Presion += 0.1f;
                txtPresion.Text = (Presion).ToString();
                progressBar1.PerformStep();
            }
            setColor(Presion);


        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            float Presion = float.Parse(txtPresion.Text);

            if (Presion < 0)
                txtPresion.Text = "0";
            if (Presion > 0)
            {
                Presion -= 0.1f;
                txtPresion.Text = (Presion).ToString();
                progressBar1.Value-=1;
            }
            setColor(Presion);

        }
        public void Cargar(String txt1 ,String txt2)
        {
            Rueda.Text = txt1;
            txtPresion.Text = txt2;
            float Presion = float.Parse(txtPresion.Text);
            progressBar1.Value = (int)(Presion * 10);
            setColor(Presion);
        }
        private void setColor(float Presion)
        {
            if (Presion < 2)
                this.BackColor = Color.Gray;
            if (Presion >= 2 && Presion <= 3)
                this.BackColor = Color.LightGreen;
            if (Presion > 3)
                this.BackColor = Color.Red;
        }
        public String getPresion()
        {
            return txtPresion.Text;
        }

    }
}
