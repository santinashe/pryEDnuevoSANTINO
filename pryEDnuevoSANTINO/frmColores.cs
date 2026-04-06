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
    public partial class frmColores : Form
    {
        public frmColores()
        {
            InitializeComponent();
        }

        private void btnGrabarC_Click(object sender, EventArgs e)
        {
            
           
            clsArchivoTexto x = new clsArchivoTexto();
            x.NomArchi = "Colores.csv";
            x.grabar(txtNombre.Text);
            x.Recorrer(lstColores);

            txtNombre.Text = "";

        }
    }
}
