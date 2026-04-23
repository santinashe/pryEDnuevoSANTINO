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
    public partial class frmPila : Form
    {
        public frmPila()
        {
            InitializeComponent();
        }

        private void pbImagen_Click(object sender, EventArgs e)
        {

        }

        private void lstCola_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblListado_Click(object sender, EventArgs e)
        {

        }

        private void gbEliminado_Enter(object sender, EventArgs e)
        {

        }

        private void gbNuevo_Enter(object sender, EventArgs e)
        {

        }

        private void dgvCola_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        clsPila pila = new clsPila();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo n = new clsNodo();
            n.Codigo = Convert.ToInt32(txtCodigo.Text);
            n.Nombre = txtNombre.Text;
            n.Tramite = txtTramite.Text;

            pila.Agregar(n);
            pila.Recorrer(dgvDatos);
            pila.Recorrer(lstDatos);


            txtCodigo.Clear();
            txtNombre.Clear();
            txtTramite.Clear();


        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("¿Desea eliminar el primer elemento de la cola?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
            if (MessageBox.Show("¿Desea eliminar el primer elemento de la cola?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                lblCodigoEliminado.Text = pila.Primero.Codigo.ToString();
                lblNombreEliminado.Text = pila.Primero.Nombre;
                lblTramiteEliminado.Text = pila.Primero.Tramite;
                // Eliminar el primer nodo
                pila.Eliminar();
                // Actualizar la grilla y la lista
                pila.Recorrer(dgvDatos);
                pila.Recorrer(lstDatos);
                pila.Recorrer();
            }


            if (pila.Primero != null)
            {
                pila.Eliminar();
                pila.Recorrer(dgvDatos);
                pila.Recorrer(lstDatos);
            }
            
            if (pila.Primero != null)
            {
               // MessageBox.Show("¿Desea eliminar el primer elemento de la pila?", "Eliminar", MessageBoxButtons.YesNo);

                lblCodigoEliminado.Text = pila.Primero.Codigo.ToString();
                lblNombreEliminado.Text = pila.Primero.Nombre;
                lblTramiteEliminado.Text = pila.Primero.Tramite;

                // Eliminar el primer nodo
                pila.Eliminar();

                // Actualizar la grilla y la lista
                pila.Recorrer(dgvDatos);
                pila.Recorrer(lstDatos);
                pila.Recorrer();
            }
            else
            {
                lblCodigoEliminado.Text = "";
                lblNombreEliminado.Text = "";
                lblTramiteEliminado.Text = "";
            }          


        }
    }
}
