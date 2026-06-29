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
            
            btnEliminar.Enabled = false;
            
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

            if (objArbol.Existe(x.Codigo) == true)
            {
                MessageBox.Show("El código ingresado ya existe.");
                return;
            }

            objArbol.Agregar(x);

            ActualizarPantalla();

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
            ActualizarPantalla();
        }

        private void ActualizarPantalla()
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

            if (cmbArbol.Items.Count > 0)
            {
                cmbArbol.SelectedIndex = 0;
            }
            else
            {
                cmbArbol.Text = "";
            }

            // Muestra el árbol en el TreeView.
            objArbol.Recorrer(treeArbol);

            objArbol.Recorrer("Arbol.csv");

            btnEliminar.Enabled = cmbArbol.Items.Count > 0;
        }

        private void btnEquilibrar_Click(object sender, EventArgs e)
        {
            // Uso la sobrecarga que pasa los datos del árbol a un vector.
            clsNodo[] Vector = objArbol.RecorrerVector();

            objArbol.Equilibrar();

            ActualizarPantalla();

            MessageBox.Show("El árbol fue equilibrado. Cantidad de elementos: " + Vector.Length);
        }
        private void optin_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (cmbArbol.SelectedIndex == -1 || cmbArbol.Text == "")
            {
                MessageBox.Show("Debe seleccionar un nodo.");
                return;
            }

            objArbol.Eliminar(
               Convert.ToInt32(
               cmbArbol.Text));

            ActualizarPantalla();
        }
    }
    
}


       
