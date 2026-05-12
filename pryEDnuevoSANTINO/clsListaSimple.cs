using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Diagnostics.Eventing.Reader;
using System.Security.Cryptography.X509Certificates;


namespace pryEDnuevoSANTINO
{
    internal class clsListaSimple
    {
        private clsNodo pri;

        public clsNodo Primero
        {
            get { return pri; }
            set { pri = value; }
        }
        public void Agregar(clsNodo nuevo)
        {
            if (pri == null)
            {
                pri = nuevo;
            }
            else
            {
                if (nuevo.Codigo <= pri.Codigo)
                {
                    nuevo.Siguiente = pri;
                    pri = nuevo;
                }
                else
                {
                    clsNodo ant = pri;
                    clsNodo aux = pri;
                    while (nuevo.Codigo > aux.Codigo)
                    {
                        ant = aux;
                        aux = aux.Siguiente;
                        if (aux == null) break;
                    }
                    nuevo.Siguiente = aux;
                    ant.Siguiente = nuevo;
                }
        
            }
            
        }
        public void Eliminar(Int32 Codigo)
        {           
            
            if (Primero.Codigo == Codigo)
            {
                Primero = Primero.Siguiente;
            }
            else
            {
                clsNodo Aux = Primero;
                clsNodo Ant = Primero;
                while (Aux.Codigo != Codigo)
                {
                    Ant = Aux;
                    Aux = Aux.Siguiente;
                }
                Ant.Siguiente = Aux.Siguiente;
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

       // public void recorrer(ComboBox Combo)
    //    {
           // clsNodo aux = Primero;
          // Combo.Items.Clear();
            //while (aux != null)
          //  {
               // Combo.Items.Add(aux.Codigo + " - " + aux.Nombre + " - " + aux.Tramite);
               // aux = aux.Siguiente;
           // }


        //}
        //false → ⚠️ sobrescribe el archivo (no agrega)
        //Encoding.UTF8 → permite usar acentos y caracteres especiales
        //StreamWriter → clase para escribir en archivos de texto
        //👉 Cuando sale del bloque { }:

        //USING
        //Se cierra automáticamente
        //Libera memoria
        //Evita errores
        public void Recorrer(ComboBox cmbCodigo)
        {
            
            clsNodo Aux = Primero;
            cmbCodigo.Items.Clear();
            while (Aux != null)
            {
                cmbCodigo.Items.Add(Aux.Tramite);
                Aux = Aux.Siguiente;
            }

        }


    }
}
