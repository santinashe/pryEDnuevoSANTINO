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
            clsArchivoTexto X = new clsArchivoTexto();  
            X.grabar(txtNombreC.Text);
        }
    }
}
