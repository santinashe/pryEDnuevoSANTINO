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

namespace pryEDnuevoSANTINO
{
    public partial class frmPRINCIPAL : Form
    {
        public frmPRINCIPAL()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void datosDelDesarrolladorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDatosDelDesarrollador v = new frmDatosDelDesarrollador();
            v.ShowDialog();
        }

        private void coloresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmColores v = new frmColores();
            v.ShowDialog();
        }

        private void mesesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMeses v = new frmMeses();
            v.ShowDialog();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientes v = new frmClientes();
            v.ShowDialog();
        }

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAlumnos v = new frmAlumnos();
            v.ShowDialog(); 
        }

        private void frmPRINCIPAL_Load(object sender, EventArgs e)
        {

        }
      

        private void carrerasToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmCarreras v = new frmCarreras();
            v.ShowDialog();
        }
        public void frmPRINCIPAL_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void colaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmColas v = new frmColas ();    
            v.ShowDialog();
        }

        private void pilaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPila v = new frmPila();  
            v.ShowDialog();
        }

        private void listaSimpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaSimple v = new frmListaSimple();
            v.ShowDialog();
        }

        private void listaDobleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDoblementeEnlazada   v = new frmDoblementeEnlazada();    
            v.ShowDialog(); 
        }

        private void arbolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmArbol v = new frmArbol();
            v.ShowDialog(); 
        }

        private void grafoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGrafo v = new frmGrafo();   
            v.ShowDialog();
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsulta v = new frmConsulta();
            v.ShowDialog();
        }

        private void consultaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
           
        }

        private void baseDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void baseDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void consultaToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            
        }

        private void consultaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsulta v = new frmConsulta();
            v.ShowDialog();
        }
    }
}
