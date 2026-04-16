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
    public partial class frmCarreras : Form
    {
        public frmCarreras()
        {
            InitializeComponent();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            clsArchivo x = new clsArchivo();
            x.NombreArc = ("Carreras.csv");
            x.Grabar(txtCarrera.Text);
            x.Recorrer(lstCarreras);

            txtCarrera.Text = "";
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            clsArchivo x = new clsArchivo();
            x.NombreArc = ("Carreras.csv");
            x.LimpiarTodo();
            x.Recorrer(lstCarreras);

            txtCarrera.Text = "";
        }

        private void txtCarreras_TextChanged(object sender, EventArgs e)
        {
            if (txtCarrera.Text == "")
            {
                btnGrabarC.Enabled = false;
            }
            else
            {
                btnGrabarC.Enabled = true;
            }
        }

        private void frmCarreras_Load(object sender, EventArgs e)
        {
            btnGrabarC.Enabled = false;
        }

        private void lstCarreras_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
