using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEDnuevoSANTINO
{
    public partial class frmListaSimple : Form
    {
        public frmListaSimple()
        {
            InitializeComponent();
        }

       clsListaSimple clsListaSimple = new clsListaSimple();    
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo n = new clsNodo();
            n.Codigo = Convert.ToInt32(txtCodigo.Text);
            n.Nombre = txtNombre.Text;
            n.Tramite = txtTramite.Text;

            clsListaSimple.Agregar(n);
            clsListaSimple.Recorrer(dgvSimple);
            clsListaSimple.Recorrer(lstLista);


            txtCodigo.Clear();
            txtNombre.Clear();
            txtTramite.Clear();


        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            


        }
    }
    
    
}
