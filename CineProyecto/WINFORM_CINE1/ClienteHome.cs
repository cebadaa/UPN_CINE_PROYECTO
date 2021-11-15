using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WINFORM_CINE1
{
    public partial class ClienteHome : Form
    {
        public ClienteHome()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void Btm_Clie_Click(object sender, EventArgs e) //SALA 1
        {
            Clases.Datos.nombrePeli = btmSala1.Text;
            this.Hide();
            Form siguiente = new Butacas();
            siguiente.Show();
        }

        private void button1_Click(object sender, EventArgs e) //SALA 2
        {
            Clases.Datos.nombrePeli = btmSala2.Text;
            Form siguiente = new Butacas();
            siguiente.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e) //SALA 3
        {
            Clases.Datos.nombrePeli = btmSala3.Text;
            Form siguiente = new Butacas();
            siguiente.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e) //SALA 4
        {
            Clases.Datos.nombrePeli = btmSala4.Text;
            Form siguiente = new Butacas();
            siguiente.Show();
            this.Hide();
        }

        private void Btm_SubM_Click(object sender, EventArgs e) //Botón regresar
        {
            Form anterior = new Principal();
            anterior.Show();
            this.Hide();
        }

    }
}
