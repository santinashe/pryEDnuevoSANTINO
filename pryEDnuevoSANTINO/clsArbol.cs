using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEDnuevoSANTINO
{
    internal class clsArbol
    {
        //Campos del arbol
        private clsNodo PrimerNodo;
        //Propiedades del arbol
        public clsNodo Raiz
        {
            get { return PrimerNodo; }
            set { PrimerNodo = value; }

        }

        private void Agregar(clsNodo nuevo)
        {
            if (Raiz == null)
            {
                PrimerNodo = nuevo;
            }
            else
            {
                clsNodo ant = Raiz;
                clsNodo aux = Raiz;
                ant = aux;
                while (aux != null)
                {
                    if (nuevo.Codigo < aux.Codigo) aux = aux.Izquierda;
                    else aux = aux.Derecha;
                }
                if (nuevo.Codigo < ant.Codigo) ant.Izquierda = nuevo;
                else ant.Derecha = nuevo;
            }
        }

        public void Recorrer(DataGridView Grilla)
        { 
            Grilla.Rows.Clear();
            InOrdenAsc(Grilla, Raiz);

        }
        private void InOrdenAsc(DataGridView dgv, clsNodo R)
        {
                
                if (R != null)
          
                InOrdenAsc(dgv, R.Izquierda);
                dgv.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
                InOrdenAsc(dgv, R.Derecha);
                if(R.Derecha !=null ) InOrdenAsc(dgv, R.Derecha);
        }
        

        

    }

}
