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
    public partial class frmConsulta : Form
    {
        public frmConsulta()
        {
            InitializeComponent();
        }

        private void Listar_Click(object sender, EventArgs e)
        {
            clsBaseDatos db = new clsBaseDatos();
            db.Listar(dgvDatos, txtConsulta.Text);
        }

        private void txtConsulta_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmConsulta_Load(object sender, EventArgs e)
        {

        }
    }
}
