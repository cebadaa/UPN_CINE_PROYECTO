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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
            DISEÑo();
        }

        private void DISEÑo()
        {
            SubM.Visible = false;
        }

        private void OcultarSubMenu()
        {
            if (SubM.Visible == true)
            {
                SubM.Visible = false;
            }

        }

        private void MostrarSubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                OcultarSubMenu();
                submenu.Visible = true;
            }

            else
            {
                submenu.Visible = false;
            }
        }

        private void Btm_SubM_Click(object sender, EventArgs e)
        {
            MostrarSubmenu(SubM);
        }

        private void Btm_Clie_Click(object sender, EventArgs e)
        {
            Form siguiente = new ClienteHome();
            siguiente.Show();
            this.Hide();
            OcultarSubMenu();
        }

        private void Btm_Trab_Click(object sender, EventArgs e)
        {
            Form siguiente = new Login();
            siguiente.Show();
            this.Hide();
            OcultarSubMenu();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            OcultarSubMenu();
        }
    }
}
