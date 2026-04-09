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
    public partial class frmCarreras : Form
    {
        public frmCarreras()
        {
            InitializeComponent();
        }

        private void btnGrabarC_Click(object sender, EventArgs e)
        {
            clsArchivoTexto x = new clsArchivoTexto();
            x.NomArchi = "Carreras.csv";
            x.grabar(txtCarrera.Text);
            x.Recorrer(lstCarreras);    

        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            clsArchivoTexto x = new clsArchivoTexto();
            x.NomArchi = "Carreras.csv";    
            x.Recorrer(lstCarreras);
            x.Recorrer(lstCarreras);
        }
    }
}
