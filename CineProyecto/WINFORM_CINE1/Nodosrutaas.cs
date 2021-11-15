using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WINFORM_CINE1
{
    class Nodosrutaas
    {
        int[,] mAdyacencia;
        int nodos;
        public Nodosrutaas(int pNOdos)
        {
            nodos = pNOdos;
            mAdyacencia = new int[nodos, nodos];
        }
        public void AddArista(int pNOdoIn,int pNOdoFin,int pDist)
        {
            mAdyacencia[pNOdoIn, pNOdoFin] = pDist;
        }
        public void ShowAdya(RichTextBox txtAd)
        {
            for (int n = 0; n <nodos; n++)          
                txtAd.Text += "\t" + n;
            txtAd.Text += "\n";
            for (int n = 0; n < nodos; n++)
            {
                txtAd.Text += n + "\t";
                for (int d = 0; d < nodos; d++)
                {
                    txtAd.Text += mAdyacencia[n, d] + "\t";
                }
                txtAd.Text +="\n";
            }
        }
        public int ObtaindADy(int cFila,int cColumna) 
        {
            return mAdyacencia[cFila, cColumna];
        }
    }
    
}
