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
    public partial class frmMeses : Form
    {
        public frmMeses()
        {
            InitializeComponent();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            clsArchivoTexto x = new clsArchivoTexto();
            x.NomArchi = "Meses.txt";
            x.grabar(txtNombre.Text);
            x.Recorrer(lstMeses);

            txtNombre.Text = "";

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

        private void frmMeses_Load(object sender, EventArgs e)
        {
            btnGrabar.Enabled = false;
        }
    }
}
