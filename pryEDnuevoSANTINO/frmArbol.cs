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
            
            // Dejo InOrden seleccionado por defecto.
            optin.Checked = true;

            // Conecto los botones y radios desde código.
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

            clsNodo n = new clsNodo();

            n.Codigo = Convert.ToInt32(txtCodigo.Text);
            n.Nombre = txtNombre.Text;
            n.Tramite = txtTramite.Text;

            objArbol.Agregar(n);

            MostrarArbol();

            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";

            txtCodigo.Focus();
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
            objArbol.Recorrer(cmbCodigo);

            // Muestra el árbol en el TreeView.
            objArbol.Recorrer(treeView1);
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
    }
}


       