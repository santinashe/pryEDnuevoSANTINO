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
    public partial class frmDoblementeEnlazada : Form
    {
        public frmDoblementeEnlazada()
        {
            InitializeComponent();
        }
       
        private void frmDoblementeEnlazada_load (object sender, EventArgs e)
        {
            clsArchivo x = new clsArchivo();
            

        }




        clsListaDoble ObjDoble = new clsListaDoble();
        private void btnAgregar_Click1(object sender, EventArgs e)
        {
            
        }

        private void btnGrabaar_Click(object sender, EventArgs e)
        {
            clsNodo x = new clsNodo();
            x.Codigo = Convert.ToInt32(txtCodigo.Text);
            x.Nombre = txtNombre.Text;
            x.Tramite = txtTramite.Text;

            ObjDoble.Agregar(x);
            ObjDoble.Recorrer(dgvDoble);
            //Esto no es necesario pero se hrealiza para ver si funciona el programa y el método
            ObjDoble.Recorrer("ListaDoble.csv");
            ObjDoble.Recorrer(lstDoble);
            ObjDoble.Recorrer(cmbCodigo);


            //Limpio los controles
            txtCodigo.Clear();
            txtNombre.Clear();
            txtTramite.Clear();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ObjDoble.Eliminar( Convert.ToInt32(cmbCodigo.Text));
           
            ObjDoble.Recorrer(dgvDoble);
            ObjDoble.Recorrer("ListaDoble.csv");
            ObjDoble.Recorrer(lstDoble);
            ObjDoble.Recorrer(cmbCodigo);



            txtCodigo.Clear();
            txtTramite.Clear(); 
            txtNombre.Clear();  

        }

        private void cmbCodigo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
    
