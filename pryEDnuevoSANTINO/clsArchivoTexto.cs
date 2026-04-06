using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//agregou una libreria que me permite procesar archivos 
using System.IO;
using System.Windows.Forms;
using System.Drawing.Text;
using System.Security.Cryptography.X509Certificates;

namespace pryEDnuevoSANTINO
{

    internal class clsArchivoTexto
    {
        //crreamos campo 
        public String NomArchi = "colores.txt";

        public void grabar()
        {
            //abrir archivo para escritura 
            StreamWriter AD = new StreamWriter(NomArchi);
            AD.WriteLine("hola!!");
            AD.Close();

        }

        public void grabar(String datos)
        {
            //abrir archivo para escritura 
            StreamWriter AD = new StreamWriter(NomArchi);
            AD.WriteLine(datos);
            AD.Close();

        }

        public void Recorrer(ComboBox cmbDatos)
        {
            //abrir archivo para lectura 
            cmbDatos.Items.Clear();
            string DatoLeido = "";
            StreamReader AD = new StreamReader(NomArchi);
            DatoLeido = AD.ReadLine();


            while (DatoLeido != null)
            {
                //aca van las lineas de codigo que hagan falta
                cmbDatos.Items.Add(DatoLeido);
                DatoLeido = AD.ReadLine();
            }
            AD.Close();
        }
        
       
    }
}