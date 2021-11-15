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
    public partial class Boleta : Form
    {
        Clases.Cliente clienteb = new Clases.Cliente();
        Clases.Combos combosb = new Clases.Combos();
        public Boleta()
        {
            InitializeComponent();
        }

        private void btmContinuar_Click(object sender, EventArgs e)
        {
            //LIMPIAR LA LISTA DE BUTACAS - LIMPIAR LA COLA
            Clases.Lista.ListaButacas.Clear();
            Clases.Combos.misCombos.Clear();

            Clases.Datos.numClientes += 1;
            this.Hide();
            Form siguiente = new Principal();
            siguiente.Show();
        }

        private void Boleta_Load(object sender, EventArgs e)
        {
            Butacas FB = new Butacas();
            Snacks FS = new Snacks();

            txtBoleta.Text = "////////////////////////////////////////////////////////////////////////////" + Environment.NewLine +
                             "                                               A VER AL CINE APP            " + Environment.NewLine +
                             "////////////////////////////////////////////////////////////////////////////" + Environment.NewLine +
                             Environment.NewLine +
                             Environment.NewLine +
                             "Código: " + Butacas.nodo[Clases.Datos.numClientes].codigo+ Environment.NewLine +
                             "Nro de butacas: " + clienteb.ContarButacasSeleccionadas() + Environment.NewLine +
                             "Pelicula: " + Clases.Datos.nombrePeli + Environment.NewLine +
                             "Combos: " + MostrarCombos() +Environment.NewLine +
                             "Monto total: S/." + Clases.Datos.precio + Environment.NewLine;
        }
        public string MostrarCombos()
        {
            string texto="";
            while (Clases.Combos.misCombos.Count > 0)
            {
                texto += Clases.Combos.misCombos.Dequeue().Nombre + ", ";
            }
            return texto;
        }
    }
}
