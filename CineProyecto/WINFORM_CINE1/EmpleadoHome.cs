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
    public partial class EmpleadoHome : Form
    {
        public EmpleadoHome()
        {
            InitializeComponent();
        }
        private void EmpleadoHome_Load(object sender, EventArgs e)
        {
            Mostrar();
        }

        private void btmRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form anterior = new conexion_del_empleado();
            anterior.Show();
        }

        private void btmContinuar_Click(object sender, EventArgs e)
        {
            if (txtCod.Text != "")
            {
                for (int i = 0; i < Butacas.nodo.Count; i++)
                {
                    if (Butacas.nodo[i].codigo == txtCod.Text)
                    {
                        MessageBox.Show("Código encontrado!\n" + Butacas.nodo[i]);
                    }
                }
            }
            if (EncontrarCódigo()==0)
            {
                MessageBox.Show("Código no encontrado");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clases.Datos.numClientes -= 1;
            if (txtCod.Text != "")
            {
                DialogResult r = MessageBox.Show("¿Está seguro de borrar el código?", "", MessageBoxButtons.YesNo);
                if (r == DialogResult.Yes)
                {
                    for (int i = 0; i < Butacas.nodo.Count; i++)
                    {
                        if (Butacas.nodo[i].codigo == txtCod.Text)
                        {
                            Butacas.nodo.Remove(Butacas.nodo[i]);
                            MessageBox.Show("Código eliminado");
                            Mostrar();
                        }
                    }
                }
            }
            else if (EncontrarCódigo()==0)
            {
                MessageBox.Show("Código no encontrado");
            }
            else MessageBox.Show("Ingrese el código primero");
        }
        public void Mostrar()
        {
            txtClientes.Text = "";
            foreach (var Butacas in Butacas.nodo)
            {
                txtClientes.Text += Butacas;
            }
        }
        public int EncontrarCódigo()
        {
            int num = 0;
            for (int i = 0; i < Butacas.nodo.Count; i++)
            {
                if (Butacas.nodo[i].codigo == txtCod.Text)
                {
                    num = 1;
                }
            }
            return num;
        }
    }
}
