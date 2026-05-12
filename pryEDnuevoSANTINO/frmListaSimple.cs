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

       clsListaSimple objListaSimple = new clsListaSimple();    
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo n = new clsNodo();
            n.Codigo = Convert.ToInt32(txtCodigo.Text);
            n.Nombre = txtNombre.Text;
            n.Tramite = txtTramite.Text;

            objListaSimple.Agregar(n);
            objListaSimple.Recorrer(dgvSimple);
            objListaSimple.Recorrer(lstLista);
            objListaSimple.Recorrer(cmbCodigo);
            //objListaSimple.Recorrer("ListaSimple.csv");


            txtCodigo.Clear();
            txtNombre.Clear();
            txtTramite.Clear();


        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
           if (cmbCodigo.Text == "")
            {
                MessageBox.Show("Seleccione un código para eliminar.");
                return;
            }   
            objListaSimple.Eliminar(Convert.ToInt32(cmbCodigo.Text));
            objListaSimple.Recorrer(dgvSimple);
            objListaSimple.Recorrer(lstLista);
            objListaSimple.Recorrer(cmbCodigo);
            cmbCodigo.Text = "";
            //objListaSimple.Recorrer("ListaSimple.csv");
        }

        private void gbNuevo_Enter(object sender, EventArgs e)
        {

        }

        private void frmListaSimple_Load(object sender, EventArgs e)
        {

        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
    
    
}
