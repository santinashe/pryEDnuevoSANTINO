using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

public class clsBaseDatos
{
    // Cadenas de conexión (según tu segunda captura)
    private string CadenaConexion1 = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Libreria.mdb";
    private string CadenaConexion2 = "Provider=Microsoft.Ace.OLEDB.12.0;Data Source=Libreria.mdb";

    // Supongo que tenés estas variables declaradas a nivel clase por como venía el código
    private OleDbConnection conexion = new OleDbConnection();
    private OleDbCommand comando = new OleDbCommand();
    private OleDbDataAdapter adaptador;

    // Método Listar dinámico (Primera captura)
    public void Listar(string tabla, DataGridView Grilla)
    {
        try
        {
            conexion.ConnectionString = CadenaConexion1;
            conexion.Open();

            comando.Connection = conexion;
            comando.CommandType = CommandType.TableDirect;
            comando.CommandText = tabla;

            DataSet DS = new DataSet();
            adaptador = new OleDbDataAdapter(comando);
            adaptador.Fill(DS, tabla);

            Grilla.DataSource = null;
            Grilla.DataSource = DS.Tables[tabla];

            conexion.Close();
        }
        catch (Exception e)
        {
            MessageBox.Show(e.Message);
            conexion.Close(); // Clave cerrarla acá también por si falla a mitad de camino
        }
    }
    // Este es el método de la SEGUNDA imagen, que busca siempre la tabla "Libro"
    public void Listar(DataGridView Grilla)
    {
        try
        {
            conexion.ConnectionString = CadenaConexion1;
            conexion.Open();

            comando.Connection = conexion;
            comando.CommandType = CommandType.TableDirect;
            comando.CommandText = "Libro";

            DataSet DS = new DataSet();
            adaptador = new OleDbDataAdapter(comando);
            adaptador.Fill(DS, "Libro");

            Grilla.DataSource = null;
            Grilla.DataSource = DS.Tables["Libro"];

            conexion.Close();
        }
        catch (Exception x)
        {
            MessageBox.Show(x.Message);

        }

    }
    public void Listar(DataGridView Grilla, string Xd)
    {
        try
        {
            conexion.ConnectionString = CadenaConexion1;
            conexion.Open();
            
            comando.Connection = conexion;
            comando.CommandType = CommandType.TableDirect;
            comando.CommandText = Xd;
           
           adaptador = new OleDbDataAdapter(comando);
            DataSet DS = new DataSet();
            adaptador.Fill(DS, "Resultado");
           
            Grilla.DataSource = null;
            Grilla.DataSource = DS.Tables["Resultado"];
            
            conexion.Close();
        }
        catch (Exception x)
        {
            MessageBox.Show(x.Message);
            conexion.Close();
        }
    }
}

