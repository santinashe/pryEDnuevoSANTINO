using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryEDnuevoSANTINO
{
    internal class clsNodo
    {
        //Campos del nodo
        private Int32 Cod;
        private string Nom;
        private string Tra;
        private clsNodo Sig;
        private clsNodo Ant;
        private clsNodo izq;
        private clsNodo der;
        //Propiedades del nodo
        public Int32 Codigo
        {
            get { return Cod; }
            set { Cod = value; }
        }

        public string Nombre
        {
            get { return Nom; }
            set { Nom = value; }
        }

        public string Tramite
        {
            get { return Tra; }
            set { Tra = value; }
        }

        public clsNodo Siguiente
        {
            get { return Sig; }
            set { Sig = value; }
        }
        public clsNodo Anterior
        {
            get { return Ant; }
            set { Ant = value; }
        }
        public clsNodo Izquierda
        {
            get { return izq; }
            set { izq = value; }
        }
        public clsNodo Derecha
        {
            get { return der; }
            set { der = value; }
        }
    }
}
