using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WINFORM_CINE1.Clases
{
    public class Nodo
    {
        public string codigo { get; set; }
        public string butacas { get; set; }
        public int canButaca { get; set; }
        public Nodo siguiente { get; set; }
        public Nodo anterior { get; set; }
        public Nodo(string codigo, string butacas, int numBu)
        {
            this.codigo = codigo;
            this.butacas = butacas;
            this.canButaca = numBu;
            siguiente = null;
            anterior = null;
        }
        public override string ToString()
        {
            string clien = "Código: " + codigo +
            Environment.NewLine + "Butacas: " + butacas +
            Environment.NewLine + "Cantidad: " + canButaca.ToString() + Environment.NewLine + Environment.NewLine;
            return clien;
        }
    }
    public class Lista
    {
        static public List<string> ListaButacas = new List<string> { };
        static public List<string> ListaSala1 = new List<string> { };
        static public List<string> ListaSala2 = new List<string> { };
        static public List<string> ListaSala3 = new List<string> { };
        static public List<string> ListaSala4 = new List<string> { };
        static public List<string> ListaSala5 = new List<string> { };
        static public List<string> ListaSala6 = new List<string> { };
        static public List<string> ListaSala7 = new List<string> { };
        static public List<string> ListaSala8 = new List<string> { };


    }
    public class Datos
    {
        static public string nombrePeli;
        static public double precio;
        static public int numClientes;
    }
    class Combos
    {
        public string Nombre { get; set; }
        public double Precio { get; set; }
        static public Queue<Combos> misCombos = new Queue<Combos>();
    }
}
