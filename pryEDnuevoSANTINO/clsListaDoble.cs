using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pryEDnuevoSANTINO;

namespace pryEDnuevoSANTINO  
{
    internal class clsListaDoble
    {
        //Formada por nodos, contienen 3 partes, los datos y el puntero del dato anterior y ultimo, se puede recorrer en ambas direcciones
        //Campos de la clase
        private clsNodo pri;
        private clsNodo ult;

        //Propiedades
        public clsNodo Primero
        {
            get { return pri; }
            set { pri = value; }
        }
        public clsNodo Ultimo
        {
            get { return ult; }
            set { ult = value; }
        }

        public void Agregar(clsNodo Nuevo)
        {
            if (Primero == null)
            {
                Primero = Nuevo;
                Ultimo = Nuevo;
            }
            else
            {
                if (Nuevo.Codigo < Primero.Codigo)
                {
                    Nuevo.Siguiente = Primero;
                    Primero.Anterior = Nuevo;
                    Primero = Nuevo;
                }
                else
                {
                    if (Nuevo.Codigo > Ultimo.Codigo)
                    {
                        Ultimo.Siguiente = Nuevo;
                        Nuevo.Anterior = Ultimo;
                        Ultimo = Nuevo;
                    }
                    else
                    {
                        clsNodo Aux = Primero;
                        clsNodo Ant = Primero;
                        while (Aux.Codigo < Nuevo.Codigo)
                        {
                            Ant = Aux;
                            Aux = Aux.Siguiente;
                            if (Aux == null)
                            {
                                break;
                            }
                        }
                        Ant.Siguiente = Nuevo;
                        Nuevo.Siguiente = Aux;
                        if (Aux != null)
                        {
                            Aux.Anterior = Nuevo;
                        }
                        Nuevo.Anterior = Ant;

                    }
                }
            }
        }
        public void Eliminar(int Codigo)
        {
            if (Primero == null) return; // Lista vacía

            clsNodo Aux = Primero;

            // 1. Buscar el nodo a eliminar
            while (Aux != null && Aux.Codigo != Codigo)
            {
                Aux = Aux.Siguiente;
            }

            // Si no se encontró el código, salimos
            if (Aux == null) return;

            // 2. Si el nodo es el PRIMERO
            if (Aux == Primero)
            {
                Primero = Aux.Siguiente;
                if (Primero != null)
                    Primero.Anterior = null;
                else
                    Ultimo = null; // La lista quedó vacía
            }
            // 3. Si el nodo es el ÚLTIMO
            else if (Aux == Ultimo)
            {
                Ultimo = Aux.Anterior;
                if (Ultimo != null)
                    Ultimo.Siguiente = null;
            }
            // 4. Si está en el MEDIO
            else
            {
                // El truco de la "puenteada"
                Aux.Anterior.Siguiente = Aux.Siguiente;
                Aux.Siguiente.Anterior = Aux.Anterior;
            }
        }             
            
        
        public void Recorrer(DataGridView Grilla)
        {
            clsNodo Aux = Primero;
            Grilla.Rows.Clear();
            while (Aux != null)
            {
                Grilla.Rows.Add(Aux.Codigo, Aux.Nombre, Aux.Tramite);
                Aux = Aux.Siguiente;
            }

        }
        public void Recorrer(ListBox Lista)
        {
            clsNodo Aux = Primero;
            Lista.Items.Clear();
            while (Aux != null)
            {
                Lista.Items.Add(Aux.Nombre);
                Aux = Aux.Siguiente;
            }

        }
        public void Recorrer(ComboBox Combo)
        {
            clsNodo Aux = Primero;
            Combo.Items.Clear();
            while (Aux != null)
            {
                Combo.Items.Add(Aux.Codigo);
                Aux = Aux.Siguiente;
            }

        }

        public void Recorrer(string NombreArchivo)
        {
            clsNodo Aux = Primero;
            StreamWriter AD = new StreamWriter(NombreArchivo, false, Encoding.UTF8);
            AD.WriteLine("Código; Nombre; Trámite");
            while (Aux != null)
            {
                AD.Write(Aux.Codigo);
                AD.Write(";");
                AD.Write(Aux.Nombre);
                AD.Write(";");
                AD.WriteLine(Aux.Tramite);
                Aux = Aux.Siguiente;
            }
            AD.Close();
        }

        public List<clsNodo> ObtenerListaOrdenada(bool ascendente = true)
        {
            List<clsNodo> lista = new List<clsNodo>();
            clsNodo Aux = Primero;

            // Cargar todos los nodos en una lista
            while (Aux != null)
            {
                lista.Add(Aux);
                Aux = Aux.Siguiente;
            }

            // Ordenar según el parámetro
            if (ascendente)
                lista = lista.OrderBy(n => n.Codigo).ToList();
            else
                lista = lista.OrderByDescending(n => n.Codigo).ToList();

            return lista;
        }

        public void RecorrerOrdenado(DataGridView Grilla, bool ascendente = true)
        {
            List<clsNodo> listaOrdenada = ObtenerListaOrdenada(ascendente);
            Grilla.Rows.Clear();
            foreach (clsNodo nodo in listaOrdenada)
            {
                Grilla.Rows.Add(nodo.Codigo, nodo.Nombre, nodo.Tramite);
            }
        }

        public void RecorrerOrdenado(ListBox Lista, bool ascendente = true)
        {
            List<clsNodo> listaOrdenada = ObtenerListaOrdenada(ascendente);
            Lista.Items.Clear();
            foreach (clsNodo nodo in listaOrdenada)
            {
                Lista.Items.Add(nodo.Nombre);
            }
        }
    }
}