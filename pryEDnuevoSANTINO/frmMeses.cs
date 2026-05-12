using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static pryEDnuevoSANTINO.clsArchivoTexto;

namespace pryEDnuevoSANTINO
{
    public partial class frmMeses : Form
    {
        public frmMeses()
        {
            InitializeComponent();
        }

    
        

        

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            clsArchivo x = new clsArchivo();
            x.NombreArc = ("Meses.csv");
            x.Grabar(txtNombre.Text);
            x.Recorrer(lstMeses);

            txtNombre.Text = "";
        }
        private void frmMeses_Load(object sender, EventArgs e)
        {
            btnGrabar.Enabled = false;
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
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
            clsArchivo x = new clsArchivo();
            x.NombreArc = ("Meses.csv");
            x.LimpiarTodo();
            x.Recorrer(lstMeses);

            txtNombre.Text = "";
        }

        private void btnListarM_Click(object sender, EventArgs e)
        {
            clsArchivo x = new clsArchivo();
            x.NombreArc = ("Meses.csv");
            x.Recorrer(lstMeses);
        }

        

        

        private void lstMeses_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            clsArchivo x = new clsArchivo();
            x.NombreArc = ("Meses.csv");
            x.LimpiarTodo();
            x.Recorrer(lstMeses);

            txtNombre.Text = "";
        }
    }
}
