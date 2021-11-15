using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WINFORM_CINE1.Clases;

namespace WINFORM_CINE1
{
    public partial class Butacas : Form
    {
        Clases.Cliente cliente = new Clases.Cliente();
        System.Drawing.Bitmap imagen_disponible = new System.Drawing.Bitmap(Properties.Resources.GRIS);
        System.Drawing.Bitmap imagen_agregar = new System.Drawing.Bitmap(Properties.Resources.VERDE);
        System.Drawing.Bitmap imagen_ocupada = new System.Drawing.Bitmap(Properties.Resources.ROJO);
        public Butacas()
        {
            InitializeComponent();
        }
        internal static List<Nodo> nodo = new List<Nodo>();

        private void Butacas_Load(object sender, EventArgs e)
        {
            Clases.Lista.ListaButacas.Clear();
            //CAMBIAR COLOR A TODAS LAS BUTACAS
            foreach (Control f in Controls)
            {
                if (f.GetType() == typeof(PictureBox))
                {
                    f.BackgroundImage = imagen_disponible;
                }
            }
            //CAMBIAR DE COLOR A LAS BUTACAS YA SEPARADAS POR SALAS
            if (Clases.Datos.nombrePeli == "Harry Potter")
            {
                for (int i = 0; i < Clases.Lista.ListaSala1.Count; i++)
                {
                    string nombre = Clases.Lista.ListaSala1[i];
                    foreach (Control f in Controls)
                    {
                        if (f.GetType() == typeof(PictureBox))
                        {
                            if (f.Name == nombre)
                            {
                                f.BackgroundImage = imagen_ocupada;
                            }
                        }
                    }
                }
            }
            else if (Clases.Datos.nombrePeli == "Planeta del Tesoro")
            {
                for (int i = 0; i < Clases.Lista.ListaSala2.Count; i++)
                {
                    string nombre = Clases.Lista.ListaSala2[i];
                    foreach (Control f in Controls)
                    {
                        if (f.GetType() == typeof(PictureBox))
                        {
                            if (f.Name == nombre)
                            {
                                f.BackgroundImage = imagen_ocupada;
                            }
                        }
                    }
                }
            }
            else if (Clases.Datos.nombrePeli == "Venom")
            {
                for (int i = 0; i < Clases.Lista.ListaSala3.Count; i++)
                {
                    string nombre = Clases.Lista.ListaSala3[i];
                    foreach (Control f in Controls)
                    {
                        if (f.GetType() == typeof(PictureBox))
                        {
                            if (f.Name == nombre)
                            {
                                f.BackgroundImage = imagen_ocupada;
                            }
                        }
                    }
                }
            }
            else if (Clases.Datos.nombrePeli == "Rapidos y furiosos")
            {
                for (int i = 0; i < Clases.Lista.ListaSala4.Count; i++)
                {
                    string nombre = Clases.Lista.ListaSala4[i];
                    foreach (Control f in Controls)
                    {
                        if (f.GetType() == typeof(PictureBox))
                        {
                            if (f.Name == nombre)
                            {
                                f.BackgroundImage = imagen_ocupada;
                            }
                        }
                    }
                }
            }
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            //CAMBIAR COLOR DE BUTACAS AL SELECCIONARLAS
            if (object.ReferenceEquals(((PictureBox)sender).BackgroundImage, imagen_disponible))
            {
                ((PictureBox)sender).BackgroundImage = imagen_agregar;
                // OBTENER NOMBRE DE BUTACA - AGREGAR AL STRING
                string butaca = ((PictureBox)sender).Name;
                cliente.AgregarListaButacas(butaca);
                cliente.RecorrerListaButacas(CodButaca);
            }
            else if (object.ReferenceEquals(((PictureBox)sender).BackgroundImage, imagen_agregar))
            {
                ((PictureBox)sender).BackgroundImage = imagen_disponible;
                // OBTENER NOMBRE DE BUTACA - QUITAR DEL STRING
                string butaca = ((PictureBox)sender).Name;
                cliente.EliminarListaButaca(butaca);
                cliente.RecorrerListaButacas(CodButaca);
            }
        }

        private void BtmContinuar_Click(object sender, EventArgs e) 
        {
            if (CodButaca.Text=="")
            {
                MessageBox.Show("Debe seleccionar una butaca primero");
            }
            else
            {
                string código = cliente.GenerarCódigo();
                string butacas = CodButaca.Text;
                int canButacas = cliente.ContarButacasSeleccionadas();
                cliente.Agregar(new Clases.Nodo(código, butacas, canButacas));
                MessageBox.Show(cliente.Mostrar());

                nodo.Add(new Nodo(código, butacas, canButacas));

                this.Hide();
                Form siguiente = new Precios();
                siguiente.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form anterior = new ClienteHome();
            anterior.Show();
        }
    }
}
