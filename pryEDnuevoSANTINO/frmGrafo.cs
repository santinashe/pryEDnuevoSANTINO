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
    public partial class frmGrafo : Form
    {
        // Instancia de la clase Grafo
        private clsGrafo grafo = new clsGrafo();
        
        // Array de ciudades para los ComboBox
        private string[] ciudades = new string[5] { "Buenos Aires", "Cordoba", "Santa Fe", "Mendoza", "La Plata" };

        public frmGrafo()
        {
            InitializeComponent();
        }

        // Evento Load del formulario
        private void frmGrafo_Load(object sender, EventArgs e)
        {
            CargarComboBox();
        }

        // Cargar los ComboBox con las ciudades
        private void CargarComboBox()
        {
            // Limpiar los ComboBox
            cmbOrigen.Items.Clear();
            cmbDestino.Items.Clear();
            cmbOrigen2.Items.Clear();
            cmbDestino2.Items.Clear();
            cmbDesde.Items.Clear();
            cmbHasta.Items.Clear();

            // Agregar ciudades a todos los ComboBox
            foreach (string ciudad in ciudades)
            {
                cmbOrigen.Items.Add(ciudad);
                cmbDestino.Items.Add(ciudad);
                cmbOrigen2.Items.Add(ciudad);
                cmbDestino2.Items.Add(ciudad);
                cmbDesde.Items.Add(ciudad);
                cmbHasta.Items.Add(ciudad);
            }

            // Establecer el primer item como seleccionado
            cmbOrigen.SelectedIndex = 0;
            cmbDestino.SelectedIndex = 1;
            cmbOrigen2.SelectedIndex = 0;
            cmbDestino2.SelectedIndex = 1;
            cmbDesde.SelectedIndex = 0;
            cmbHasta.SelectedIndex = 1;
        }

        // Obtener el índice de una ciudad
        private int ObtenerIndiceCiudad(string ciudad)
        {
            for (int i = 0; i < ciudades.Length; i++)
            {
                if (ciudades[i] == ciudad)
                {
                    return i;
                }
            }
            return -1;
        }

        // Botón Cargar - Agregar un viaje al grafo
        private void btnCagar_Click(object sender, EventArgs e)
        {
            try
            {
                int origen = ObtenerIndiceCiudad(cmbOrigen2.SelectedItem.ToString());
                int destino = ObtenerIndiceCiudad(cmbDestino2.SelectedItem.ToString());
                decimal precio = decimal.Parse(mskPrecio2.Text);

                if (origen == destino)
                {
                    MessageBox.Show("El origen y destino no pueden ser iguales", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (precio <= 0)
                {
                    MessageBox.Show("El precio debe ser mayor a 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                grafo.Agregar(origen, destino, precio);
                MessageBox.Show("Viaje agregado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                // Limpiar campos
                mskPrecio2.Clear();
                cmbOrigen2.SelectedIndex = 0;
                cmbDestino2.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el viaje: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Botón Borrar Todo - Limpiar todos los datos del grafo
        private void btnBorrarTodo_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Desea borrar todos los datos?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (resultado == DialogResult.Yes)
            {
                grafo.Borrar();
                dgvGrafo.Rows.Clear();
                MessageBox.Show("Todos los datos han sido borrados", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Botón Consultar - Buscar un viaje específico
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                int origen = ObtenerIndiceCiudad(cmbOrigen.SelectedItem.ToString());
                int destino = ObtenerIndiceCiudad(cmbDestino.SelectedItem.ToString());

                decimal precio = grafo.Consultar(origen, destino);

                if (precio > 0)
                {
                    MessageBox.Show($"Precio de {cmbOrigen.SelectedItem} a {cmbDestino.SelectedItem}: ${precio}", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No existe viaje entre estas ciudades", "No encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Botón Borrar - Eliminar un viaje específico
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                int origen = ObtenerIndiceCiudad(cmbOrigen.SelectedItem.ToString());
                int destino = ObtenerIndiceCiudad(cmbDestino.SelectedItem.ToString());

                decimal precio = grafo.Consultar(origen, destino);

                if (precio > 0)
                {
                    grafo.eliminar(origen, destino);
                    MessageBox.Show("Viaje eliminado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No existe viaje entre estas ciudades", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al borrar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Botón Listar Orígenes - Mostrar todos los viajes que salen desde una ciudad
        private void btnDestinos_Click(object sender, EventArgs e)
        {
            try
            {
                int origen = ObtenerIndiceCiudad(cmbDesde.SelectedItem.ToString());
                grafo.MostrarDestinos(origen, dgvGrafo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar destinos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Botón Listar Destinos - Mostrar todos los viajes que llegan a una ciudad
        private void btnOrigenes_Click(object sender, EventArgs e)
        {
            try
            {
                int destino = ObtenerIndiceCiudad(cmbHasta.SelectedItem.ToString());
                grafo.MostrarOrigenes(destino, dgvGrafo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar orígenes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Botón Ver todos los viajes - Mostrar la matriz completa
        private void btnVerViajes_Click(object sender, EventArgs e)
        {
            try
            {
                grafo.MostrarTodo(dgvGrafo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar todos los viajes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
