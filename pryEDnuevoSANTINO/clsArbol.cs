using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEDnuevoSANTINO
{


    internal class clsArbol
    {
        // Campo principal del árbol. Este nodo representa la raíz.
        private clsNodo PrimerNodo;

        public clsNodo Raiz
        {
            get { return PrimerNodo; }
            set { PrimerNodo = value; }
        }

        // Método para agregar un nodo al árbol binario.
        public void Agregar(clsNodo nuevo)
        {
            // Limpio los enlaces del nodo para evitar errores.
            nuevo.Izquierda = null;
            nuevo.Derecha = null;

            if (Raiz == null)
            {
                PrimerNodo = nuevo;
            }
            else
            {
                clsNodo Ant = Raiz;
                clsNodo Aux = Raiz;

                while (Aux != null)
                {
                    Ant = Aux;

                    if (nuevo.Codigo < Aux.Codigo)
                    {
                        Aux = Aux.Izquierda;
                    }
                    else
                    {
                        Aux = Aux.Derecha;
                    }
                }

                if (nuevo.Codigo < Ant.Codigo)
                {
                    Ant.Izquierda = nuevo;
                }
                else
                {
                    Ant.Derecha = nuevo;
                }
            }
        }

        public Boolean Existe(Int32 Codigo)
        {
            clsNodo Aux = Raiz;

            while (Aux != null)
            {
                if (Codigo == Aux.Codigo)
                {
                    return true;
                }

                if (Codigo < Aux.Codigo)
                {
                    Aux = Aux.Izquierda;
                }
                else
                {
                    Aux = Aux.Derecha;
                }
            }

            return false;
        }

        // Recorrido por defecto para la grilla: InOrden.
        public void Recorrer(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            InOrdenAsc(Grilla, Raiz);
        }
        public void Recorrer(string NomArchi)
        {
            StreamWriter AD = new StreamWriter(NomArchi, false);

            GuardarArchivo(Raiz, AD);

            AD.Close();
        }
        private void GuardarArchivo(clsNodo aux, StreamWriter AD)
        {
            if (aux != null)
            {
                GuardarArchivo(aux.Izquierda, AD);

                AD.Write(aux.Codigo);
                AD.Write(";");

                AD.Write(aux.Nombre);
                AD.Write(";");

                AD.WriteLine(aux.Tramite);

                GuardarArchivo(aux.Derecha, AD);
            }
        }

        // Sobrecarga para elegir recorrido: InOrden, PreOrden o PostOrden.
        public void Recorrer(DataGridView Grilla, string orden)
        {
            Grilla.Rows.Clear();

            if (orden == "PreOrden")
            {
                PreOrden(Grilla, Raiz);
            }
            else if (orden == "PostOrden")
            {
                PostOrden(Grilla, Raiz);
            }
            else
            {
                InOrdenAsc(Grilla, Raiz);
            }
        }

        // SOBRECARGA DEL INORDEN PARA CARGAR EL COMBOBOX cmbCodigo.
        public void Recorrer(ComboBox Combo)
        {
            Combo.Items.Clear();
            InOrdenAsc(Combo, Raiz);
        }

        // SOBRECARGA DEL INORDEN PARA PASAR LOS DATOS A UN VECTOR.
        public clsNodo[] RecorrerVector()
        {
            clsNodo[] Vector = new clsNodo[ContarNodos(Raiz)];
            Int32 Indice = 0;

            InOrdenAsc(Vector, ref Indice, Raiz);

            return Vector;
        }

        // Otra sobrecarga para cargar un vector ya creado desde afuera.
        public void Recorrer(clsNodo[] Vector, ref Int32 Indice)
        {
            Indice = 0;
            InOrdenAsc(Vector, ref Indice, Raiz);
        }

        // INORDEN PARA GRILLA.
        // Recorre: Izquierdo - Raíz - Derecho.
        private void InOrdenAsc(DataGridView Dgv, clsNodo R)
        {
            if (R != null)
            {
                InOrdenAsc(Dgv, R.Izquierda);

                Dgv.Rows.Add(R.Codigo, R.Nombre, R.Tramite);

                InOrdenAsc(Dgv, R.Derecha);
            }
        }

        // INORDEN PARA COMBOBOX.
        // Carga solamente los códigos en cmbCodigo.
        private void InOrdenAsc(ComboBox Combo, clsNodo R)
        {
            if (R != null)
            {
                InOrdenAsc(Combo, R.Izquierda);

                Combo.Items.Add(R.Codigo);

                InOrdenAsc(Combo, R.Derecha);
            }
        }

        // INORDEN PARA VECTOR.
        // Guarda los nodos ordenados por código dentro de un vector.
        private void InOrdenAsc(clsNodo[] Vector, ref Int32 Indice, clsNodo R)
        {
            if (R != null)
            {
                InOrdenAsc(Vector, ref Indice, R.Izquierda);

                if (Indice < Vector.Length)
                {
                    clsNodo Nuevo = new clsNodo();

                    Nuevo.Codigo = R.Codigo;
                    Nuevo.Nombre = R.Nombre;
                    Nuevo.Tramite = R.Tramite;

                    Vector[Indice] = Nuevo;
                    Indice++;
                }

                InOrdenAsc(Vector, ref Indice, R.Derecha);
            }
        }

        // PREORDEN PARA GRILLA.
        // Recorre: Raíz - Izquierda - Derecha.
        private void PreOrden(DataGridView Dgv, clsNodo R)
        {
            if (R != null)
            {
                Dgv.Rows.Add(R.Codigo, R.Nombre, R.Tramite);

                PreOrden(Dgv, R.Izquierda);
                PreOrden(Dgv, R.Derecha);
            }
        }

        // POSTORDEN PARA GRILLA.
        // Recorre: Izquierdo - Derecho - Raíz.
        private void PostOrden(DataGridView Dgv, clsNodo R)
        {
            if (R != null)
            {
                PostOrden(Dgv, R.Izquierda);
                PostOrden(Dgv, R.Derecha);

                Dgv.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
            }
        }

        // Recorrido para mostrar el árbol en el TreeView.
        public void Recorrer(TreeView tree)
        {
            tree.Nodes.Clear();

            if (Raiz != null)
            {
                TreeNode NodoVich = new TreeNode("Árbol");
                tree.Nodes.Add(NodoVich);

                PreOrden(Raiz, NodoVich);

                tree.ExpandAll();
            }
        }

        // PREORDEN PARA TREEVIEW.
        private void PreOrden(clsNodo R, TreeNode nodoTreeView)
        {
            if (R != null)
            {
                TreeNode NodoVich = new TreeNode(R.Codigo.ToString());
                nodoTreeView.Nodes.Add(NodoVich);

                PreOrden(R.Izquierda, NodoVich);
                PreOrden(R.Derecha, NodoVich);
            }
        }


        public void Eliminar(int Codigo)
        {
            Raiz = EliminarNodo(Raiz, Codigo);
        }

        private clsNodo EliminarNodo(clsNodo aux, int Codigo)
        {
            if (aux == null)
            {
                return null;
            }

            if (Codigo < aux.Codigo)
            {
                aux.Izquierda =
                    EliminarNodo(
                    aux.Izquierda,
                    Codigo);
            }
            else
            {
                if (Codigo > aux.Codigo)
                {
                    aux.Derecha =
                        EliminarNodo(
                        aux.Derecha,
                        Codigo);
                }
                else
                {
                    if (aux.Izquierda == null)
                    {
                        return aux.Derecha;
                    }

                    if (aux.Derecha == null)
                    {
                        return aux.Izquierda;
                    }

                    clsNodo menor = aux.Derecha;

                    while (menor.Izquierda != null)
                    {
                        menor = menor.Izquierda;
                    }

                    aux.Codigo = menor.Codigo;
                    aux.Nombre = menor.Nombre;
                    aux.Tramite = menor.Tramite;

                    aux.Derecha =
                        EliminarNodo(
                        aux.Derecha,
                        menor.Codigo);
                }
            }

                     return aux;
        }

        // Cuenta la cantidad de nodos para poder crear el vector.
        private Int32 ContarNodos(clsNodo R)
        {
            if (R == null)
            {
                return 0;
            }
            else
            {
                return 1 + ContarNodos(R.Izquierda) + ContarNodos(R.Derecha);
            }
        }
        public void Equilibrar()
        {
            List<clsNodo> Lista = new List<clsNodo>();

            CargarLista(Raiz, Lista);

            Raiz = Balancear(
           Lista,
           0,
           Lista.Count - 1);
        }


        private void CargarLista(clsNodo aux, List<clsNodo> Lista)
        {
            if (aux != null)
            {
                CargarLista(aux.Izquierda, Lista);

                clsNodo x = new clsNodo();

                x.Codigo = aux.Codigo;
                x.Nombre = aux.Nombre;
                x.Tramite = aux.Tramite;

                Lista.Add(x);

                CargarLista(aux.Derecha, Lista);
            }
        }

        private clsNodo Balancear(List<clsNodo> Lista, int Inicio, int Fin)
        {
            if (Inicio > Fin)
            {
                return null;
            }

            int Medio = (Inicio + Fin) / 2;

            clsNodo aux = Lista[Medio];

            aux.Izquierda =
                Balancear(
                Lista,
                Inicio,
                Medio - 1);

            aux.Derecha =
                Balancear(
                Lista,
                Medio + 1,
                Fin);

            return aux;
        }


    }

}
