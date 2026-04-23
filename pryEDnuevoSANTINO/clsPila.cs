using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEDnuevoSANTINO
{
    internal class clsPila
    {
        private clsNodo pri;

        public clsNodo Primero
        {
            get { return pri; }
            set{ pri = value; }
        }
         
        public void Agregar(clsNodo nuevo)
        {
            if (pri == null)
            {
                pri = nuevo;
            }
            else
            {
                nuevo.Siguiente = pri;
                pri = nuevo;
            }
        }
        public void Eliminar()
        {
            if (Primero != null)
            {
                
                Primero = Primero.Siguiente;
            }
        }   
            public void Recorrer(DataGridView Grilla)
            {
                clsNodo aux = Primero;
                Grilla.Rows.Clear();

                while (aux != null)
                {
                    Grilla.Rows.Add(aux.Codigo, aux.Nombre, aux.Tramite);
                    aux = aux.Siguiente;
                }


            }
        public void Recorrer(ListBox Lista)
        {
            clsNodo aux = Primero;
            Lista.Items.Clear();
            while (aux != null)
            {
                Lista.Items.Add(aux.Codigo + " - " + aux.Nombre + " - " + aux.Tramite);
                aux = aux.Siguiente;
            }
        }

        public void recorrer(ComboBox Combo)
        {
            clsNodo aux = Primero;
            Combo.Items.Clear();
            while (aux != null)
            {
                Combo.Items.Add(aux.Codigo + " - " + aux.Nombre + " - " + aux.Tramite);
                aux = aux.Siguiente;
            }


        }
        //false → ⚠️ sobrescribe el archivo (no agrega)
        //Encoding.UTF8 → permite usar acentos y caracteres especiales
        //StreamWriter → clase para escribir en archivos de texto
        //👉 Cuando sale del bloque { }:

        //USING
        //Se cierra automáticamente
        //Libera memoria
        //Evita errores
        public void Recorrer()
        {
            clsNodo aux = Primero;

            using (StreamWriter AD = new StreamWriter("Cola.csv", false, Encoding.UTF8))
            {
                AD.WriteLine("Lista de espera\n");
                AD.WriteLine("Codigo;Nombre;Tramite");


                while (aux != null)
                {
                    AD.WriteLine(aux.Codigo + ";" + aux.Nombre + ";" + aux.Tramite);
                    aux = aux.Siguiente;
                }
            }
        }

    }
}   
