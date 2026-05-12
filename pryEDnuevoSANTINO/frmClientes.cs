using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static pryEDnuevoSANTINO.clsArchivoTexto;

namespace pryEDnuevoSANTINO
{
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }


        clsArchivo objRecorrer = new clsArchivo();
        private void btnGrabar_Click(object sender, EventArgs e)
        {
            
            objRecorrer.NombreArc = "Clientes.csv";
            objRecorrer.Grabar(txtCodigo.Text, txtNombre.Text, txtDeuda.Text);
            objRecorrer.Recorrer(dgvDatos);
                


        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            clsArchivo x = new clsArchivo();
            x.NombreArc = "Clientes.csv";
            if (File.Exists(x.NombreArc)) x.Recorrer(dgvDatos);
            
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            if (txtNombre.Text != "" && txtNombre.Text != "" && txtDeuda.Text != "")
            {
                btnGrabar.Enabled = false;
            }
            else
            {
                btnGrabar.Enabled = true;
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
        
           
        }

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            clsArchivo x = new clsArchivo();
            x.NombreArc = ("Clientes.csv");
            x.LimpiarTodo();
            //x.Recorrer();
        }
    }
}
    

