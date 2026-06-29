using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace pryEDnuevoSANTINO
{
    public partial class frmArbol : Form
    {
       clsArbol objArbol = new clsArbol();
        public frmArbol()
        {
            InitializeComponent();
            
            //  InOrden seleccionado por defecto.
            optin.Checked = true;

            // los botones y radios desde código.
            btnGrabaar.Click += btnAgregar_Click;
            optin.CheckedChanged += optOrden_CheckedChanged;
            optPre.CheckedChanged += optOrden_CheckedChanged;
            optPost.CheckedChanged += optOrden_CheckedChanged;
            btnEquilibrar.Click += btnEquilibrar_Click;
            
            
        }
      
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "" || txtNombre.Text == "" || txtTramite.Text == "")
            {
                MessageBox.Show("Debe completar todos los datos.");
                return;
            }

            clsNodo x = new clsNodo();

            x.Codigo = Convert.ToInt32(txtCodigo.Text);
            x.Nombre = txtNombre.Text;
            x.Tramite = txtTramite.Text;

            objArbol.Agregar(x);

            objArbol.Recorrer(dgvArbol);
            objArbol.Recorrer(cmbArbol);
            objArbol.Recorrer("Arbol.csv");

            CargarTree();

            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";
        }

        private void optOrden_CheckedChanged(object sender, EventArgs e)
        {
            MostrarArbol();
        }

        private void MostrarArbol()
        {
            if (optPre.Checked == true)
            {
                objArbol.Recorrer(dgvArbol, "PreOrden");
            }
            else if (optPost.Checked == true)
            {
                objArbol.Recorrer(dgvArbol, "PostOrden");
            }
            else
            {
                objArbol.Recorrer(dgvArbol, "InOrden");
            }

            // Carga el ComboBox cmbCodigo usando InOrden.
            objArbol.Recorrer(cmbArbol);

            // Muestra el árbol en el TreeView.
            objArbol.Recorrer(treeArbol);
        }

        private void btnEquilibrar_Click(object sender, EventArgs e)
        {
            // Uso la sobrecarga que pasa los datos del árbol a un vector.
            clsNodo[] Vector = objArbol.RecorrerVector();

            MessageBox.Show("Los datos del árbol fueron pasados a un vector. Cantidad de elementos: " + Vector.Length);
        }
        private void optin_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void CargarNodos(clsNodo aux, TreeNode nodo)
        {
            if (aux.Izquierda != null)
            {
                TreeNode izq =
                    new TreeNode(
                    aux.Izquierda.Codigo.ToString());

                nodo.Nodes.Add(izq);

                CargarNodos(
                    aux.Izquierda,
                    izq);
            }

            if (aux.Derecha != null)
            {
                TreeNode der =
                    new TreeNode(
                    aux.Derecha.Codigo.ToString());

                nodo.Nodes.Add(der);

                CargarNodos(
                    aux.Derecha,
                    der);
            }
        }
        private void CargarTree()
        {
            treeArbol.Nodes.Clear();

            if (objArbol.Raiz != null)
            {
                TreeNode raiz =
                    new TreeNode(
                    objArbol.Raiz.Codigo.ToString());

                treeArbol.Nodes.Add(raiz);

                CargarNodos(
                    objArbol.Raiz,
                    raiz);
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {

            objArbol.Eliminar(
               Convert.ToInt32(
               cmbArbol.Text));

            objArbol.Recorrer(dgvArbol);
            objArbol.Recorrer(cmbArbol);
            objArbol.Recorrer("Arbol.csv");

            CargarTree();

            btnEliminar.Enabled = false;
        }
    }
    
}


       