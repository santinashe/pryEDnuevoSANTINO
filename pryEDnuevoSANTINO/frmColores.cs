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
    public partial class frmColores : Form
    {
        public frmColores()
        {
            InitializeComponent();
        }

        
        private void btnGrabarC_Click(object sender, EventArgs e)
        {
            clsArchivo x = new clsArchivo();
            x.NombreArc = ("Colores.csv");
            x.Grabar(txtNombre.Text);
            x.Recorrer(lstColores);

            txtNombre.Text = "";
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                btnGrabarC.Enabled = false;
            }
            else
            {
                btnGrabarC.Enabled = true;
            }
        }

        private void frmColores_Load(object sender, EventArgs e)
        {
            btnGrabarC.Enabled = false;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            clsArchivo x = new clsArchivo();
            x.NombreArc = ("Careras.csv");
            x.LimpiarTodo();
            x.Recorrer(lstColores);

            txtNombre.Text = "";
        }

        private void btnListarC_Click(object sender, EventArgs e)
        {
            clsArchivo x = new clsArchivo();
            x.NombreArc = ("Colores.csv");
            x.Recorrer(lstColores);
        }
    }
 }

