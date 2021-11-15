using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WINFORM_CINE1.Properties;

namespace WINFORM_CINE1
{
    public partial class Snacks : Form
    {
        Clases.Cliente cliente = new Clases.Cliente();
        public Snacks()
        {
            InitializeComponent();
        }
        private void Snacks_Load(object sender, EventArgs e)
        {
            Clases.Combos.misCombos.Clear();
            Total.Text = "Total: S/." + Clases.Datos.precio;
            canButacas.Text = cliente.ContarButacasSeleccionadas()+"";
            nomPelicula.Text = Clases.Datos.nombrePeli;

            if (Clases.Datos.nombrePeli == "Harry Potter")
            {
                ImagenPeli.BackgroundImage = Resources.Harry_Potter;
            }
            else if (Clases.Datos.nombrePeli == "Planeta del Tesoro")
            {
                ImagenPeli.BackgroundImage = Resources.Planeta_del_tesoro;
            }
            else if (Clases.Datos.nombrePeli == "Venom")
            {
                ImagenPeli.BackgroundImage = Resources.Venom;
            }
            else if (Clases.Datos.nombrePeli == "Rapidos y furiosos")
            {
                ImagenPeli.BackgroundImage = Resources.Rapidos_y_Furiosos;
            }
        }

        private void btmAgregarCombo1_Click(object sender, EventArgs e)
        {
            Clases.Combos combos = new Clases.Combos();
            combos.Nombre = "Combo 1";
            combos.Precio = 39.00;

            Clases.Combos.misCombos.Enqueue(combos);
            dgv.DataSource = null;
            dgv.DataSource = Clases.Combos.misCombos.ToList();
        }

        private void btmAgregarCombo2_Click(object sender, EventArgs e)
        {
            Clases.Combos combos = new Clases.Combos();
            combos.Nombre = "Combo 2";
            combos.Precio = 50.00;

            Clases.Combos.misCombos.Enqueue(combos);
            dgv.DataSource = null;
            dgv.DataSource = Clases.Combos.misCombos.ToList();
        }

        private void btmEliminar_Click(object sender, EventArgs e)
        {
            Clases.Combos combos = new Clases.Combos();
            if(Clases.Combos.misCombos.Count()>0)
            {
                Clases.Combos.misCombos.Dequeue();
                dgv.DataSource = null;
                dgv.DataSource = Clases.Combos.misCombos.ToList();
            }
        }

        private void btmContinuar_Click(object sender, EventArgs e)
        {
            //OBTENER PRECIO DE TODOS LOS COMBOS AGREGADOS AL DGV
            double suma = 0;
            foreach (DataGridViewRow row in this.dgv.Rows)
            {
                suma += (double)row.Cells[1].Value;
            }
            Clases.Datos.precio += suma; //Sumar los precios anteriores
            MessageBox.Show(Clases.Datos.precio+"");


            // AGREGAR LAS BUTACAS COMPRADAS A LA LISTA DE LA SALA CORRESPONDIENTE
            if (Clases.Datos.nombrePeli == "Harry Potter")
            {
                for (int i = 0; i < Clases.Lista.ListaButacas.Count; i++)
                {
                    Clases.Lista.ListaSala1.Add(Clases.Lista.ListaButacas[i]);
                }
            }
            else if (Clases.Datos.nombrePeli == "Planeta del Tesoro")
            {
                for (int i = 0; i < Clases.Lista.ListaButacas.Count; i++)
                {
                    Clases.Lista.ListaSala2.Add(Clases.Lista.ListaButacas[i]);
                }
            }
            else if (Clases.Datos.nombrePeli == "Venom")
            {
                for (int i = 0; i < Clases.Lista.ListaButacas.Count; i++)
                {
                    Clases.Lista.ListaSala3.Add(Clases.Lista.ListaButacas[i]);
                }
            }
            else if (Clases.Datos.nombrePeli == "Rapidos y furiosos")
            {
                for (int i = 0; i < Clases.Lista.ListaButacas.Count; i++)
                {
                    Clases.Lista.ListaSala4.Add(Clases.Lista.ListaButacas[i]);
                }
            }
            this.Hide();
            Form siguiente = new Boleta();
            siguiente.Show();
        }

        private void btmRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form anterior = new Precios();
            anterior.Show();
        }
    }
}
