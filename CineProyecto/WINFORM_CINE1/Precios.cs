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
    public partial class Precios : Form
    {
        Clases.Cliente cliente = new Clases.Cliente();
        public Precios()
        {
            InitializeComponent();
        }
        //---------------------------------------------------------------------------
        //                              BOTONES (+)
        private void btmMasGeneral_Click(object sender, EventArgs e) 
        {
            if (SumarButacas() == 0)
            {
                canGeneral.Text = Convert.ToString(Convert.ToInt32(canGeneral.Text) + 1);
            }
        }

        private void btmMasMayores_Click(object sender, EventArgs e) 
        {
            if (SumarButacas() == 0)
            {
                canMayores.Text = Convert.ToString(Convert.ToInt32(canMayores.Text) + 1);
            }
        }

        private void btmMasNiños_Click(object sender, EventArgs e) 
        {
            if (SumarButacas() == 0)
            {
                canNiños.Text = Convert.ToString(Convert.ToInt32(canNiños.Text) + 1);
            }
        }
        //---------------------------------------------------------------------------

        //                              BOTONES (-)
        private void btmMenosGeneral_Click(object sender, EventArgs e) 
        {
            if (canGeneral.Text != "0")
            {
                canGeneral.Text = Convert.ToString(Convert.ToInt32(canGeneral.Text) - 1);
            }
        }
        private void btmMenosMayores_Click(object sender, EventArgs e)
        {
            if (canMayores.Text != "0")
            {
                canMayores.Text = Convert.ToString(Convert.ToInt32(canMayores.Text) - 1);
            }
        }
        private void btmMenosNiños_Click(object sender, EventArgs e)
        {
            if (canNiños.Text != "0")
            {
                canNiños.Text = Convert.ToString(Convert.ToInt32(canNiños.Text) - 1);
            }
        }
        public int SumarButacas()
        {
            int suma;
            suma = Convert.ToInt32(canGeneral.Text)+ Convert.ToInt32(canMayores.Text) + Convert.ToInt32(canNiños.Text);
            if (suma >= cliente.ContarButacasSeleccionadas())
            {
                return 1;
            }
            return 0;
        }
        public int SumarButacas2()
        {
            int suma;
            suma = Convert.ToInt32(canGeneral.Text) + Convert.ToInt32(canMayores.Text) + Convert.ToInt32(canNiños.Text);
            return suma;
        }
        private void BtmContinuar_Click(object sender, EventArgs e)
        {
            if (SumarButacas2() == cliente.ContarButacasSeleccionadas())
            {
                //CALCULAR EL PRECIO
                double pre = Convert.ToInt32(canGeneral.Text) * 17 + Convert.ToInt32(canMayores.Text) * 10 + Convert.ToInt32(canNiños.Text) * 10;
                Clases.Datos.precio = pre;
                this.Hide();
                Form siguiente = new Snacks();
                siguiente.Show();
            }
            else MessageBox.Show("Selecciona todas sus entradas!");
        }

        private void btmRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form anterior = new Butacas();
            anterior.Show();
        }
    }
}
