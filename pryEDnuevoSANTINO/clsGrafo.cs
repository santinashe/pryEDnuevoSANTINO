using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEDnuevoSANTINO
{

    internal class clsGrafo
    {
        private string[] Ciudades = new string[5] { "Buenos Aires", "Cordoba", "Santa Fe", "Mendoza", "La Plata" };
        private decimal[,] Precio = new decimal[5, 5];
        public void Agregar(int f, int c, decimal p)
        {
            Precio[f, c] = p;


        }
        public void eliminar(int f, int c)
        {
            Precio[f, c] = 0;
        }
        public decimal Consultar(int f, int c)
        {
            return Precio[f, c];

        }
        public void Borrar()
        {
            for (int f = 0; f < 5; f++)
            {
                for (int c = 0; c < 5; c++)
                {
                    Precio[f, c] = 0;
                }
            }
        }
        public void MostrarOrigenes(Int32 c, DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            Grilla.Columns.Clear();

            // Agregar columnas manualmente
            Grilla.Columns.Add("Col1", "Origen");
            Grilla.Columns.Add("Col2", "Precio");

            Grilla.Columns[0].Width = 200;
            Grilla.Columns[1].Width = 200;

            for (Int32 f = 0; f < 5; f++)
            {
                if (Precio[f, c] > 0)
                {
                    Grilla.Rows.Add(Ciudades[f], Precio[f, c]);
                }
            }
        }
        public void MostrarTodo(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            Grilla.Columns.Clear();

            // Agregar columnas manualmente
            Grilla.Columns.Add("NomOrigen", "Origen");

            for (Int32 i = 0; i < 5; i++)
            {
                Grilla.Columns.Add("Destino" + i.ToString(), Ciudades[i]);
            }

            for (Int32 f = 0; f < 5; f++)
            {
                Grilla.Rows.Add(Ciudades[f]);

                for (Int32 c = 0; c < 5; c++)
                {
                    Grilla.Rows[f].Cells[c + 1].Value = Precio[f, c];
                }
            }
        }
        public void MostrarDestinos(Int32 f, DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            Grilla.Columns.Clear();

            // Agregar columnas manualmente
            Grilla.Columns.Add("Col1", "Destino");
            Grilla.Columns.Add("Col2", "Precio");

            Grilla.Columns[0].Width = 200;
            Grilla.Columns[1].Width = 200;

            Grilla.Rows.Clear();

            for (Int32 c = 0; c < 5; c++)
            {
                if (Precio[f, c] > 0)
                {
                    Grilla.Rows.Add(Ciudades[c], Precio[f, c]);
                }
            }
        }
    }
   
}    