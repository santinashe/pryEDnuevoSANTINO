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
    public partial class frmColas : Form
    {
        public frmColas()
        {
            InitializeComponent();
        }

        private void frmColas_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        clsCola cola = new clsCola();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // placeholder: agregar lógica para encolar elemento
            clsNodo n = new clsNodo();
                n.Codigo = Convert.ToInt32(txtCodigo.Text);
                n.Nombre = txtNombre.Text;
                n.Tramite = txtTramite.Text;
               
           cola.Agregar(n);
           cola.Recorrer(dgvDatos);
           cola.Recorrer(lstDatos);


            txtCodigo.Clear();
            txtNombre.Clear();
            txtTramite.Clear();
                

            // agregar nodo a la cola   
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea eliminar el primer elemento de la cola?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                
            }
            if (    cola.Primero != null)
            { 
                cola.Eliminar();
                cola.Recorrer(dgvDatos);
                cola.Recorrer(lstDatos);
            }
            else
            {
                MessageBox.Show("La cola está vacía. No hay elementos para eliminar.");


            }

            // Mostrar los datos del primer nodo antes de eliminarlo
            if (cola.Primero != null)
            {
                lblCodigoEliminado.Text = cola.Primero.Codigo.ToString();
                lblNombreEliminado.Text = cola.Primero.Nombre;
                lblTramiteEliminado.Text = cola.Primero.Tramite;

                // Eliminar el primer nodo
                cola.Eliminar();

                // Actualizar la grilla y la lista
                cola.Recorrer(dgvDatos);
                cola.Recorrer(lstDatos);
                cola.Recorrer();
            }
            else
            {
                lblCodigoEliminado.Text = "";
                lblNombreEliminado.Text = "";
                lblTramiteEliminado.Text = "";
            }



            // placeholder: agregar lógica para desencolar elemento
        }

        private void txtECodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void lstCola_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
