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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int inicio = 0, final = 0, distancia = 0, n = 0, d = 0;
        int cantNodos = 6, actual = 0, columna = 0;
        int[,] tabla;
        Nodosrutaas grafo = new Nodosrutaas(6);
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Form anterior = new conexion_del_empleado();
            anterior.Show();
            this.Hide();
        }

        

        private void btnMostrarRutas_Click(object sender, EventArgs e)
        {
            inicio = int.Parse(txtIni.Text);
            final = int.Parse(txtFinal.Text);
            tabla = new int[6, 3];
            for (int n = 0; n < 6; n++)
            {
                tabla[n, 0] = 0;
                tabla[n, 1] = 99;
                tabla[n, 2] = 0;
            }
            tabla[inicio, 1] = 0;
            MostrarTabla(tabla);

            txtDistancia.Text += "\n-----------------------------------------------------------------------------------\n";
            actual = inicio;
            do
            {
                tabla[actual, 0] = 1;
                for (columna = 0; columna < 6; columna++)
                {
                    if (grafo.ObtaindADy(actual, columna) != 0)
                    {
                        distancia = grafo.ObtaindADy(actual, columna) + tabla[actual, 1];
                        if (distancia < tabla[columna, 1])
                        {
                            tabla[columna, 1] = distancia;
                            tabla[columna, 2] = actual;
                        }
                    }
                }
                int indiceMenor = -1;
                int distanciaMenor = 99;
                for (int x = 0; x < 6; x++)
                {
                    if (tabla[x, 1] < distanciaMenor && tabla[x, 0] == 0)
                    {
                        indiceMenor = x;
                        distanciaMenor = tabla[x, 1];
                    }
                    actual = indiceMenor;
                }

            } while (actual != -1);
            MostrarTabla(tabla);
        }

        
        private void btnMostrarRuta_Click(object sender, EventArgs e)
        {
            List<int> ruta = new List<int>();
            int nodo = final;
            while (nodo != inicio) 
            {
                ruta.Add(nodo);
                nodo = tabla[nodo, 2];
            }
            ruta.Add(inicio);
            ruta.Reverse();
            foreach (int posicion in ruta)
            {
                txtRutaCorta.Text+=posicion+" => ";
            }
        }

        
        private void btnMostrarMatriz_Click(object sender, EventArgs e)
        {
            grafo.ShowAdya(txtAdyen);
  
        }
        private void MostrarTabla(int[,] pTabla) 
        {
            int n = 0;
            for (n = 0; n <pTabla.GetLength(0); n++)
            {
                txtDistancia.Text += n + " => \t"+pTabla[n,0]+"\t"+
                    pTabla[n,1]+"\t"+pTabla[n,2]+"\n";
            }
        }

        
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            int nodoIni = int.Parse(txtNodoPri.Text);
            int nodoFin = int.Parse(txtFin.Text);
            int pdistancia = int.Parse(txtDist.Text);
            grafo.AddArista(nodoIni, nodoFin, pdistancia);
            listBox1.Items.Add(nodoIni + " | " + nodoFin + " | " + pdistancia);
        }
    }
}
