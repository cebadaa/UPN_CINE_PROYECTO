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
    public partial class conexion_del_empleado : Form
    {
        public conexion_del_empleado()
        {
            InitializeComponent();
        }

        private void txtVerCod_Click(object sender, EventArgs e)
        {
            Form siguiente = new EmpleadoHome();
            siguiente.Show();
            this.Hide();
        }

        private void txtverRuta_Click(object sender, EventArgs e)
        {
            Form nuevo = new Form1();
            nuevo.Show();
            this.Hide();
        }
        private void btmRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form anterior = new Principal();
            anterior.Show();
        }
    }
}
