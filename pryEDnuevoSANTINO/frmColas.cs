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
        clsCola fila = new clsCola();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // placeholder: agregar lógica para encolar elemento
            clsNodo n = new clsNodo();
                n.Codigo = Convert.ToInt32(txtCodigo.Text);
                n.Nombre = txtNombre.Text;
                n.Tramite = txtTramite.Text;
               
           fila.Agregar(n);
           fila.Recorrer(dgvCola);
           fila.Recorrer(lstCola);


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
            if (fila.Primero != null)
            { 
                fila.Eliminar();
                fila.Recorrer(dgvCola);
                fila.Recorrer(lstCola);
            }
            else
            {
                MessageBox.Show("La cola está vacía. No hay elementos para eliminar.");


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
