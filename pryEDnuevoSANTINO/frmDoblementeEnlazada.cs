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
        clsListaDoble ObjDoble = new clsListaDoble();
        private bool escondendoEvents = false; // Flag para evitar eventos recursivos

        public frmDoblementeEnlazada()
        {
            InitializeComponent();
        }
       
        private void frmDoblementeEnlazada_load (object sender, EventArgs e)
        {
            clsArchivo x = new clsArchivo();
            
            // Suscribirse a los eventos CheckedChanged de los RadioButtons
            optAscendente.CheckedChanged += OptOrdenamiento_CheckedChanged;
            optDescendente.CheckedChanged += OptOrdenamiento_CheckedChanged;

            // Establecer valor por defecto: ascendente
            optAscendente.Checked = true;
        }

        private void btnGrabaar_Click(object sender, EventArgs e)
        {
            clsNodo x = new clsNodo();
            x.Codigo = Convert.ToInt32(txtCodigo.Text);
            x.Nombre = txtNombre.Text;
            x.Tramite = txtTramite.Text;

            ObjDoble.Agregar(x);
            
            // Recargar datos con ordenamiento actual
            ActualizarVistaConOrdenamiento();

            //Limpio los controles
            txtCodigo.Clear();
            txtNombre.Clear();
            txtTramite.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (cmbCodigo.Items.Count == 0)
            {
                MessageBox.Show("No hay elementos para eliminar", "Advertencia");
                return;
            }

            ObjDoble.Eliminar(Convert.ToInt32(cmbCodigo.Text));
            
            // Recargar datos con ordenamiento actual
            ActualizarVistaConOrdenamiento();

            txtCodigo.Clear();
            txtTramite.Clear(); 
            txtNombre.Clear();  
        }

        /// <summary>
        /// Evento de cambio en los RadioButtons de ordenamiento
        /// </summary>
        private void OptOrdenamiento_CheckedChanged(object sender, EventArgs e)
        {
            // Evitar procesamiento múltiple
            if (escondendoEvents)
                return;

            ActualizarVistaConOrdenamiento();
        }

        /// <summary>
        /// Actualiza la vista (DataGridView y ListBox) según el ordenamiento seleccionado
        /// </summary>
        private void ActualizarVistaConOrdenamiento()
        {
            // Validar que la lista no esté vacía
            if (ObjDoble.Primero == null)
            {
                dgvDoble.Rows.Clear();
                lstDoble.Items.Clear();
                return;
            }

            try
            {
                // Determinar si debe ser ascendente o descendente
                bool esAscendente = optAscendente.Checked;

                // Recargar datos ordenados en DataGridView y ListBox
                ObjDoble.RecorrerOrdenado(dgvDoble, esAscendente);
                ObjDoble.RecorrerOrdenado(lstDoble, esAscendente);

                // Recargar ComboBox (sin ordenamiento, solo referencia)
                ObjDoble.Recorrer(cmbCodigo);

                // Grabar en archivo
                ObjDoble.Recorrer("ListaDoble.csv");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar vista: {ex.Message}", "Error");
            }
        }

        private void cmbCodigo_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Lógica futura si es necesaria
        }

        private void gbDatos_Enter(object sender, EventArgs e)
        {

        }

        private void dgvDoble_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
