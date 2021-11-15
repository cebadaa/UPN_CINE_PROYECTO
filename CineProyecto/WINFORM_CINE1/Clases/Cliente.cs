using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WINFORM_CINE1.Clases
{
    public class Cliente
    {
        Nodo ultimo, primero, encontrado, temp;
        public Cliente()
        {
            primero = null;
        }
        public string GenerarCódigo()
        {
            var caracter = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var codArr = new char[4];
            var random = new Random();

            for (int i = 0; i < codArr.Length; i++)
            {
                codArr[i] = caracter[random.Next(caracter.Length)];
            }
            return new String(codArr);
        }
        public void RecorrerListaButacas(Label numButacas)
        {
            numButacas.Text = "";
            for (int i = 0; i < Clases.Lista.ListaButacas.Count; i++)
            {
                numButacas.Text += Clases.Lista.ListaButacas[i] + ", ";
            }
        }
        public void AgregarListaButacas(string numButaca)
        {
            Clases.Lista.ListaButacas.Add(numButaca);
        }
        public void EliminarListaButaca(string numButaca)
        {
            Clases.Lista.ListaButacas.Remove(numButaca);
        }
        public int ContarButacasSeleccionadas()
        {
            return Clases.Lista.ListaButacas.Count();
        }
        public void Agregar(Nodo nuevo)
        {
            if (primero == null)
            {
                primero = nuevo;
                ultimo = nuevo;
            }
            else
            {
                nuevo.anterior = ultimo;
                ultimo.siguiente = nuevo;
                ultimo = nuevo;
            }
        }
        public Nodo Buscar(string codigo)
        {
            temp = primero;
            encontrado = null;
            while (encontrado == null && temp != null)
                if (temp.codigo == codigo)
                    encontrado = temp;
                else
                    temp = temp.siguiente;
            return encontrado;
        }
        public string Mostrar()
        {
            string cliente = "";
            temp = primero;
            while (temp != null)
            {
                cliente += temp.ToString() + Environment.NewLine;
                temp = temp.siguiente;
            }
            return cliente;
        }
    }
}
