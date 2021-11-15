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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnCont_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text != "1234" || txtContras.Text != "1234")
            {
                if (txtUsuario.Text == "" || txtContras.Text == "")
                {
                    MessageBox.Show("Los campos están vacíos, por favor complételos para seguir con el proceso.");
                }
                else
                {
                    MessageBox.Show("Asegúrese que el usuaio y la contraseña sean correctas.");
                }
            }
            else
            {
                string usuario = Convert.ToString(txtUsuario.Text);
                string passw = Convert.ToString(txtContras.Text);
                this.Hide();
                Form siguiente = new conexion_del_empleado();
                siguiente.Show();
            }
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            Form anterior = new Principal();
            anterior.Show();
            this.Hide();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
